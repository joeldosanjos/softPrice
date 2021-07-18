namespace softPrice
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panelPrograma = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.panelImagem = new System.Windows.Forms.Panel();
            this.lblSubtitulo2 = new System.Windows.Forms.Label();
            this.lblSubtitulo1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.lblTituloPrograma = new System.Windows.Forms.Label();
            this.panelIcone = new System.Windows.Forms.Panel();
            this.panelBorda = new System.Windows.Forms.Panel();
            this.lblRecuperar = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelPrograma.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.panelBarra.SuspendLayout();
            this.panelBorda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrograma
            // 
            this.panelPrograma.BackColor = System.Drawing.Color.White;
            this.panelPrograma.Controls.Add(this.btnLogin);
            this.panelPrograma.Controls.Add(this.panelFormulario);
            this.panelPrograma.Controls.Add(this.panelImagem);
            this.panelPrograma.Controls.Add(this.lblSubtitulo2);
            this.panelPrograma.Controls.Add(this.lblSubtitulo1);
            this.panelPrograma.Controls.Add(this.lblTitulo);
            this.panelPrograma.Controls.Add(this.panelBarra);
            this.panelPrograma.Controls.Add(this.panelBorda);
            this.panelPrograma.Location = new System.Drawing.Point(0, 0);
            this.panelPrograma.Name = "panelPrograma";
            this.panelPrograma.Size = new System.Drawing.Size(787, 487);
            this.panelPrograma.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Location = new System.Drawing.Point(114, 331);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(161, 34);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.Controls.Add(this.tbSenha);
            this.panelFormulario.Controls.Add(this.tbEmail);
            this.panelFormulario.Location = new System.Drawing.Point(36, 215);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(316, 150);
            this.panelFormulario.TabIndex = 4;
            // 
            // tbSenha
            // 
            this.tbSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(225)))));
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSenha.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenha.ForeColor = System.Drawing.Color.White;
            this.tbSenha.Location = new System.Drawing.Point(3, 48);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(314, 32);
            this.tbSenha.TabIndex = 1;
            this.tbSenha.Text = "Senha";
            this.tbSenha.UseSystemPasswordChar = true;
            this.tbSenha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbSenha_MouseClick);
            this.tbSenha.Enter += new System.EventHandler(this.tbSenha_Enter);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(225)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.White;
            this.tbEmail.Location = new System.Drawing.Point(1, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(316, 32);
            this.tbEmail.TabIndex = 0;
            this.tbEmail.Text = "E-mail";
            this.tbEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbEmail_MouseClick);
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            // 
            // panelImagem
            // 
            this.panelImagem.BackColor = System.Drawing.Color.Black;
            this.panelImagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelImagem.BackgroundImage")));
            this.panelImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelImagem.Location = new System.Drawing.Point(394, 35);
            this.panelImagem.Name = "panelImagem";
            this.panelImagem.Size = new System.Drawing.Size(392, 438);
            this.panelImagem.TabIndex = 3;
            // 
            // lblSubtitulo2
            // 
            this.lblSubtitulo2.AutoSize = true;
            this.lblSubtitulo2.BackColor = System.Drawing.Color.White;
            this.lblSubtitulo2.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblSubtitulo2.Location = new System.Drawing.Point(35, 169);
            this.lblSubtitulo2.Name = "lblSubtitulo2";
            this.lblSubtitulo2.Size = new System.Drawing.Size(222, 23);
            this.lblSubtitulo2.TabIndex = 2;
            this.lblSubtitulo2.Text = "do preço do seu software.";
            this.lblSubtitulo2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSubtitulo1
            // 
            this.lblSubtitulo1.AutoSize = true;
            this.lblSubtitulo1.BackColor = System.Drawing.Color.White;
            this.lblSubtitulo1.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblSubtitulo1.Location = new System.Drawing.Point(35, 151);
            this.lblSubtitulo1.Name = "lblSubtitulo1";
            this.lblSubtitulo1.Size = new System.Drawing.Size(322, 23);
            this.lblSubtitulo1.TabIndex = 1;
            this.lblSubtitulo1.Text = "Para acessar o SoftPrice e ter controle ";
            this.lblSubtitulo1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblTitulo.Location = new System.Drawing.Point(76, 100);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(236, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "FAÇA O LOGIN";
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.panelBarra.Controls.Add(this.btnFechar);
            this.panelBarra.Controls.Add(this.btnMin);
            this.panelBarra.Controls.Add(this.lblTituloPrograma);
            this.panelBarra.Controls.Add(this.panelIcone);
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(787, 35);
            this.panelBarra.TabIndex = 1;
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
            this.btnFechar.TabIndex = 9;
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
            this.btnMin.TabIndex = 8;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblTituloPrograma
            // 
            this.lblTituloPrograma.AutoSize = true;
            this.lblTituloPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrograma.ForeColor = System.Drawing.Color.White;
            this.lblTituloPrograma.Location = new System.Drawing.Point(51, 3);
            this.lblTituloPrograma.Name = "lblTituloPrograma";
            this.lblTituloPrograma.Size = new System.Drawing.Size(111, 29);
            this.lblTituloPrograma.TabIndex = 4;
            this.lblTituloPrograma.Text = "SoftPrice";
            // 
            // panelIcone
            // 
            this.panelIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIcone.BackgroundImage")));
            this.panelIcone.Location = new System.Drawing.Point(3, 1);
            this.panelIcone.Name = "panelIcone";
            this.panelIcone.Size = new System.Drawing.Size(46, 36);
            this.panelIcone.TabIndex = 4;
            // 
            // panelBorda
            // 
            this.panelBorda.BackColor = System.Drawing.Color.White;
            this.panelBorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorda.Controls.Add(this.lblRecuperar);
            this.panelBorda.Controls.Add(this.btnVoltar);
            this.panelBorda.Location = new System.Drawing.Point(0, 35);
            this.panelBorda.Name = "panelBorda";
            this.panelBorda.Size = new System.Drawing.Size(787, 439);
            this.panelBorda.TabIndex = 10;
            // 
            // lblRecuperar
            // 
            this.lblRecuperar.AutoSize = true;
            this.lblRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblRecuperar.Location = new System.Drawing.Point(213, 407);
            this.lblRecuperar.Name = "lblRecuperar";
            this.lblRecuperar.Size = new System.Drawing.Size(174, 20);
            this.lblRecuperar.TabIndex = 5;
            this.lblRecuperar.Text = "Esqueceu sua senha?";
            this.lblRecuperar.Click += new System.EventHandler(this.lblRecuperar_Click);
            this.lblRecuperar.MouseEnter += new System.EventHandler(this.lblRecuperar_MouseEnter);
            this.lblRecuperar.MouseLeave += new System.EventHandler(this.lblRecuperar_MouseLeave);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(11, 402);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 25);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 474);
            this.Controls.Add(this.panelPrograma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftPrice";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panelPrograma.ResumeLayout(false);
            this.panelPrograma.PerformLayout();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.panelBorda.ResumeLayout(false);
            this.panelBorda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrograma;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Label lblTituloPrograma;
        private System.Windows.Forms.Panel panelIcone;
        private System.Windows.Forms.Panel panelImagem;
        private System.Windows.Forms.Label lblSubtitulo2;
        private System.Windows.Forms.Label lblSubtitulo1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblRecuperar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel panelBorda;
    }
}