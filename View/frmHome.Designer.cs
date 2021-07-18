namespace softPrice
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.lblTituloPrograma = new System.Windows.Forms.Label();
            this.panelIcone = new System.Windows.Forms.Panel();
            this.panelFundoAzul = new System.Windows.Forms.Panel();
            this.btnAdicionarProjeto = new System.Windows.Forms.Button();
            this.dgvProjetos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.panelBorda = new System.Windows.Forms.Panel();
            this.panelBarra.SuspendLayout();
            this.panelFundoAzul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjetos)).BeginInit();
            this.panelBorda.SuspendLayout();
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
            this.panelBarra.TabIndex = 3;
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
            // panelFundoAzul
            // 
            this.panelFundoAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.panelFundoAzul.Controls.Add(this.btnAdicionarProjeto);
            this.panelFundoAzul.Controls.Add(this.dgvProjetos);
            this.panelFundoAzul.Controls.Add(this.lblTitulo);
            this.panelFundoAzul.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFundoAzul.Location = new System.Drawing.Point(1, 90);
            this.panelFundoAzul.Name = "panelFundoAzul";
            this.panelFundoAzul.Size = new System.Drawing.Size(785, 359);
            this.panelFundoAzul.TabIndex = 4;
            // 
            // btnAdicionarProjeto
            // 
            this.btnAdicionarProjeto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionarProjeto.BackgroundImage")));
            this.btnAdicionarProjeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionarProjeto.FlatAppearance.BorderSize = 0;
            this.btnAdicionarProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProjeto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.btnAdicionarProjeto.Location = new System.Drawing.Point(203, 18);
            this.btnAdicionarProjeto.Name = "btnAdicionarProjeto";
            this.btnAdicionarProjeto.Size = new System.Drawing.Size(42, 42);
            this.btnAdicionarProjeto.TabIndex = 17;
            this.btnAdicionarProjeto.UseVisualStyleBackColor = true;
            this.btnAdicionarProjeto.Click += new System.EventHandler(this.btnAdicionarProjeto_Click);
            // 
            // dgvProjetos
            // 
            this.dgvProjetos.AllowUserToAddRows = false;
            this.dgvProjetos.AllowUserToDeleteRows = false;
            this.dgvProjetos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.dgvProjetos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProjetos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjetos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Entrar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjetos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProjetos.EnableHeadersVisualStyles = false;
            this.dgvProjetos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.dgvProjetos.Location = new System.Drawing.Point(35, 78);
            this.dgvProjetos.Name = "dgvProjetos";
            this.dgvProjetos.ReadOnly = true;
            this.dgvProjetos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjetos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProjetos.RowHeadersVisible = false;
            this.dgvProjetos.RowTemplate.DividerHeight = 10;
            this.dgvProjetos.RowTemplate.Height = 35;
            this.dgvProjetos.RowTemplate.ReadOnly = true;
            this.dgvProjetos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjetos.Size = new System.Drawing.Size(735, 265);
            this.dgvProjetos.TabIndex = 16;
            this.dgvProjetos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjetos_CellClick_1);
            this.dgvProjetos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjetos_CellContentClick);
            // 
            // Nome
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nome.DividerWidth = 50;
            this.Nome.HeaderText = "";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nome.Width = 580;
            // 
            // Entrar
            // 
            this.Entrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.Entrar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entrar.HeaderText = "";
            this.Entrar.Name = "Entrar";
            this.Entrar.ReadOnly = true;
            this.Entrar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Entrar.Text = "Entrar";
            this.Entrar.ToolTipText = "Exibir detalhes da tabela";
            this.Entrar.UseColumnTextForButtonValue = true;
            this.Entrar.Width = 130;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 42);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "PROJETOS";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.BackColor = System.Drawing.Color.White;
            this.lblBoasVindas.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.lblBoasVindas.Location = new System.Drawing.Point(12, 48);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(0, 31);
            this.lblBoasVindas.TabIndex = 14;
            this.lblBoasVindas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBoasVindas.Click += new System.EventHandler(this.lblBoasVindas_Click);
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.BackColor = System.Drawing.Color.White;
            this.lblSair.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(173)))));
            this.lblSair.Location = new System.Drawing.Point(703, 12);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(71, 31);
            this.lblSair.TabIndex = 15;
            this.lblSair.Text = "SAIR";
            this.lblSair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            this.lblSair.MouseEnter += new System.EventHandler(this.lblSair_MouseEnter);
            this.lblSair.MouseLeave += new System.EventHandler(this.lblSair_MouseLeave);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.BackColor = System.Drawing.Color.White;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(184)))), ((int)(((byte)(173)))));
            this.lblPerfil.Location = new System.Drawing.Point(602, 12);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(95, 31);
            this.lblPerfil.TabIndex = 16;
            this.lblPerfil.Text = "PERFIL";
            this.lblPerfil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPerfil.Click += new System.EventHandler(this.lblPerfil_Click);
            this.lblPerfil.MouseEnter += new System.EventHandler(this.lblPerfil_MouseEnter);
            this.lblPerfil.MouseLeave += new System.EventHandler(this.lblPerfil_MouseLeave);
            // 
            // panelBorda
            // 
            this.panelBorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorda.Controls.Add(this.lblSair);
            this.panelBorda.Controls.Add(this.lblPerfil);
            this.panelBorda.Location = new System.Drawing.Point(0, 35);
            this.panelBorda.Name = "panelBorda";
            this.panelBorda.Size = new System.Drawing.Size(787, 415);
            this.panelBorda.TabIndex = 26;
            this.panelBorda.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBorda_Paint);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.lblBoasVindas);
            this.Controls.Add(this.panelFundoAzul);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.panelBorda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftPrice";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.panelFundoAzul.ResumeLayout(false);
            this.panelFundoAzul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjetos)).EndInit();
            this.panelBorda.ResumeLayout(false);
            this.panelBorda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel panelIcone;
        private System.Windows.Forms.Panel panelFundoAzul;
        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Panel panelBorda;
        private System.Windows.Forms.Label lblTituloPrograma;
        private System.Windows.Forms.DataGridView dgvProjetos;
        private System.Windows.Forms.Button btnAdicionarProjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewButtonColumn Entrar;
    }
}