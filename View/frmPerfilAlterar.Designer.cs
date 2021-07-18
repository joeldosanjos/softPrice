namespace softPrice.View
{
    partial class frmPerfilAlterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfilAlterar));
            this.panelIcone = new System.Windows.Forms.Panel();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.labelTituloPrograma = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.panelImagem = new System.Windows.Forms.Panel();
            this.panelBorda = new System.Windows.Forms.Panel();
            this.panelBarra.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBorda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIcone
            // 
            this.panelIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIcone.BackgroundImage")));
            this.panelIcone.Location = new System.Drawing.Point(3, 1);
            this.panelIcone.Name = "panelIcone";
            this.panelIcone.Size = new System.Drawing.Size(46, 36);
            this.panelIcone.TabIndex = 4;
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
            this.panelBarra.TabIndex = 5;
            this.panelBarra.Move += new System.EventHandler(this.panelBarra_Move);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.lblVoltar);
            this.panel1.Location = new System.Drawing.Point(357, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 416);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblVoltar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltar.ForeColor = System.Drawing.Color.White;
            this.lblVoltar.Location = new System.Drawing.Point(40, 360);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(91, 26);
            this.lblVoltar.TabIndex = 17;
            this.lblVoltar.Text = "VOLTAR";
            this.lblVoltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVoltar.Click += new System.EventHandler(this.lblVoltar_Click);
            this.lblVoltar.MouseEnter += new System.EventHandler(this.lblVoltar_MouseEnter);
            this.lblVoltar.MouseLeave += new System.EventHandler(this.lblVoltar_MouseLeave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(389, 146);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(102, 31);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "E-MAIL";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.ForeColor = System.Drawing.Color.White;
            this.lblNomeCompleto.Location = new System.Drawing.Point(389, 60);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(93, 31);
            this.lblNomeCompleto.TabIndex = 18;
            this.lblNomeCompleto.Text = "NOME";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblSenha.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(389, 234);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(100, 31);
            this.lblSenha.TabIndex = 20;
            this.lblSenha.Text = "SENHA";
            // 
            // btnAlterarDados
            // 
            this.btnAlterarDados.BackColor = System.Drawing.Color.White;
            this.btnAlterarDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterarDados.FlatAppearance.BorderSize = 0;
            this.btnAlterarDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarDados.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.btnAlterarDados.Location = new System.Drawing.Point(594, 355);
            this.btnAlterarDados.Name = "btnAlterarDados";
            this.btnAlterarDados.Size = new System.Drawing.Size(161, 34);
            this.btnAlterarDados.TabIndex = 24;
            this.btnAlterarDados.Text = "CONFIRMAR";
            this.btnAlterarDados.UseVisualStyleBackColor = true;
            this.btnAlterarDados.Click += new System.EventHandler(this.btnAlterarDados_Click);
            // 
            // tbNome
            // 
            this.tbNome.BackColor = System.Drawing.Color.White;
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNome.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.ForeColor = System.Drawing.Color.Black;
            this.tbNome.Location = new System.Drawing.Point(395, 95);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(360, 32);
            this.tbNome.TabIndex = 28;
            this.tbNome.Text = "Robertinho da Silva Sauro";
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.Location = new System.Drawing.Point(395, 181);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(360, 32);
            this.tbEmail.TabIndex = 29;
            this.tbEmail.Text = "robertinho@bol.com.br";
            // 
            // tbSenha
            // 
            this.tbSenha.BackColor = System.Drawing.Color.White;
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSenha.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenha.ForeColor = System.Drawing.Color.Black;
            this.tbSenha.Location = new System.Drawing.Point(395, 270);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(360, 32);
            this.tbSenha.TabIndex = 30;
            this.tbSenha.UseSystemPasswordChar = true;
            this.tbSenha.TextChanged += new System.EventHandler(this.tbSenha_TextChanged);
            // 
            // panelImagem
            // 
            this.panelImagem.BackColor = System.Drawing.Color.White;
            this.panelImagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelImagem.BackgroundImage")));
            this.panelImagem.Location = new System.Drawing.Point(66, 60);
            this.panelImagem.Name = "panelImagem";
            this.panelImagem.Size = new System.Drawing.Size(220, 220);
            this.panelImagem.TabIndex = 0;
            // 
            // panelBorda
            // 
            this.panelBorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorda.Controls.Add(this.panelImagem);
            this.panelBorda.Controls.Add(this.tbSenha);
            this.panelBorda.Controls.Add(this.tbEmail);
            this.panelBorda.Controls.Add(this.tbNome);
            this.panelBorda.Controls.Add(this.btnAlterarDados);
            this.panelBorda.Controls.Add(this.lblSenha);
            this.panelBorda.Controls.Add(this.lblNomeCompleto);
            this.panelBorda.Controls.Add(this.lblEmail);
            this.panelBorda.Controls.Add(this.panel1);
            this.panelBorda.Location = new System.Drawing.Point(0, 34);
            this.panelBorda.Name = "panelBorda";
            this.panelBorda.Size = new System.Drawing.Size(787, 416);
            this.panelBorda.TabIndex = 26;
            // 
            // frmPerfilAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.panelBorda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPerfilAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftPrice";
            this.Load += new System.EventHandler(this.frmPerfilAlterar_Load);
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBorda.ResumeLayout(false);
            this.panelBorda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIcone;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label labelTituloPrograma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Panel panelImagem;
        private System.Windows.Forms.Panel panelBorda;
    }
}