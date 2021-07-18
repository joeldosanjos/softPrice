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
    public partial class frmCadastro : Form
    {
        int nome = 0, email = 0, senha = 0, senhaConfirmar = 0; // Variáveis usadas para não resetar
                                                                // os campos do formulário.
        ControllerUser control = new ControllerUser();
        ModUser mod = new ModUser();
        public frmCadastro()
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

        private void frmCadastro_Load(object sender, EventArgs e)
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

        private void tbNome_MouseClick(object sender, MouseEventArgs e)
        {
            if (nome == 0)
            {
                tbNome.Text = "";
                nome++;
            }
        }
        private void tbNome_Enter(object sender, EventArgs e)
        {
            if (nome == 0)
            {
                tbNome.Text = "";
                nome++;
            }
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
            tbSenha.PasswordChar = '*';
        }
        private void tbSenha_Enter(object sender, EventArgs e)
        {
            if (senha == 0)
            {
                tbSenha.Text = "";
                senha++;
            }
            tbSenha.PasswordChar = '*';
        }

        private void tbSenhaConfirmar_MouseClick(object sender, MouseEventArgs e)
        {
            if (senhaConfirmar == 0)
            {
                tbSenhaConfirmar.Text = "";
                senhaConfirmar++;
            }
            tbSenhaConfirmar.PasswordChar = '*';
        }
        private void tbSenhaConfirmar_Enter(object sender, EventArgs e)
        {
            if (senhaConfirmar == 0)
            {
                tbSenhaConfirmar.Text = "";
                senhaConfirmar++;
            }
            tbSenhaConfirmar.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Checa se algum campo está vazio
            if (String.IsNullOrEmpty(tbNome.Text) ||
                String.IsNullOrEmpty(tbEmail.Text) ||
                String.IsNullOrEmpty(tbSenha.Text) ||
                String.IsNullOrEmpty(tbSenhaConfirmar.Text))
            {
                MessageBox.Show("Um dos campos está vazio.",
                                "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            // Checa se o conteúdo de um dos campos é igual à máscara
            else if (tbNome.Text == "Nome" ||
                     tbEmail.Text == "E-mail" ||
                     tbSenha.Text == "Senha" ||
                     tbSenhaConfirmar.Text == "Confirmar Senha")
            {
                MessageBox.Show("Um dos campos é inválido.",
                                "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            else
            {
                if (tbSenha.Text == tbSenhaConfirmar.Text)
                {
                    mod.setNome(tbNome.Text);
                    mod.setSenha(tbSenha.Text);
                    mod.setEmail(tbEmail.Text);

                    control.Cadastrar(mod);

                    this.Close();
                    frmLogin fr = new frmLogin();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("As senhas não são iguais.",
                                    "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInicio fr = new frmInicio();
            fr.Show();
        }
    }
}
