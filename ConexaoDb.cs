using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aplicativo_de_setores
{
    class ConexaoDb
    {
        private string conexaoBanco = "Server=localhost; Database=empresa; Uid=root; Pwd='';";

        public  MySqlConnection Conectar()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(conexaoBanco);
                conexao.Open();
                return conexao;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                return null;
            }
           
        }

    }
}
