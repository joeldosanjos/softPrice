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
using System.Diagnostics;
using softPrice.Controller;
using System.Collections;

namespace softPrice.View
{
    public partial class frmSecondStep : Form
    {
        Dictionary<string, dynamic> resultados;

        public frmSecondStep(Dictionary<string, dynamic> resultados)
        {
            InitializeComponent();
            this.resultados = resultados; // O novo Dictionary recebe os valores do antigo
        }

        #region Código para movimento de tela 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private void frmSecondStep_Load(object sender, EventArgs e)
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
            frmFirstStep swh = new frmFirstStep();
            this.Hide();
            swh.Show();
        }
        private void btnAvancar_Click(object sender, EventArgs e)
        {
            double cf = 0;

            if (campoPreco1.Text == "") cf += 0;
            else cf += double.Parse(campoPreco1.Text);

            if (campoPreco2.Text == "") cf += 0;
            else cf += double.Parse(campoPreco2.Text);

            if (campoPreco3.Text == "") cf += 0;
            else cf += double.Parse(campoPreco3.Text);

            if (campoPreco4.Text == "") cf += 0;
            else cf += double.Parse(campoPreco4.Text);

            if (campoPreco5.Text == "") cf += 0;
            else cf += double.Parse(campoPreco5.Text);

            if (campoPreco6.Text == "") cf += 0;
            else cf += double.Parse(campoPreco6.Text);

            resultados["custoFixo"] = cf;

            frmThirdStep swh = new frmThirdStep(resultados);
            this.Hide();
            swh.Show();
        }
    }
}
