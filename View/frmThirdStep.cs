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

namespace softPrice.View
{
    public partial class frmThirdStep : Form
    {
        Dictionary<string, dynamic> resultados;
        public frmThirdStep(Dictionary<string, dynamic> resultados)
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

        private void frmThirdStep_Load(object sender, EventArgs e)
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
            frmSecondStep swh = new frmSecondStep(resultados);
            this.Hide();
            swh.Show();
        }
        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (campoPorcentPISCofins.Text == "") resultados["fatoresProducao"] += 0;
            else resultados["fatoresProducao"] += double.Parse(campoPorcentPISCofins.Text) / 100;

            if (campoPercentISS.Text == "") resultados["fatoresProducao"] += 0;
            else resultados["fatoresProducao"] += double.Parse(campoPercentISS.Text) / 100;

            if (campoPercentDesconto.Text == "") resultados["fatoresProducao"] += 0;
            else resultados["fatoresProducao"] += double.Parse(campoPercentDesconto.Text) / 100;

            if (campoPercentOportunidade.Text == "") resultados["fatoresProducao"] = 0;
            else resultados["fatoresProducao"] += double.Parse(campoPercentOportunidade.Text) / 100;

            if (campoPercentDespOperacional.Text == "") resultados["fatoresProducao"] += 0;
            else resultados["fatoresProducao"] += double.Parse(campoPercentDespOperacional.Text) / 100;

            if (campoPercentComissao.Text == "") resultados["fatoresProducao"] += 0;
            else resultados["fatoresProducao"] += double.Parse(campoPercentComissao.Text) / 100; 

            frmFourthStep swh = new frmFourthStep(resultados);
            this.Hide();
            swh.Show();
        }
    }
}
