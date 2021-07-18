using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace softPrice.Controller
{
    class Conexao
    {
        static string sql = "server = localhost; port=3306;user=root;password= ;database=softprice";
        MySqlConnection conexao = new MySqlConnection(sql);
        public void Conectar()
        {
            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public void Desconectar()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public MySqlConnection setConexao()
        {
            return conexao;
        }
    }
}
