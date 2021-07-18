namespace softPrice
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.lblTituloPrograma = new System.Windows.Forms.Label();
            this.panelIcone = new System.Windows.Forms.Panel();
            this.panelImagem = new System.Windows.Forms.Panel();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbSenhaConfirmar = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblSubtitulo2 = new System.Windows.Forms.Label();
            this.lblSubtitulo1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelPrograma = new System.Windows.Forms.Panel();
            this.panelBorda = new System.Windows.Forms.Panel();
            this.panelBarra.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelPrograma.SuspendLayout();
            this.SuspendLayout();
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
            this.panelBarra.TabIndex = 2;
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
            // panelImagem
            // 
            this.panelImagem.BackColor = System.Drawing.Color.Black;
            this.panelImagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelImagem.BackgroundImage")));
            this.panelImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelImagem.Location = new System.Drawing.Point(394, 35);
            this.panelImagem.Name = "panelImagem";
            this.panelImagem.Size = new System.Drawing.Size(392, 445);
            this.panelImagem.TabIndex = 4;
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.Controls.Add(this.btnLogin);
            this.panelFormulario.Controls.Add(this.tbSenhaConfirmar);
            this.panelFormulario.Controls.Add(this.tbSenha);
            this.panelFormulario.Controls.Add(this.tbEmail);
            this.panelFormulario.Controls.Add(this.tbNome);
            this.panelFormulario.Controls.Add(this.panelTitulo);
            this.panelFormulario.Location = new System.Drawing.Point(43, 79);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(305, 334);
            this.panelFormulario.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Location = new System.Drawing.Point(68, 297);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(161, 34);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbSenhaConfirmar
            // 
            this.tbSenhaConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(225)))));
            this.tbSenhaConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSenhaConfirmar.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenhaConfirmar.ForeColor = System.Drawing.Color.White;
            this.tbSenhaConfirmar.Location = new System.Drawing.Point(1, 237);
            this.tbSenhaConfirmar.Name = "tbSenhaConfirmar";
            this.tbSenhaConfirmar.Size = new System.Drawing.Size(300, 32);
            this.tbSenhaConfirmar.TabIndex = 5;
            this.tbSenhaConfirmar.Text = "Confirmar Senha";
            this.tbSenhaConfirmar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbSenhaConfirmar_MouseClick);
            this.tbSenhaConfirmar.Enter += new System.EventHandler(this.tbSenhaConfirmar_Enter);
            // 
            // tbSenha
            // 
            this.tbSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(225)))));
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSenha.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenha.ForeColor = System.Drawing.Color.White;
            this.tbSenha.Location = new System.Drawing.Point(0, 189);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(300, 32);
            this.tbSenha.TabIndex = 4;
            this.tbSenha.Text = "Senha";
            this.tbSenha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbSenha_MouseClick);
            this.tbSenha.Enter += new System.EventHandler(this.tbSenha_Enter);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(225)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.White;
            this.tbEmail.Location = new System.Drawing.Point(0, 143);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(300, 32);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Text = "E-mail";
            this.tbEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbEmail_MouseClick);
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            // 
            // tbNome
            // 
            this.tbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(225)))));
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNome.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.ForeColor = System.Drawing.Color.White;
            this.tbNome.Location = new System.Drawing.Point(0, 97);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(300, 32);
            this.tbNome.TabIndex = 2;
            this.tbNome.Text = "Nome";
            this.tbNome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbNome_MouseClick);
            this.tbNome.Enter += new System.EventHandler(this.tbNome_Enter);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.White;
            this.panelTitulo.Controls.Add(this.lblSubtitulo2);
            this.panelTitulo.Controls.Add(this.lblSubtitulo1);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(3, 3);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(300, 88);
            this.panelTitulo.TabIndex = 0;
            // 
            // lblSubtitulo2
            // 
            this.lblSubtitulo2.AutoSize = true;
            this.lblSubtitulo2.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblSubtitulo2.Location = new System.Drawing.Point(6, 57);
            this.lblSubtitulo2.Name = "lblSubtitulo2";
            this.lblSubtitulo2.Size = new System.Drawing.Size(87, 23);
            this.lblSubtitulo2.TabIndex = 2;
            this.lblSubtitulo2.Text = "SoftPrice.";
            // 
            // lblSubtitulo1
            // 
            this.lblSubtitulo1.AutoSize = true;
            this.lblSubtitulo1.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblSubtitulo1.Location = new System.Drawing.Point(6, 37);
            this.lblSubtitulo1.Name = "lblSubtitulo1";
            this.lblSubtitulo1.Size = new System.Drawing.Size(281, 23);
            this.lblSubtitulo1.TabIndex = 1;
            this.lblSubtitulo1.Text = "Para poder utilizar os recursos do";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblTitulo.Location = new System.Drawing.Point(36, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 39);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "CADASTRE-SE";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(12, 446);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panelPrograma
            // 
            this.panelPrograma.BackColor = System.Drawing.Color.White;
            this.panelPrograma.Controls.Add(this.btnVoltar);
            this.panelPrograma.Controls.Add(this.panelFormulario);
            this.panelPrograma.Controls.Add(this.panelBarra);
            this.panelPrograma.Controls.Add(this.panelImagem);
            this.panelPrograma.Controls.Add(this.panelBorda);
            this.panelPrograma.Location = new System.Drawing.Point(0, 0);
            this.panelPrograma.Name = "panelPrograma";
            this.panelPrograma.Size = new System.Drawing.Size(787, 487);
            this.panelPrograma.TabIndex = 0;
            // 
            // panelBorda
            // 
            this.panelBorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorda.Location = new System.Drawing.Point(0, 35);
            this.panelBorda.Name = "panelBorda";
            this.panelBorda.Size = new System.Drawing.Size(787, 446);
            this.panelBorda.TabIndex = 7;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 481);
            this.Controls.Add(this.panelPrograma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftPrice";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelPrograma.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel panelIcone;
        private System.Windows.Forms.Panel panelImagem;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbSenhaConfirmar;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblSubtitulo2;
        private System.Windows.Forms.Label lblSubtitulo1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panelPrograma;
        private System.Windows.Forms.Panel panelBorda;
        private System.Windows.Forms.Label lblTituloPrograma;
    }
}