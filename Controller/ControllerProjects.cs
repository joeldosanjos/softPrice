using MySql.Data.MySqlClient;
using softPrice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using softPrice.Data;
using System.Collections;

namespace softPrice.Controller
{
    class ControllerProjects
    {
        private Conexao con = new Conexao();

        public ArrayList PuxarNome()
        {
            MySqlCommand comando = new MySqlCommand(null, con.setConexao());
            try 
            { 
                int id = UserData.id;

                comando.CommandText = "SELECT nome_projeto FROM valores WHERE id_user=@id";

                comando.Parameters.AddWithValue("@id", id);
                comando.CommandType = CommandType.Text;

                con.Conectar();
                MySqlDataReader myReader = comando.ExecuteReader();
                bool temLinhas = myReader.HasRows;
                ArrayList list = new ArrayList();
                while (myReader.Read())
                {
                    String dado = myReader["nome_projeto"].ToString();
                    list.Add(dado);
                }
                con.Desconectar();
                return list;
            }
            catch
            {
                MessageBox.Show("Erro");
                return null;

            }
        }
        public void PuxarDados(string projeto){
            
            try
            {
                MySqlCommand comando = new MySqlCommand(null, con.setConexao());

                comando.CommandText = "SELECT id_projeto,id_user,recursos_fisicos,custos_fixos,fatores_de_producao,homem_hora,custo_total,preco_indicado,nome_projeto FROM valores WHERE nome_projeto=@projeto";

                comando.Parameters.AddWithValue("@projeto", projeto);
                comando.CommandType = CommandType.Text;

                con.Conectar();
                MySqlDataReader myReader = comando.ExecuteReader();
                myReader.Read();
                UserData.idProjeto = myReader.GetInt32("id_projeto");
                UserData.idUser = myReader.GetInt32("id_user");
                UserData.recursosFisicos = myReader.GetDouble("recursos_fisicos");
                UserData.custosFixos = myReader.GetDouble("custos_fixos");
                UserData.fatoresProducao = myReader.GetDouble("fatores_de_producao");
                UserData.homemHora = myReader.GetDouble("homem_hora");
                UserData.custoTotal = myReader.GetDouble("custo_total");
                UserData.precoIndicado = myReader.GetDouble("preco_indicado");
                UserData.nomeProjeto = myReader.GetString("nome_projeto");


                con.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);

            }

        }
    }
}
