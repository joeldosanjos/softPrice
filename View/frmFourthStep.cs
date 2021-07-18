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
using System.Collections;
using System.Diagnostics;

namespace softPrice.View
{
    public partial class frmFourthStep : Form
    {
        Dictionary<string, dynamic> resultados;
        public frmFourthStep(Dictionary<string, dynamic> resultados)
        {
            InitializeComponent();
            this.resultados = resultados;
        }

        #region Código para movimento de tela 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private void frmFourthStep_Load(object sender, EventArgs e)
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmThirdStep swh = new frmThirdStep(resultados);
            this.Hide();
            swh.Show();
        }
        private void btnAvancar_Click(object sender, EventArgs e)
        {
            int nFuncionarios, nHoras;

            if (campoFuncionarios.Text == "") nFuncionarios = 1;
            else nFuncionarios = Int32.Parse(campoFuncionarios.Text);

            if (campoTempoDesenvolvimento.Text == "") nHoras = 1;
            else nHoras = Int32.Parse(campoTempoDesenvolvimento.Text);

            double maoDeObra = nFuncionarios * nHoras * double.Parse(campoHomemHora.Text);
            double encargos = maoDeObra * 0.6;

            resultados["homemHora"] = maoDeObra + encargos + double.Parse(campoDespOperacionais.Text);
            resultados["nFuncionarios"] = nFuncionarios;
            resultados["nHoras"] = nHoras;

            frmFifthStep swh = new frmFifthStep(resultados);
            this.Hide();
            swh.Show();
        }

        private void campoPorcentCustoPesquisa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
