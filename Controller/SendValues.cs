using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using softPrice.Data;

namespace softPrice.Controller
{
    class SendValues
    {
        private Conexao con = new Conexao();
        public void EnviarValores(double recusosFisicos, double custosFixos, double fatoresProducao, double homemHora, double custoTotal, double precoIndicado, String nomeProjeto)
        {
      
            MySqlCommand comando = new MySqlCommand(null, con.setConexao());

            try
            {

                int id = UserData.id;

                comando.CommandText = "INSERT INTO valores (`id_user`,`recursos_fisicos`,`custos_fixos`,`fatores_de_producao`,`homem_hora`,`custo_total`,`preco_indicado`,`nome_projeto`) VALUES (@id,@rf,@cf,@fp,@hh,@ct,@pi,@np)";

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@rf", recusosFisicos);
                comando.Parameters.AddWithValue("@cf", custosFixos);
                comando.Parameters.AddWithValue("@fp", fatoresProducao);
                comando.Parameters.AddWithValue("@hh", homemHora);
                comando.Parameters.AddWithValue("@ct", custoTotal);
                comando.Parameters.AddWithValue("@pi", precoIndicado);
                comando.Parameters.AddWithValue("@np", nomeProjeto);
                comando.CommandType = CommandType.Text;

                con.Conectar();
                MySqlDataReader myReader = comando.ExecuteReader();
                MessageBox.Show("Cadastrado com sucesso!");
                con.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
    }
}
