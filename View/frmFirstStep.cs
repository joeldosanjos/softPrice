using softPrice.Controller;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Módulo para o movimento de tela
using System.Collections;
using System.Collections.Generic;

namespace softPrice.View
{
    public partial class frmFirstStep : Form
    {
        public frmFirstStep()
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

        private void frmFirstStep_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            panelCampo2.Visible = false;
            panelCampo3.Visible = false;
            panelCampo4.Visible = false;
            panelCampo5.Visible = false;
            panelCampo6.Visible = false;
        }

        private void frmFirstStep_MouseMove(object sender, MouseEventArgs e)
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

        private void campoAdicionar1_Click(object sender, EventArgs e)
        {
            panelCampo2.Visible = true;
            panelAddCampo2.Visible = false;
            panelAddCampo3.Visible = true;
        }
        private void campoAdicionar2_Click(object sender, EventArgs e)
        {
            panelCampo3.Visible = true;
            panelAddCampo3.Visible = false;
            panelAddCampo4.Visible = true;
        }
        private void campoAdicionar3_Click(object sender, EventArgs e)
        {
            panelCampo4.Visible = true;
            panelAddCampo4.Visible = false;
            panelAddCampo5.Visible = true;

        }
        private void campoAdicionar4_Click(object sender, EventArgs e)
        {
            panelCampo5.Visible = true;
            panelAddCampo5.Visible = false;
            panelAddCampo6.Visible = true;
        }
        private void campoAdicionar5_Click(object sender, EventArgs e)
        {
            panelCampo6.Visible = true;
            panelAddCampo6.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmHome swh = new frmHome();
            this.Hide();
            swh.Show();
        }

        // O Dictionary foi utilizado porque permite identificar os endereços dos dados atráves de nomes,
        // isso facilita na organização e compreensão do código.
        Dictionary<string, dynamic> resultados = new Dictionary<string, dynamic>() {
                // Ele é composto de uma String e um dynamic, assim é possível adicionar qualquer tipo de valor.
                {"recursosFisicos", 0},
                {"custoFixo", 0},
                {"fatoresProducao", 0},
                {"HomemHora", 0},
                {"nFuncionarios", 0},
                {"nHoras", 0},
                {"NomeProjeto", ""}
            };
        public void btnAvancar_Click(object sender, EventArgs e)
        {
            double cf = 0;

            // Se os campos não estiverem preenchidos, é adicionado o valor 0 na variável,
            // afim de previnir erros;
            if (campoQuantidade1.Text == "" || campoPreco1.Text == "") cf += 0;
            else cf += Int32.Parse(campoQuantidade1.Text) * double.Parse(campoPreco1.Text) / 60;

            if (campoQuantidade2.Text == "" || campoPreco2.Text == "") cf += 0;
            else cf += Int32.Parse(campoQuantidade2.Text) * double.Parse(campoPreco2.Text) / 60;

            if (campoQuantidade3.Text == "" || campoPreco3.Text == "") cf += 0;
            else cf += Int32.Parse(campoQuantidade3.Text) * double.Parse(campoPreco3.Text) / 60;

            if (campoQuantidade4.Text == "" || campoPreco4.Text == "") cf += 0;
            else cf += Int32.Parse(campoQuantidade4.Text) * double.Parse(campoPreco4.Text) / 60;

            if (campoQuantidade5.Text == "" || campoPreco5.Text == "") cf += 0;
            else cf += Int32.Parse(campoQuantidade5.Text) * double.Parse(campoPreco5.Text) / 60;

            if (campoQuantidade6.Text == "" || campoPreco6.Text == "") cf += 0;
            else cf += Int32.Parse(campoQuantidade6.Text) * double.Parse(campoPreco6.Text) / 60;

            resultados["recursosFisicos"] = cf;

            // O Dictionary é passado como parâmetro para a próxima tela.
            frmSecondStep swh = new frmSecondStep(resultados);
            this.Hide();
            swh.Show();
        }

        private void panelBarra_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
