using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Autotech_2.DAL
{
    class ProdutoDAO
    {
        private MySqlCommand cmd;
        private conexaoDAO con;
        public string mensagem;

        public class Produto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Marca { get; set; }
            public DateTime DataProducao { get; set; }
            public int GarantiaAnos { get; set; }
            public int Estoque { get; set; }
            public float Preco { get; set; }

        }


        public List<Produto> ObterProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            con = new conexaoDAO();
            cmd = new MySqlCommand();

            cmd.CommandText = "SELECT id_produtos, nome, marca, data_producao, garantia_anos, estoque, preco FROM produtos";

            try
            {
                cmd.Connection = con.conectar();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Produto produto = new Produto();
                        produto.Id = Convert.ToInt32(dr["id_produtos"]);
                        produto.Nome = dr["nome"].ToString();
                        produto.Marca = dr["marca"].ToString();
                        produto.DataProducao = Convert.ToDateTime(dr["data_producao"]);
                        produto.GarantiaAnos = Convert.ToInt32(dr["garantia_anos"]);
                        produto.Estoque = Convert.ToInt32(dr["estoque"]);
                        produto.Preco = Convert.ToSingle(dr["preco"]);

                        produtos.Add(produto);
                    }
                }
                   
            }
            catch (MySqlException)
            {
                mensagem = "Erro ao conectar com o banco de dados";
            }

            return produtos;
        }
        public string ConsultarNomeProduto(int idProduto)
        {
            string nomeProduto = "";

            con = new conexaoDAO();
            cmd = new MySqlCommand();

            cmd.CommandText = "SELECT nome FROM produtos WHERE id_produtos = @idProduto";
            cmd.Parameters.AddWithValue("@idProduto", idProduto);

            try
            {
                cmd.Connection = con.conectar();
                nomeProduto = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (MySqlException)
            {
                mensagem = "Erro ao consultar o nome do produto";
            }

            return nomeProduto;
        }
    }
}
