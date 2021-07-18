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
using softPrice.Data;

namespace softPrice.View
{
    public partial class frmFifthStep : Form
    {
        Dictionary<string, dynamic> resultados;
        public frmFifthStep(Dictionary<string, dynamic> resultados)
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

        private void frmFifthStep_Load(object sender, EventArgs e)
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
            frmFourthStep swh = new frmFourthStep(resultados);
            this.Hide();
            swh.Show();
        }
        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(campoNomeProjeto.Text))
            {
                MessageBox.Show("Digite o nome do projeto", "Aviso!");         
            }else
            {
                resultados["fatoresProducao"] += double.Parse(campoLucro.Text) / 100;
                resultados["NomeProjeto"] = campoNomeProjeto.Text;


                frmTabela swh = new frmTabela(resultados);
                this.Hide();
                swh.Show();
            }
        }

        private void panelBarra_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
