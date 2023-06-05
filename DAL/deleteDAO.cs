using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Autotech_2.DAL
{
    class deleteDAO
    {
        private MySqlCommand cmd;
        private conexaoDAO con;
        public string mensagem;
        public deleteDAO()
        {
            this.mensagem = "";
            con = new conexaoDAO();
        }
        public bool DeletarCliente(string email)
        {
            con = new conexaoDAO();
            cmd = new MySqlCommand();

            cmd.CommandText = "DELETE FROM cliente WHERE email = @email";
            cmd.Parameters.AddWithValue("@email", email);

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
