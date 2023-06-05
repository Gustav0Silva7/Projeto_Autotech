using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Autotech_2.DAL
{
    class loginDAO
    {
        private MySqlCommand cmd;
        private conexaoDAO con;
        private MySqlDataReader dr;
        public string mensagem;
        public bool verificador;
        public loginDAO()
        {
            this.mensagem = "";
            verificador = false;
        }

        public string nomeCliente { get; private set; }
        public static int clienteEmSessao { get; private set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public bool verificaLogin(string email, string senha)
        {
            con = new conexaoDAO();
            cmd = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM cliente where email = @email and senha = @senha";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    verificador = true;
                    nomeCliente = dr["nome"].ToString();
                    Email = email;
                    Senha = senha;

                    SessaoDAO sessao = new SessaoDAO();
                    sessao.IniciarSessao(email, senha);
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
