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
using Microsoft.VisualBasic.ApplicationServices;
using softPrice.Data;
using softPrice.Controller;
using System.Collections;

namespace softPrice
{
    public partial class frmHome : Form
    {
        ControllerProjects dados = new ControllerProjects();
        public frmHome()
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

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            /*foreach(int element in f){

            }*/

            int c = 0;
            lblBoasVindas.Text = "Olá, "+UserData.name+"!";
            ArrayList list = new ArrayList();
            list = dados.PuxarNome();

            while (list.Count != c)
            {
                dgvProjetos.Rows.Add(list[c]);
                c++;
            }
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

        private void lblPerfil_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPerfil fr = new frmPerfil();
            fr.Show();
        }
        private void lblPerfil_MouseEnter(object sender, EventArgs e)
        {
            lblPerfil.BackColor = Color.FromArgb(237, 242, 246);
        }
        private void lblPerfil_MouseLeave(object sender, EventArgs e)
        {
            lblPerfil.BackColor = Color.White;
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            UserData.id = 0;
            UserData.name = "";
            UserData.email = "";
            UserData.senha = "";
            this.Close();
            frmInicio fr = new frmInicio();
            fr.Show();
        }
        private void lblSair_MouseEnter(object sender, EventArgs e)
        {
            lblSair.BackColor = Color.FromArgb(237, 242, 246);
        }
        private void lblSair_MouseLeave(object sender, EventArgs e)
        {
            lblSair.BackColor = Color.White;
        }

        private void btnAdicionarProjeto_Click(object sender, EventArgs e)
        {
            this.Close();
            frmFirstStep fr = new frmFirstStep();
            fr.Show();
        }

        

        private void dgvProjetos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProjetos.Columns["Entrar"].Index && e.RowIndex >= 0)
            {

                int num = dgvProjetos.CurrentCell.RowIndex;
                //int num = dgvProjetos.Columns["Entrar"].Index;
                ArrayList list = new ArrayList();
                list = dados.PuxarNome();
                dados.PuxarDados(list[num].ToString());

                Dictionary<string, dynamic> resultados = new Dictionary<string, dynamic>() {
                {"recursosFisicos", UserData.recursosFisicos},
                {"custoFixo", UserData.custosFixos},
                {"fatoresProducao", UserData.fatoresProducao},
                {"homemHora", UserData.homemHora},
                {"precoIndicado", UserData.precoIndicado},
                {"nFuncionarios", 0}
            };

                this.Close();
                frmTabela fr = new frmTabela(resultados); // Marco: deixei essa parte comentada porque a Tabela precisa receber um parâmetro.
                fr.Show();                      // Neste caso, o parâmetro vem do BD, então, preciso conversar com o Rosa primeiro.
                
            }
        }

        private void lblBoasVindas_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void panelBorda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBarra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProjetos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
