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
using softPrice.View;
using softPrice.Data;

namespace softPrice
{
    public partial class frmPerfil : Form
    {
        public frmPerfil()
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

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            lblNomeCompleto2.Text = UserData.name;
            lblEmail2.Text = UserData.email;
        }

        private void panelBarra_MouseMove(object sender, MouseEventArgs e)
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
            frmHome fr = new frmHome();
            fr.Show();
        }
        private void lblVoltar_MouseEnter(object sender, EventArgs e)
        {
            lblVoltar.BackColor = Color.FromArgb(237, 242, 246);
        }
        private void lblVoltar_MouseLeave(object sender, EventArgs e)
        {
            lblVoltar.BackColor = Color.White;
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPerfilAlterar fr = new frmPerfilAlterar();
            fr.Show();
        }

        private void panelBarra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEmail2_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeCompleto2_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeCompleto_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
