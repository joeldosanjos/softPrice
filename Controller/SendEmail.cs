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

namespace softPrice.Controller
{
    class SendEmail
    {
        private Conexao con = new Conexao();
        public void EnviarEmail(string email)
        {
            try
            {
                Random randNum = new Random();
                int newsenha = randNum.Next();
                MailMessage _emailMessage = new MailMessage();

                MySqlCommand comando = new MySqlCommand(null, con.setConexao());
                MySqlCommand comando1 = new MySqlCommand(null, con.setConexao());


                //Chamada no banco de dados para pegar o nome do usuário
                comando.CommandText = "SELECT nome FROM user WHERE email=@email";
                comando.Parameters.AddWithValue("@email", email);
                comando.CommandType = CommandType.Text;

                con.Conectar();
                MySqlDataReader myReader = comando.ExecuteReader();
                myReader.Read();
                String nome = myReader["nome"].ToString();
                con.Desconectar();

                _emailMessage.From = new MailAddress("softprice@outlook.com");

                _emailMessage.CC.Add(new MailAddress(email));
                _emailMessage.Subject = "[SoftPrice] Redifinição de Senha";
                _emailMessage.IsBodyHtml = true;
                _emailMessage.Body = "<h2>Olá, "+nome+"!</h2> <br>Sua nova senha é <b>"+newsenha+"</b>.<br>Qualquer dúvida, sinta-se à vontade para" +
                    " mandar um email para softprice@outlook.com. <br><br> Atenciosamente, <br> Equipe SoftPrice";
                

                SmtpClient _smtpClient = new SmtpClient("smtp.live.com", 587);

                _smtpClient.UseDefaultCredentials = false;
                _smtpClient.Credentials = new NetworkCredential("softprice@outlook.com", "projeto_POOSP");

                _smtpClient.EnableSsl = true;

                _smtpClient.Send(_emailMessage);


                //chamada no banco de dados para alterar a senha do usuário
                comando1.CommandText = "UPDATE `user` SET `senha` = md5(@senha) WHERE `email` = @email";
                comando1.Parameters.AddWithValue("@email", email);
                comando1.Parameters.AddWithValue("@senha", newsenha);
                comando1.CommandType = CommandType.Text;

                con.Conectar();
                myReader = comando1.ExecuteReader();
                myReader.Read();
                con.Desconectar();


            }
            catch
            {
                MessageBox.Show("Erro no envio do email", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
