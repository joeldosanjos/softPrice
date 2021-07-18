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

namespace softPrice.Controller
{
    class ControllerUser
    {
        private Conexao con = new Conexao();
        public void Cadastrar(ModUser mod)
        {
            MySqlCommand comando = new MySqlCommand(null, con.setConexao());
            int c = 0;
            try
            {

                comando.CommandText = "SELECT email FROM user";

                comando.CommandType = CommandType.Text;

                con.Conectar();
                MySqlDataReader myReader = comando.ExecuteReader();
                bool temLinhas = myReader.HasRows;
                while (myReader.Read())
                {
                    String dado = myReader["email"].ToString();
                    if (mod.getEmail() == dado)
                    {
                        MessageBox.Show("Você já possui uma conta", "Aviso!");
                        frmLogin ln = new frmLogin();
                        c = 1;
                    }
                }
                con.Desconectar();
                if (c != 1)
                {
                    try
                    {

                        comando.CommandText = "INSERT INTO user (`nome`,`email`,`senha`) VALUES (@nome,@email,md5(@senha))";

                        comando.Parameters.AddWithValue("@nome", mod.getNome());
                        comando.Parameters.AddWithValue("@email", mod.getEmail());
                        comando.Parameters.AddWithValue("@senha", mod.getSenha());
                        comando.CommandType = CommandType.Text;
                        con.Conectar();
                        myReader = comando.ExecuteReader();
                        MessageBox.Show("Cadastrado com sucesso!");
                        con.Desconectar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro");

            }
            

        }
        public bool Logar(ModUser mod)
        {
            MySqlCommand comando = new MySqlCommand(null, con.setConexao());

            try
            {
         
               
                comando.CommandText = "SELECT id,nome,email,senha FROM user WHERE email=@email and senha=md5(@senha)";
          
                comando.Parameters.AddWithValue("@email", mod.getEmail());
                comando.Parameters.AddWithValue("@senha", mod.getSenha());
                comando.CommandType = CommandType.Text;

                con.Conectar();
                MySqlDataReader myReader = comando.ExecuteReader();
                bool temLinhas = myReader.HasRows;
                myReader.Read();
                UserData.id = myReader.GetInt32("id");
                UserData.name = myReader.GetString("nome");
                UserData.email = myReader.GetString("email");
                UserData.senha = mod.getSenha();


                con.Desconectar();
                return temLinhas;
            }
            catch
            {
                con.Desconectar();
                return false;
            }

        }
        public void Alterar(String name, String email, String senha)
        {
            try
            {
                int id = UserData.id;
                MySqlCommand comando = new MySqlCommand(null, con.setConexao());

                comando.CommandText = "UPDATE `user` SET `nome` = @name, `senha` = md5(@senha), `email` = @email WHERE `id` = @id";
               
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@name", name);
                comando.Parameters.AddWithValue("@senha", senha);
                comando.CommandType = CommandType.Text;

                UserData.name = name;
                UserData.email = email;
                UserData.senha = senha;

                con.Conectar();
                MySqlDataReader myReader = comando.ExecuteReader();
                bool temLinhas = myReader.HasRows;
                con.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
        
            }
        }
    }
}
