namespace softPrice
{
    partial class frmPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfil));
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.labelTituloPrograma = new System.Windows.Forms.Label();
            this.panelIcone = new System.Windows.Forms.Panel();
            this.panelFundoAzul = new System.Windows.Forms.Panel();
            this.panelImagemPerfil = new System.Windows.Forms.Panel();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNomeCompleto2 = new System.Windows.Forms.Label();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.panelBorda = new System.Windows.Forms.Panel();
            this.panelBarra.SuspendLayout();
            this.panelFundoAzul.SuspendLayout();
            this.panelBorda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.panelBarra.Controls.Add(this.btnFechar);
            this.panelBarra.Controls.Add(this.btnMin);
            this.panelBarra.Controls.Add(this.labelTituloPrograma);
            this.panelBarra.Controls.Add(this.panelIcone);
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(787, 35);
            this.panelBarra.TabIndex = 4;
            this.panelBarra.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarra_Paint);
            this.panelBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseMove);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(752, 0);
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
            this.btnMin.Location = new System.Drawing.Point(718, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(34, 36);
            this.btnMin.TabIndex = 5;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // labelTituloPrograma
            // 
            this.labelTituloPrograma.AutoSize = true;
            this.labelTituloPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloPrograma.ForeColor = System.Drawing.Color.White;
            this.labelTituloPrograma.Location = new System.Drawing.Point(51, 3);
            this.labelTituloPrograma.Name = "labelTituloPrograma";
            this.labelTituloPrograma.Size = new System.Drawing.Size(111, 29);
            this.labelTituloPrograma.TabIndex = 4;
            this.labelTituloPrograma.Text = "SoftPrice";
            // 
            // panelIcone
            // 
            this.panelIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIcone.BackgroundImage")));
            this.panelIcone.Location = new System.Drawing.Point(3, 1);
            this.panelIcone.Name = "panelIcone";
            this.panelIcone.Size = new System.Drawing.Size(46, 36);
            this.panelIcone.TabIndex = 4;
            // 
            // panelFundoAzul
            // 
            this.panelFundoAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.panelFundoAzul.Controls.Add(this.panelImagemPerfil);
            this.panelFundoAzul.Location = new System.Drawing.Point(1, 35);
            this.panelFundoAzul.Name = "panelFundoAzul";
            this.panelFundoAzul.Size = new System.Drawing.Size(358, 414);
            this.panelFundoAzul.TabIndex = 8;
            // 
            // panelImagemPerfil
            // 
            this.panelImagemPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelImagemPerfil.BackgroundImage")));
            this.panelImagemPerfil.Location = new System.Drawing.Point(66, 81);
            this.panelImagemPerfil.Name = "panelImagemPerfil";
            this.panelImagemPerfil.Size = new System.Drawing.Size(220, 220);
            this.panelImagemPerfil.TabIndex = 0;
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.BackColor = System.Drawing.Color.White;
            this.lblVoltar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(173)))));
            this.lblVoltar.Location = new System.Drawing.Point(396, 357);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(91, 26);
            this.lblVoltar.TabIndex = 17;
            this.lblVoltar.Text = "VOLTAR";
            this.lblVoltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVoltar.Click += new System.EventHandler(this.lblVoltar_Click);
            this.lblVoltar.MouseEnter += new System.EventHandler(this.lblVoltar_MouseEnter);
            this.lblVoltar.MouseLeave += new System.EventHandler(this.lblVoltar_MouseLeave);
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblNomeCompleto.Location = new System.Drawing.Point(395, 95);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(93, 31);
            this.lblNomeCompleto.TabIndex = 18;
            this.lblNomeCompleto.Text = "NOME";
            this.lblNomeCompleto.Click += new System.EventHandler(this.lblNomeCompleto_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblEmail.Location = new System.Drawing.Point(395, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(102, 31);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "E-MAIL";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblNomeCompleto2
            // 
            this.lblNomeCompleto2.AutoSize = true;
            this.lblNomeCompleto2.BackColor = System.Drawing.Color.White;
            this.lblNomeCompleto2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto2.ForeColor = System.Drawing.Color.Black;
            this.lblNomeCompleto2.Location = new System.Drawing.Point(395, 130);
            this.lblNomeCompleto2.Name = "lblNomeCompleto2";
            this.lblNomeCompleto2.Size = new System.Drawing.Size(310, 31);
            this.lblNomeCompleto2.TabIndex = 21;
            this.lblNomeCompleto2.Text = "Robertinho da Silva Sauro";
            this.lblNomeCompleto2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNomeCompleto2.Click += new System.EventHandler(this.lblNomeCompleto2_Click);
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.BackColor = System.Drawing.Color.White;
            this.lblEmail2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail2.ForeColor = System.Drawing.Color.Black;
            this.lblEmail2.Location = new System.Drawing.Point(395, 216);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(282, 31);
            this.lblEmail2.TabIndex = 22;
            this.lblEmail2.Text = "robertinho@bol.com.br";
            this.lblEmail2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEmail2.Click += new System.EventHandler(this.lblEmail2_Click);
            // 
            // btnAlterarDados
            // 
            this.btnAlterarDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.btnAlterarDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterarDados.FlatAppearance.BorderSize = 0;
            this.btnAlterarDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarDados.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarDados.ForeColor = System.Drawing.Color.White;
            this.btnAlterarDados.Location = new System.Drawing.Point(594, 354);
            this.btnAlterarDados.Name = "btnAlterarDados";
            this.btnAlterarDados.Size = new System.Drawing.Size(161, 34);
            this.btnAlterarDados.TabIndex = 24;
            this.btnAlterarDados.Text = "ALTERAR DADOS";
            this.btnAlterarDados.UseVisualStyleBackColor = false;
            this.btnAlterarDados.Click += new System.EventHandler(this.btnAlterarDados_Click);
            // 
            // panelBorda
            // 
            this.panelBorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorda.Controls.Add(this.btnAlterarDados);
            this.panelBorda.Controls.Add(this.lblVoltar);
            this.panelBorda.Controls.Add(this.lblEmail2);
            this.panelBorda.Controls.Add(this.lblNomeCompleto);
            this.panelBorda.Controls.Add(this.lblNomeCompleto2);
            this.panelBorda.Controls.Add(this.lblEmail);
            this.panelBorda.Location = new System.Drawing.Point(0, 35);
            this.panelBorda.Name = "panelBorda";
            this.panelBorda.Size = new System.Drawing.Size(787, 415);
            this.panelBorda.TabIndex = 25;
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.panelFundoAzul);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.panelBorda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftPrice";
            this.Load += new System.EventHandler(this.frmPerfil_Load);
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.panelFundoAzul.ResumeLayout(false);
            this.panelBorda.ResumeLayout(false);
            this.panelBorda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label labelTituloPrograma;
        private System.Windows.Forms.Panel panelIcone;
        private System.Windows.Forms.Panel panelFundoAzul;
        private System.Windows.Forms.Panel panelImagemPerfil;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNomeCompleto2;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.Panel panelBorda;
    }
}