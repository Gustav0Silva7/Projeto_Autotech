using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Autotech_2.DAL
{
    class cadastroDAO
    {
        private MySqlCommand cmd;
        private conexaoDAO con;
        public string mensagem;
        public bool verificador;



        public cadastroDAO() { 
        
            this.mensagem = "";
            verificador = false;
        }

        public bool verificaCadastro(string nome, string sobrenome, long data_nascimento, string logradouro,string estado, string email, string senha)
        {
            con = new conexaoDAO();
            cmd = new MySqlCommand();

            cmd.CommandText = "INSERT INTO cliente(nome, sobrenome, data_nascimento, logradouro, estado, email, senha) VALUES (@nome, @sobrenome, @data_nascimento, @logradouro, @estado, @email, @senha)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@sobrenome", sobrenome);
            cmd.Parameters.AddWithValue("@data_nascimento", new DateTime (data_nascimento));
            cmd.Parameters.AddWithValue("@logradouro", logradouro);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected >0)
                {
                    verificador = true;
                    SessaoDAO sessao = new SessaoDAO();
                    bool sessaoIniciada = sessao.IniciarSessao(email, senha);
                    if (sessaoIniciada)
                    {  
                        string emailSessao = sessao.Email;
                        string senhaSessao = sessao.Senha;
 
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
