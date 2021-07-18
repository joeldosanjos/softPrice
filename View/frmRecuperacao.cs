using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Módulo para o movimento de tela
using System.Net;
using System.Net.Mail;
using softPrice.Controller;

namespace softPrice
{
    public partial class frmRecuperacao : Form
    {
        int email = 0;
        public frmRecuperacao()
        {
            InitializeComponent();
        }

        #region Código para movimento de tela 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private void frmRecuperacao_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void panelBarra_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (email == 0)
            {
                tbEmail.Text = "";
                email++;
            }
        }
        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (email == 0)
            {
                tbEmail.Text = "";
                email++;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Checa se algum campo está vazio
            if (String.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("O campo de e-mail está vazio.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      

            // Checa se o conteúdo de um dos campos é igual à máscara
            else if (tbEmail.Text == "E-mail")
            {
                MessageBox.Show("O campo de e-mail é inválido.", "Erro", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SendEmail sendEmail = new SendEmail();
                sendEmail.EnviarEmail(tbEmail.Text);

                this.Close();
                frmRecuperacaoSucesso fr = new frmRecuperacaoSucesso();
                fr.Show();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fr = new frmLogin();
            fr.Show();
        }
    }
}
