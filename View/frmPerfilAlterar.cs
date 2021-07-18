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
using System.Net.Mail;
using Microsoft.VisualBasic;
using softPrice.Data;
using softPrice.Controller;

namespace softPrice.View
{
    public partial class frmPerfilAlterar : Form
    {
        ControllerUser control = new ControllerUser();
        public frmPerfilAlterar()
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

        private void frmPerfilAlterar_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            tbNome.Text = UserData.name;
            tbEmail.Text = UserData.email;
            tbSenha.Text = UserData.senha;

        }

        private void panelBarra_Move(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPerfil fr = new frmPerfil();
            fr.Show();
        }
        private void lblVoltar_MouseEnter(object sender, EventArgs e)
        {
            lblVoltar.BackColor = Color.FromArgb(124, 158, 186);
        }
        private void lblVoltar_MouseLeave(object sender, EventArgs e)
        {
            lblVoltar.BackColor = Color.FromArgb(68, 116, 157);
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNome.Text) ||
                String.IsNullOrEmpty(tbEmail.Text) ||
                String.IsNullOrEmpty(tbSenha.Text))
            {
                MessageBox.Show("Um dos campos está vazio.",
                                "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                String email = tbEmail.Text;
                String nome = tbNome.Text;
                String senha = tbSenha.Text;

                control.Alterar(nome, email, senha);
                this.Close();
                frmPerfil fr = new frmPerfil();
                fr.Show();
            }
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
