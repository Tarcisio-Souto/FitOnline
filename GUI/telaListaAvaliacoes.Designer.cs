namespace GUI
{
    partial class telaListaAvaliacoes
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
            this.dgvCadastro = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAbrirSelecao = new System.Windows.Forms.Button();
            this.dgvLstAvaliacoes = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNovaAvaliacao = new System.Windows.Forms.Button();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstAvaliacoes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.AllowUserToAddRows = false;
            this.dgvCadastro.AllowUserToDeleteRows = false;
            this.dgvCadastro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastro.Location = new System.Drawing.Point(35, 32);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.ReadOnly = true;
            this.dgvCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadastro.Size = new System.Drawing.Size(350, 44);
            this.dgvCadastro.TabIndex = 0;
            this.dgvCadastro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastro_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Location = new System.Drawing.Point(463, 17);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Fechar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAbrirSelecao
            // 
            this.btnAbrirSelecao.BackColor = System.Drawing.SystemColors.Window;
            this.btnAbrirSelecao.Location = new System.Drawing.Point(146, 17);
            this.btnAbrirSelecao.Name = "btnAbrirSelecao";
            this.btnAbrirSelecao.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirSelecao.TabIndex = 4;
            this.btnAbrirSelecao.Text = "Abrir";
            this.btnAbrirSelecao.UseVisualStyleBackColor = false;
            this.btnAbrirSelecao.Click += new System.EventHandler(this.btnAbrirSelecao_Click);
            // 
            // dgvLstAvaliacoes
            // 
            this.dgvLstAvaliacoes.AllowUserToAddRows = false;
            this.dgvLstAvaliacoes.AllowUserToDeleteRows = false;
            this.dgvLstAvaliacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvLstAvaliacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLstAvaliacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvLstAvaliacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLstAvaliacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLstAvaliacoes.Location = new System.Drawing.Point(32, 31);
            this.dgvLstAvaliacoes.Name = "dgvLstAvaliacoes";
            this.dgvLstAvaliacoes.ReadOnly = true;
            this.dgvLstAvaliacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLstAvaliacoes.Size = new System.Drawing.Size(353, 166);
            this.dgvLstAvaliacoes.TabIndex = 5;
            this.dgvLstAvaliacoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLstAvaliacoes_CellClick_1);
            this.dgvLstAvaliacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLstAvaliacoes_CellContentClick_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.Location = new System.Drawing.Point(359, 17);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLstAvaliacoes);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(149, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 219);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avaliações";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCadastro);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(149, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro";
            // 
            // btnNovaAvaliacao
            // 
            this.btnNovaAvaliacao.BackColor = System.Drawing.SystemColors.Window;
            this.btnNovaAvaliacao.Location = new System.Drawing.Point(22, 17);
            this.btnNovaAvaliacao.Name = "btnNovaAvaliacao";
            this.btnNovaAvaliacao.Size = new System.Drawing.Size(94, 23);
            this.btnNovaAvaliacao.TabIndex = 35;
            this.btnNovaAvaliacao.Text = "Nova Avaliação";
            this.btnNovaAvaliacao.UseVisualStyleBackColor = false;
            this.btnNovaAvaliacao.Click += new System.EventHandler(this.txtNovaAvaliacao_Click);
            // 
            // btnGraficos
            // 
            this.btnGraficos.BackColor = System.Drawing.SystemColors.Window;
            this.btnGraficos.Location = new System.Drawing.Point(253, 17);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(75, 23);
            this.btnGraficos.TabIndex = 36;
            this.btnGraficos.Text = "Gráficos";
            this.btnGraficos.UseVisualStyleBackColor = false;
            this.btnGraficos.Click += new System.EventHandler(this.btnGraficos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnGraficos);
            this.panel1.Controls.Add(this.btnNovaAvaliacao);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAbrirSelecao);
            this.panel1.Location = new System.Drawing.Point(80, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 59);
            this.panel1.TabIndex = 37;
            // 
            // telaListaAvaliacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(729, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "telaListaAvaliacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Avaliações e Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.telaListaAvaliacoes_FormClosed);
            this.Load += new System.EventHandler(this.telaListaAvaliacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLstAvaliacoes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        public System.Windows.Forms.DataGridView dgvCadastro;
        private System.Windows.Forms.Button btnAbrirSelecao;
        public System.Windows.Forms.DataGridView dgvLstAvaliacoes;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNovaAvaliacao;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.Panel panel1;
    }
}