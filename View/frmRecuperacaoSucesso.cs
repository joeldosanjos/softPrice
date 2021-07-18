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

namespace softPrice
{
    public partial class frmRecuperacaoSucesso : Form
    {
        public frmRecuperacaoSucesso()
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

        private void frmRecuperacaoSucesso_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fr = new frmLogin();
            fr.Show();
        }

        private void lblReenviar_MouseEnter(object sender, EventArgs e)
        {
            lblReenviar.Font = new Font(lblReenviar.Font, FontStyle.Underline);
        }
        private void lblReenviar_MouseLeave(object sender, EventArgs e)
        {
            lblReenviar.Font = new Font(lblReenviar.Font, FontStyle.Regular);
        }

        private void lblReenviar_Click(object sender, EventArgs e)
        {
            frmLogin fr = new frmLogin();
        }
    }
}
