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
using MySqlX.XDevAPI.Common;
using System.Diagnostics;
using softPrice.Data;

namespace softPrice.View
{
    public partial class frmTabela : Form
    {
        double ct, pre;
        Dictionary<string, dynamic> resultados;
        public frmTabela(Dictionary<string, dynamic> resultados)
        {
            InitializeComponent();
            this.resultados = resultados;
        }

        public frmTabela()
        {
        }

        #region Código para movimento de tela 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private void frmTabela_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            // Os valores são mostrados nos campos
            tbRecursosFisicos.Text = $"{resultados["recursosFisicos"]:F2}";
            tbCustosFixos.Text = $"{resultados["custoFixo"]:F2}";
            tbFatoresProducao.Text = $"{resultados["fatoresProducao"]:F2}";
            tbHomemHora.Text = $"{resultados["homemHora"]:F2}";

            ct = resultados["recursosFisicos"] + resultados["custoFixo"] + resultados["homemHora"];
            lblCustoTotal.Text = $"{ct:F2}";

            // Se o projeto já existe no banco de dados, o Preço Indicado é puxado do BD e adicionado a variável.
            if(resultados["nFuncionarios"] == 0) {
                pre = resultados["precoIndicado"];
                btnSalvar.Hide();
            }
            else
            {   // Se é um novo projeto, o cálculo é efetuado e então armazenado na variavel.
                double cvu = resultados["homemHora"] / resultados["nHoras"];
                double pvu = cvu / (1 - resultados["fatoresProducao"]);
                double qe = (resultados["recursosFisicos"] + resultados["custoFixo"]) / (pvu - cvu);
                pre = pvu * resultados["nFuncionarios"] * qe;
            }

            // O campo Preço Indicado recebe o recebe o valor.
            lblPrecoIndicado.Text = $"{pre:F2}";
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
            this.Close();
            frmHome fr = new frmHome();
            fr.Show();
        }
        private void btnEditarTabela_Click(object sender, EventArgs e)
        {
            this.Close();
            frmFirstStep fr = new frmFirstStep();
            fr.Show();
        }

        private void panelBorda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFundoAzul_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBarra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTituloPrecoIndicado_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SendValues enviar = new SendValues();

            enviar.EnviarValores(resultados["recursosFisicos"], resultados["custoFixo"], resultados["fatoresProducao"], resultados["homemHora"], ct, pre, resultados["NomeProjeto"]); 
        }
    }
}
