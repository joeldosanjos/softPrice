namespace softPrice.View
{
    partial class frmFifthStep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFifthStep));
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.panelTituloPrograma = new System.Windows.Forms.Label();
            this.panelIcone = new System.Windows.Forms.Panel();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelBorda = new System.Windows.Forms.Panel();
            this.panelCampoLucro = new System.Windows.Forms.Panel();
            this.campoLucro = new System.Windows.Forms.NumericUpDown();
            this.panelTituloLucro = new System.Windows.Forms.Panel();
            this.panelCampoNomeProjeto = new System.Windows.Forms.Panel();
            this.campoNomeProjeto = new System.Windows.Forms.TextBox();
            this.panelTituloNomeProjeto = new System.Windows.Forms.Panel();
            this.panelTituloEtapa = new System.Windows.Forms.Panel();
            this.panelBarra.SuspendLayout();
            this.panelBorda.SuspendLayout();
            this.panelCampoLucro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campoLucro)).BeginInit();
            this.panelCampoNomeProjeto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.panelBarra.Controls.Add(this.btnFechar);
            this.panelBarra.Controls.Add(this.btnMin);
            this.panelBarra.Controls.Add(this.panelTituloPrograma);
            this.panelBarra.Controls.Add(this.panelIcone);
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(771, 36);
            this.panelBarra.TabIndex = 42;
            this.panelBarra.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarra_Paint);
            this.panelBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseMove);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(737, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(34, 36);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(703, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(34, 36);
            this.btnMin.TabIndex = 5;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panelTituloPrograma
            // 
            this.panelTituloPrograma.AutoSize = true;
            this.panelTituloPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTituloPrograma.ForeColor = System.Drawing.Color.White;
            this.panelTituloPrograma.Location = new System.Drawing.Point(51, 3);
            this.panelTituloPrograma.Name = "panelTituloPrograma";
            this.panelTituloPrograma.Size = new System.Drawing.Size(111, 29);
            this.panelTituloPrograma.TabIndex = 4;
            this.panelTituloPrograma.Text = "SoftPrice";
            // 
            // panelIcone
            // 
            this.panelIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIcone.BackgroundImage")));
            this.panelIcone.Location = new System.Drawing.Point(3, 1);
            this.panelIcone.Name = "panelIcone";
            this.panelIcone.Size = new System.Drawing.Size(46, 36);
            this.panelIcone.TabIndex = 4;
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.btnAvancar.FlatAppearance.BorderSize = 0;
            this.btnAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvancar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAvancar.Image = ((System.Drawing.Image)(resources.GetObject("btnAvancar.Image")));
            this.btnAvancar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAvancar.Location = new System.Drawing.Point(637, 370);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAvancar.Size = new System.Drawing.Size(122, 31);
            this.btnAvancar.TabIndex = 44;
            this.btnAvancar.Text = "AVANÇAR";
            this.btnAvancar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(12, 374);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVoltar.Size = new System.Drawing.Size(104, 23);
            this.btnVoltar.TabIndex = 43;
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panelBorda
            // 
            this.panelBorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorda.Controls.Add(this.panelCampoLucro);
            this.panelBorda.Controls.Add(this.panelTituloLucro);
            this.panelBorda.Controls.Add(this.panelCampoNomeProjeto);
            this.panelBorda.Controls.Add(this.panelTituloNomeProjeto);
            this.panelBorda.Controls.Add(this.panelTituloEtapa);
            this.panelBorda.Location = new System.Drawing.Point(0, 36);
            this.panelBorda.Name = "panelBorda";
            this.panelBorda.Size = new System.Drawing.Size(771, 377);
            this.panelBorda.TabIndex = 45;
            // 
            // panelCampoLucro
            // 
            this.panelCampoLucro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCampoLucro.BackgroundImage")));
            this.panelCampoLucro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelCampoLucro.Controls.Add(this.campoLucro);
            this.panelCampoLucro.Location = new System.Drawing.Point(237, 244);
            this.panelCampoLucro.Name = "panelCampoLucro";
            this.panelCampoLucro.Size = new System.Drawing.Size(303, 27);
            this.panelCampoLucro.TabIndex = 49;
            // 
            // campoLucro
            // 
            this.campoLucro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.campoLucro.Location = new System.Drawing.Point(101, 6);
            this.campoLucro.Name = "campoLucro";
            this.campoLucro.Size = new System.Drawing.Size(99, 16);
            this.campoLucro.TabIndex = 47;
            this.campoLucro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.campoLucro.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // panelTituloLucro
            // 
            this.panelTituloLucro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTituloLucro.BackgroundImage")));
            this.panelTituloLucro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelTituloLucro.Location = new System.Drawing.Point(123, 191);
            this.panelTituloLucro.Name = "panelTituloLucro";
            this.panelTituloLucro.Size = new System.Drawing.Size(527, 33);
            this.panelTituloLucro.TabIndex = 49;
            // 
            // panelCampoNomeProjeto
            // 
            this.panelCampoNomeProjeto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCampoNomeProjeto.BackgroundImage")));
            this.panelCampoNomeProjeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelCampoNomeProjeto.Controls.Add(this.campoNomeProjeto);
            this.panelCampoNomeProjeto.Location = new System.Drawing.Point(237, 134);
            this.panelCampoNomeProjeto.Name = "panelCampoNomeProjeto";
            this.panelCampoNomeProjeto.Size = new System.Drawing.Size(303, 27);
            this.panelCampoNomeProjeto.TabIndex = 48;
            // 
            // campoNomeProjeto
            // 
            this.campoNomeProjeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoNomeProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNomeProjeto.Location = new System.Drawing.Point(9, 4);
            this.campoNomeProjeto.Name = "campoNomeProjeto";
            this.campoNomeProjeto.Size = new System.Drawing.Size(286, 19);
            this.campoNomeProjeto.TabIndex = 50;
            this.campoNomeProjeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelTituloNomeProjeto
            // 
            this.panelTituloNomeProjeto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTituloNomeProjeto.BackgroundImage")));
            this.panelTituloNomeProjeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelTituloNomeProjeto.Location = new System.Drawing.Point(241, 90);
            this.panelTituloNomeProjeto.Name = "panelTituloNomeProjeto";
            this.panelTituloNomeProjeto.Size = new System.Drawing.Size(291, 28);
            this.panelTituloNomeProjeto.TabIndex = 1;
            // 
            // panelTituloEtapa
            // 
            this.panelTituloEtapa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTituloEtapa.BackgroundImage")));
            this.panelTituloEtapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelTituloEtapa.Location = new System.Drawing.Point(27, 25);
            this.panelTituloEtapa.Name = "panelTituloEtapa";
            this.panelTituloEtapa.Size = new System.Drawing.Size(151, 27);
            this.panelTituloEtapa.TabIndex = 0;
            // 
            // frmFifthStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 413);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panelBorda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFifthStep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftPrice";
            this.Load += new System.EventHandler(this.frmFifthStep_Load);
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.panelBorda.ResumeLayout(false);
            this.panelCampoLucro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.campoLucro)).EndInit();
            this.panelCampoNomeProjeto.ResumeLayout(false);
            this.panelCampoNomeProjeto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label panelTituloPrograma;
        private System.Windows.Forms.Panel panelIcone;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panelBorda;
        private System.Windows.Forms.NumericUpDown campoLucro;
        private System.Windows.Forms.Panel panelCampoLucro;
        private System.Windows.Forms.Panel panelTituloLucro;
        private System.Windows.Forms.Panel panelCampoNomeProjeto;
        private System.Windows.Forms.TextBox campoNomeProjeto;
        private System.Windows.Forms.Panel panelTituloNomeProjeto;
        private System.Windows.Forms.Panel panelTituloEtapa;
    }
}