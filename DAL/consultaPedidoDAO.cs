using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Autotech_2.DAL
{
    public class ConsultaPedidoDAO
    {
        private MySqlCommand cmd;
        private conexaoDAO con;
        public string mensagem;

        public class Pedido
        {
            public int IdPedido { get; set; }
            public int IdItem { get; set; }
            public string Descricao { get; set; }
            public float PrecoUnitario { get; set; }
            public DateTime DataPedido { get; set; }
            public int IdCliente { get; set; }
        }
        public List<Pedido> ConsultarPedidosPorCliente(int idCliente)
        {
            List<Pedido> pedidos = new List<Pedido>();

            con = new conexaoDAO();
            cmd = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM pedido WHERE fk_cliente = @fk_cliente";
            cmd.Parameters.AddWithValue("@fk_cliente", idCliente);

            try
            {
                cmd.Connection = con.conectar();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Pedido pedido = new Pedido();
                        pedido.IdPedido = Convert.ToInt32(dr["id_pedido"]);
                        pedido.IdItem = Convert.ToInt32(dr["fk_produtos"]);
                        pedido.IdCliente = Convert.ToInt32(dr["fk_cliente"]);
                        pedido.PrecoUnitario = Convert.ToSingle(dr["preco_unitario"]);
                        pedido.DataPedido = Convert.ToDateTime(dr["data_pedido"]);

                        pedidos.Add(pedido);
                    }
                }
            }
            catch (MySqlException)
            {
                mensagem = "Erro ao consultar os pedidos do cliente";
            }

            return pedidos;
        }
    }


}
