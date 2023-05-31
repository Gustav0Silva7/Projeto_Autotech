using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Autotech_2.DAL
{
    class conexaoDAO
    {

        private MySqlConnection conexao = new MySqlConnection();
        private string sqlConexao;

        public conexaoDAO()
        {
            conexao.ConnectionString = "server=localhost;database=db_autotech;Uid=root;Pwd=root";
        }

        public MySqlConnection conectar()
        {
            if(conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }

        public void deconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
