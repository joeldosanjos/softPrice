namespace softPrice.View
{
    partial class frmTabela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTabela));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.lblTituloPrograma = new System.Windows.Forms.Label();
            this.panelIcone = new System.Windows.Forms.Panel();
            this.panelBorda = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelRecursosFisicos = new System.Windows.Forms.Panel();
            this.tbRecursosFisicos = new System.Windows.Forms.TextBox();
            this.panelCustosFixos = new System.Windows.Forms.Panel();
            this.tbCustosFixos = new System.Windows.Forms.TextBox();
            this.panelFatoresProducao = new System.Windows.Forms.Panel();
            this.tbFatoresProducao = new System.Windows.Forms.TextBox();
            this.panelHomemHora = new System.Windows.Forms.Panel();
            this.tbHomemHora = new System.Windows.Forms.TextBox();
            this.lblHomemHora = new System.Windows.Forms.Label();
            this.lblFatoresProducao = new System.Windows.Forms.Label();
            this.lblCustosFixos = new System.Windows.Forms.Label();
            this.lblRecursosFisicos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelFundoAzul = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblPrecoIndicado = new System.Windows.Forms.Label();
            this.lblCustoTotal = new System.Windows.Forms.Label();
            this.lblTituloPrecoIndicado = new System.Windows.Forms.Label();
            this.lblTituloCustoTotal = new System.Windows.Forms.Label();
            this.panelBarra.SuspendLayout();
            this.panelBorda.SuspendLayout();
            this.panelRecursosFisicos.SuspendLayout();
            this.panelCustosFixos.SuspendLayout();
            this.panelFatoresProducao.SuspendLayout();
            this.panelHomemHora.SuspendLayout();
            this.panelFundoAzul.SuspendLayout();
            this.SuspendLayout();
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
            this.panelBarra.TabIndex = 4;
            this.panelBarra.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarra_Paint);
            this.panelBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseMove);
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
            this.panelIcone.Location = new System.Drawing.Point(3, 0);
            this.panelIcone.Name = "panelIcone";
            this.panelIcone.Size = new System.Drawing.Size(46, 36);
            this.panelIcone.TabIndex = 4;
            // 
            // panelBorda
            // 
            this.panelBorda.BackColor = System.Drawing.Color.White;
            this.panelBorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorda.Controls.Add(this.panelTitulo);
            this.panelBorda.Controls.Add(this.panelRecursosFisicos);
            this.panelBorda.Controls.Add(this.panelCustosFixos);
            this.panelBorda.Controls.Add(this.panelFatoresProducao);
            this.panelBorda.Controls.Add(this.panelHomemHora);
            this.panelBorda.Controls.Add(this.lblHomemHora);
            this.panelBorda.Controls.Add(this.lblFatoresProducao);
            this.panelBorda.Controls.Add(this.lblCustosFixos);
            this.panelBorda.Controls.Add(this.lblRecursosFisicos);
            this.panelBorda.Controls.Add(this.lblTotal);
            this.panelBorda.Controls.Add(this.btnVoltar);
            this.panelBorda.Location = new System.Drawing.Point(0, 35);
            this.panelBorda.Name = "panelBorda";
            this.panelBorda.Size = new System.Drawing.Size(787, 415);
            this.panelBorda.TabIndex = 27;
            this.panelBorda.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBorda_Paint);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTitulo.BackgroundImage")));
            this.panelTitulo.Location = new System.Drawing.Point(22, 26);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(187, 25);
            this.panelTitulo.TabIndex = 39;
            // 
            // panelRecursosFisicos
            // 
            this.panelRecursosFisicos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRecursosFisicos.BackgroundImage")));
            this.panelRecursosFisicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelRecursosFisicos.Controls.Add(this.tbRecursosFisicos);
            this.panelRecursosFisicos.Location = new System.Drawing.Point(280, 135);
            this.panelRecursosFisicos.Name = "panelRecursosFisicos";
            this.panelRecursosFisicos.Size = new System.Drawing.Size(147, 24);
            this.panelRecursosFisicos.TabIndex = 30;
            // 
            // tbRecursosFisicos
            // 
            this.tbRecursosFisicos.BackColor = System.Drawing.Color.White;
            this.tbRecursosFisicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRecursosFisicos.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRecursosFisicos.Location = new System.Drawing.Point(13, 3);
            this.tbRecursosFisicos.Name = "tbRecursosFisicos";
            this.tbRecursosFisicos.ReadOnly = true;
            this.tbRecursosFisicos.Size = new System.Drawing.Size(122, 20);
            this.tbRecursosFisicos.TabIndex = 18;
            this.tbRecursosFisicos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelCustosFixos
            // 
            this.panelCustosFixos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCustosFixos.BackgroundImage")));
            this.panelCustosFixos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelCustosFixos.Controls.Add(this.tbCustosFixos);
            this.panelCustosFixos.Location = new System.Drawing.Point(280, 190);
            this.panelCustosFixos.Name = "panelCustosFixos";
            this.panelCustosFixos.Size = new System.Drawing.Size(147, 24);
            this.panelCustosFixos.TabIndex = 30;
            // 
            // tbCustosFixos
            // 
            this.tbCustosFixos.BackColor = System.Drawing.Color.White;
            this.tbCustosFixos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCustosFixos.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustosFixos.Location = new System.Drawing.Point(13, 3);
            this.tbCustosFixos.Name = "tbCustosFixos";
            this.tbCustosFixos.ReadOnly = true;
            this.tbCustosFixos.Size = new System.Drawing.Size(122, 20);
            this.tbCustosFixos.TabIndex = 18;
            this.tbCustosFixos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelFatoresProducao
            // 
            this.panelFatoresProducao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFatoresProducao.BackgroundImage")));
            this.panelFatoresProducao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelFatoresProducao.Controls.Add(this.tbFatoresProducao);
            this.panelFatoresProducao.Location = new System.Drawing.Point(280, 245);
            this.panelFatoresProducao.Name = "panelFatoresProducao";
            this.panelFatoresProducao.Size = new System.Drawing.Size(147, 24);
            this.panelFatoresProducao.TabIndex = 38;
            // 
            // tbFatoresProducao
            // 
            this.tbFatoresProducao.BackColor = System.Drawing.Color.White;
            this.tbFatoresProducao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFatoresProducao.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFatoresProducao.Location = new System.Drawing.Point(13, 3);
            this.tbFatoresProducao.Name = "tbFatoresProducao";
            this.tbFatoresProducao.ReadOnly = true;
            this.tbFatoresProducao.Size = new System.Drawing.Size(122, 20);
            this.tbFatoresProducao.TabIndex = 18;
            this.tbFatoresProducao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelHomemHora
            // 
            this.panelHomemHora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHomemHora.BackgroundImage")));
            this.panelHomemHora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelHomemHora.Controls.Add(this.tbHomemHora);
            this.panelHomemHora.Location = new System.Drawing.Point(280, 300);
            this.panelHomemHora.Name = "panelHomemHora";
            this.panelHomemHora.Size = new System.Drawing.Size(147, 24);
            this.panelHomemHora.TabIndex = 29;
            // 
            // tbHomemHora
            // 
            this.tbHomemHora.BackColor = System.Drawing.Color.White;
            this.tbHomemHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHomemHora.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHomemHora.Location = new System.Drawing.Point(13, 3);
            this.tbHomemHora.Name = "tbHomemHora";
            this.tbHomemHora.ReadOnly = true;
            this.tbHomemHora.Size = new System.Drawing.Size(122, 20);
            this.tbHomemHora.TabIndex = 18;
            this.tbHomemHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHomemHora
            // 
            this.lblHomemHora.AutoSize = true;
            this.lblHomemHora.BackColor = System.Drawing.Color.White;
            this.lblHomemHora.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomemHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblHomemHora.Location = new System.Drawing.Point(17, 297);
            this.lblHomemHora.Name = "lblHomemHora";
            this.lblHomemHora.Size = new System.Drawing.Size(257, 27);
            this.lblHomemHora.TabIndex = 37;
            this.lblHomemHora.Text = "Homem Hora Por Serviço";
            this.lblHomemHora.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFatoresProducao
            // 
            this.lblFatoresProducao.AutoSize = true;
            this.lblFatoresProducao.BackColor = System.Drawing.Color.White;
            this.lblFatoresProducao.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatoresProducao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblFatoresProducao.Location = new System.Drawing.Point(17, 242);
            this.lblFatoresProducao.Name = "lblFatoresProducao";
            this.lblFatoresProducao.Size = new System.Drawing.Size(210, 27);
            this.lblFatoresProducao.TabIndex = 35;
            this.lblFatoresProducao.Text = "Fatores de Produção";
            this.lblFatoresProducao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCustosFixos
            // 
            this.lblCustosFixos.AutoSize = true;
            this.lblCustosFixos.BackColor = System.Drawing.Color.White;
            this.lblCustosFixos.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustosFixos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblCustosFixos.Location = new System.Drawing.Point(17, 187);
            this.lblCustosFixos.Name = "lblCustosFixos";
            this.lblCustosFixos.Size = new System.Drawing.Size(129, 27);
            this.lblCustosFixos.TabIndex = 34;
            this.lblCustosFixos.Text = "Custos Fixos";
            this.lblCustosFixos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRecursosFisicos
            // 
            this.lblRecursosFisicos.AutoSize = true;
            this.lblRecursosFisicos.BackColor = System.Drawing.Color.White;
            this.lblRecursosFisicos.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecursosFisicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblRecursosFisicos.Location = new System.Drawing.Point(17, 132);
            this.lblRecursosFisicos.Name = "lblRecursosFisicos";
            this.lblRecursosFisicos.Size = new System.Drawing.Size(165, 27);
            this.lblRecursosFisicos.TabIndex = 33;
            this.lblRecursosFisicos.Text = "Recursos Físicos";
            this.lblRecursosFisicos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblTotal.Location = new System.Drawing.Point(318, 78);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 31);
            this.lblTotal.TabIndex = 32;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(11, 374);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVoltar.Size = new System.Drawing.Size(104, 23);
            this.btnVoltar.TabIndex = 31;
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panelFundoAzul
            // 
            this.panelFundoAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.panelFundoAzul.Controls.Add(this.btnSalvar);
            this.panelFundoAzul.Controls.Add(this.lblPrecoIndicado);
            this.panelFundoAzul.Controls.Add(this.lblCustoTotal);
            this.panelFundoAzul.Controls.Add(this.lblTituloPrecoIndicado);
            this.panelFundoAzul.Controls.Add(this.lblTituloCustoTotal);
            this.panelFundoAzul.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFundoAzul.Location = new System.Drawing.Point(444, 35);
            this.panelFundoAzul.Name = "panelFundoAzul";
            this.panelFundoAzul.Size = new System.Drawing.Size(342, 414);
            this.panelFundoAzul.TabIndex = 28;
            this.panelFundoAzul.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFundoAzul_Paint);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.btnSalvar.Location = new System.Drawing.Point(212, 369);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 34);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblPrecoIndicado
            // 
            this.lblPrecoIndicado.AutoSize = true;
            this.lblPrecoIndicado.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoIndicado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(225)))));
            this.lblPrecoIndicado.Location = new System.Drawing.Point(97, 256);
            this.lblPrecoIndicado.Name = "lblPrecoIndicado";
            this.lblPrecoIndicado.Size = new System.Drawing.Size(156, 42);
            this.lblPrecoIndicado.TabIndex = 20;
            this.lblPrecoIndicado.Text = "25.00,00";
            // 
            // lblCustoTotal
            // 
            this.lblCustoTotal.AutoSize = true;
            this.lblCustoTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(225)))));
            this.lblCustoTotal.Location = new System.Drawing.Point(97, 110);
            this.lblCustoTotal.Name = "lblCustoTotal";
            this.lblCustoTotal.Size = new System.Drawing.Size(156, 42);
            this.lblCustoTotal.TabIndex = 19;
            this.lblCustoTotal.Text = "20.00,00";
            // 
            // lblTituloPrecoIndicado
            // 
            this.lblTituloPrecoIndicado.AutoSize = true;
            this.lblTituloPrecoIndicado.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrecoIndicado.ForeColor = System.Drawing.Color.White;
            this.lblTituloPrecoIndicado.Location = new System.Drawing.Point(21, 214);
            this.lblTituloPrecoIndicado.Name = "lblTituloPrecoIndicado";
            this.lblTituloPrecoIndicado.Size = new System.Drawing.Size(308, 42);
            this.lblTituloPrecoIndicado.TabIndex = 18;
            this.lblTituloPrecoIndicado.Text = "PREÇO INDICADO";
            this.lblTituloPrecoIndicado.Click += new System.EventHandler(this.lblTituloPrecoIndicado_Click);
            // 
            // lblTituloCustoTotal
            // 
            this.lblTituloCustoTotal.AutoSize = true;
            this.lblTituloCustoTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCustoTotal.ForeColor = System.Drawing.Color.White;
            this.lblTituloCustoTotal.Location = new System.Drawing.Point(54, 68);
            this.lblTituloCustoTotal.Name = "lblTituloCustoTotal";
            this.lblTituloCustoTotal.Size = new System.Drawing.Size(248, 42);
            this.lblTituloCustoTotal.TabIndex = 17;
            this.lblTituloCustoTotal.Text = "CUSTO TOTAL";
            // 
            // frmTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.panelFundoAzul);
            this.Controls.Add(this.panelBorda);
            this.Controls.Add(this.panelBarra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTabela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftPrice";
            this.Load += new System.EventHandler(this.frmTabela_Load);
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.panelBorda.ResumeLayout(false);
            this.panelBorda.PerformLayout();
            this.panelRecursosFisicos.ResumeLayout(false);
            this.panelRecursosFisicos.PerformLayout();
            this.panelCustosFixos.ResumeLayout(false);
            this.panelCustosFixos.PerformLayout();
            this.panelFatoresProducao.ResumeLayout(false);
            this.panelFatoresProducao.PerformLayout();
            this.panelHomemHora.ResumeLayout(false);
            this.panelHomemHora.PerformLayout();
            this.panelFundoAzul.ResumeLayout(false);
            this.panelFundoAzul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Label lblTituloPrograma;
        private System.Windows.Forms.Panel panelIcone;
        private System.Windows.Forms.Panel panelBorda;
        private System.Windows.Forms.Panel panelFundoAzul;
        private System.Windows.Forms.Label lblCustoTotal;
        private System.Windows.Forms.Label lblTituloPrecoIndicado;
        private System.Windows.Forms.Label lblTituloCustoTotal;
        private System.Windows.Forms.Label lblPrecoIndicado;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblHomemHora;
        private System.Windows.Forms.Label lblFatoresProducao;
        private System.Windows.Forms.Label lblCustosFixos;
        private System.Windows.Forms.Label lblRecursosFisicos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panelHomemHora;
        private System.Windows.Forms.TextBox tbHomemHora;
        private System.Windows.Forms.Panel panelRecursosFisicos;
        private System.Windows.Forms.TextBox tbRecursosFisicos;
        private System.Windows.Forms.Panel panelCustosFixos;
        private System.Windows.Forms.TextBox tbCustosFixos;
        private System.Windows.Forms.Panel panelFatoresProducao;
        private System.Windows.Forms.TextBox tbFatoresProducao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panelTitulo;
    }
}