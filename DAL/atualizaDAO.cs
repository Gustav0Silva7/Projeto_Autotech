using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Autotech_2.DAL
{
    class AtualizacaoDAO
    {
        private MySqlCommand cmd;
        private conexaoDAO con;
        public string mensagem;

        public AtualizacaoDAO()
        {
            this.mensagem = "";
            con = new conexaoDAO();
        }

        public bool AtualizarCliente(string nome, string sobrenome, DateTime data_nascimento, string logradouro,string estado, string email, string senha)
        {
            cmd = new MySqlCommand();

            cmd.CommandText = "UPDATE cliente SET nome = @nome, sobrenome = @sobrenome, data_nascimento = @dataNascimento, logradouro = @logradouro, estado = @estado, email = @email, senha = @senha WHERE email = @email";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@sobrenome", sobrenome);
            cmd.Parameters.AddWithValue("@dataNascimento", data_nascimento);
            cmd.Parameters.AddWithValue("@logradouro", logradouro);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
            }
            catch (MySqlException)
            {
                mensagem = "Erro ao conectar com o banco de dados";
            }

            return false;
        }
    }

}
