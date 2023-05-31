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
        private MySqlDataReader dr;
        public string mensagem;
        public bool verificador;


        public cadastroDAO() { 
        
            this.mensagem = "";
            verificador = false;

        }

        public bool verificaCadastro(int id_cliente, string nome, string sobrenome, string data_nascimento, string logradouro,string estado, string email, string senha)
        {
            con = new conexaoDAO();
            cmd = new MySqlCommand();

            cmd.CommandText = "INSERT INTO cliente(id_cliente,nome,sobrenome,data_nascimento,logradouro,estado,email,senha) values(@id_cliente, @nome, @sobrenome, STR_TO_DATE(@data_nascimento, '%d/%m/%Y'), @logradouro, @estado, @email, @senha)";
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@sobrenome", sobrenome);
            cmd.Parameters.AddWithValue("@data_nascimento", data_nascimento);
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
