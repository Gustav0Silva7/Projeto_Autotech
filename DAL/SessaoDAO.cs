using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Autotech_2.DAL
{
    public class SessaoDAO
    {
        private MySqlCommand cmd;
        private conexaoDAO con;
        public string mensagem;
        public bool verificador;

        public string NomeCliente { get; set; }
        public string SobrenomeCliente { get; set; }
        public DateTime DataNascimentoCliente { get; set; }
        public string LogradouroCliente { get; set; }
        public string EstadoCliente { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public SessaoDAO()
        {
            this.mensagem = "";
            verificador = false;
        }
        public bool IniciarSessao(string email, string senha)
        {
            con = new conexaoDAO();
            cmd = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM cliente WHERE email = @email and senha = @senha";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    verificador = true;
                    Email = email;
                    Senha = senha;
                    while (dr.Read())
                    {

                        NomeCliente = dr["nome"].ToString();
                        SobrenomeCliente = dr["sobrenome"].ToString();
                        DataNascimentoCliente = Convert.ToDateTime(dr["data_nascimento"]);
                        LogradouroCliente = dr["logradouro"].ToString();
                        EstadoCliente = dr["estado"].ToString();
                    }
                }
            }
            catch (MySqlException)
            {
                mensagem = "Erro ao conectar com o banco de dados";
            }

            return verificador;
        }
    }
}
