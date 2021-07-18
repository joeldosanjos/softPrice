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
using softPrice.Controller;
using softPrice.Model;

namespace softPrice
{
    public partial class frmLogin : Form
    {
        private int email = 0, senha = 0; // Variáveis usadas para não resetar
                                          // os campos do formulário
        ControllerUser control = new ControllerUser();
        ModUser mod = new ModUser();
        public frmLogin()
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

        private void frmLogin_Load(object sender, EventArgs e)
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

        private void tbSenha_MouseClick(object sender, MouseEventArgs e)
        {
            if (senha == 0)
            {
                tbSenha.Text = "";
                senha++;
            }
        }
        private void tbSenha_Enter(object sender, EventArgs e)
        {
            if (senha == 0)
            {
                tbSenha.Text = "";
                senha++;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Checa se algum campo está vazio
            if (String.IsNullOrEmpty(tbEmail.Text) ||
                String.IsNullOrEmpty(tbSenha.Text))
            {
                MessageBox.Show("Um dos campos está vazio.",
                                "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            // Checa se o conteúdo de um dos campos é igual à máscara
            else if (tbEmail.Text == "E-mail" ||
                     tbSenha.Text == "Senha")
            {
                MessageBox.Show("Um dos campos é inválido.",
                                "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            else
            {
                mod.setEmail(tbEmail.Text);
                mod.setSenha(tbSenha.Text);
                
                if (!control.Logar(mod))
                {
                    MessageBox.Show("E-mail ou senha inválidos.",
                                "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
                else
                {
                    this.Close();
                    frmHome fr = new frmHome();
                    fr.Show();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInicio fr = new frmInicio();
            fr.Show();
        }

        private void lblRecuperar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRecuperacao fr = new frmRecuperacao();
            fr.Show();
        }
        private void lblRecuperar_MouseEnter(object sender, EventArgs e)
        {
            lblRecuperar.Font = new Font(lblRecuperar.Font, FontStyle.Underline);
        }
        private void lblRecuperar_MouseLeave(object sender, EventArgs e)
        {
            lblRecuperar.Font = new Font(lblRecuperar.Font, FontStyle.Regular);
        }
    }
}
