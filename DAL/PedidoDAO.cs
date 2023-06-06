using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Autotech_2.DAL
{
    public class PedidoDAO
    {
        private MySqlCommand cmd;
        private conexaoDAO con;
        public string mensagem;


        public void InserirPedido(int idProduto, float precoUnitario, int idCliente)
        {
            con = new conexaoDAO();
            cmd = new MySqlCommand();

            cmd.CommandText = "INSERT INTO pedido (fk_produtos, preco_unitario, data_pedido, fk_cliente) VALUES (@fk_produtos, @preco_unitario, @data_pedido, @fk_cliente)";

            try
            {
                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@fk_produtos", idProduto);
                cmd.Parameters.AddWithValue("@preco_unitario", precoUnitario);
                cmd.Parameters.AddWithValue("@data_pedido", DateTime.Now);
                cmd.Parameters.AddWithValue("@fk_cliente", idCliente);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
                mensagem = "Erro ao inserir o pedido no banco de dados";
            }
        }

    }
}
