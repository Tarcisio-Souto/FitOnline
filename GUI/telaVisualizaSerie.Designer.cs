namespace GUI
{
    partial class telaVisualizaSerie
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
            this.panel12 = new System.Windows.Forms.Panel();
            this.textoSerie = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdSerie = new System.Windows.Forms.TextBox();
            this.txtMatriculaSerie = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdAluno = new System.Windows.Forms.Label();
            this.txtIdAvaliacaoSerie = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.textoSerie);
            this.panel12.Controls.Add(this.label14);
            this.panel12.Font = new System.Drawing.Font("Arial", 9.75F);
            this.panel12.Location = new System.Drawing.Point(510, 49);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(388, 180);
            this.panel12.TabIndex = 14;
            // 
            // textoSerie
            // 
            this.textoSerie.Location = new System.Drawing.Point(115, 21);
            this.textoSerie.Name = "textoSerie";
            this.textoSerie.Size = new System.Drawing.Size(235, 140);
            this.textoSerie.TabIndex = 8;
            this.textoSerie.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label14.Location = new System.Drawing.Point(27, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "Série:";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.label12);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Controls.Add(this.txtIdSerie);
            this.panel11.Controls.Add(this.txtMatriculaSerie);
            this.panel11.Controls.Add(this.label13);
            this.panel11.Controls.Add(this.txtIdAluno);
            this.panel11.Controls.Add(this.txtIdAvaliacaoSerie);
            this.panel11.Location = new System.Drawing.Point(87, 49);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(389, 180);
            this.panel11.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label12.Location = new System.Drawing.Point(50, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nº Série:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 0;
            // 
            // txtIdSerie
            // 
            this.txtIdSerie.Enabled = false;
            this.txtIdSerie.Location = new System.Drawing.Point(155, 30);
            this.txtIdSerie.Name = "txtIdSerie";
            this.txtIdSerie.Size = new System.Drawing.Size(156, 20);
            this.txtIdSerie.TabIndex = 2;
            // 
            // txtMatriculaSerie
            // 
            this.txtMatriculaSerie.Enabled = false;
            this.txtMatriculaSerie.Location = new System.Drawing.Point(155, 119);
            this.txtMatriculaSerie.Name = "txtMatriculaSerie";
            this.txtMatriculaSerie.Size = new System.Drawing.Size(156, 20);
            this.txtMatriculaSerie.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label13.Location = new System.Drawing.Point(50, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Cod. Avaliação:";
            // 
            // txtIdAluno
            // 
            this.txtIdAluno.AutoSize = true;
            this.txtIdAluno.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtIdAluno.Location = new System.Drawing.Point(50, 126);
            this.txtIdAluno.Name = "txtIdAluno";
            this.txtIdAluno.Size = new System.Drawing.Size(65, 16);
            this.txtIdAluno.TabIndex = 5;
            this.txtIdAluno.Text = "Matrícula:";
            // 
            // txtIdAvaliacaoSerie
            // 
            this.txtIdAvaliacaoSerie.Enabled = false;
            this.txtIdAvaliacaoSerie.Location = new System.Drawing.Point(155, 72);
            this.txtIdAvaliacaoSerie.Name = "txtIdAvaliacaoSerie";
            this.txtIdAvaliacaoSerie.Size = new System.Drawing.Size(156, 20);
            this.txtIdAvaliacaoSerie.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Location = new System.Drawing.Point(542, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 39);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(130, 6);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(94, 23);
            this.btnAlterar.TabIndex = 31;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(242, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Sair";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(15, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 23);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // telaVisualizaSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Name = "telaVisualizaSerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaVisualizaSerie";
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        public System.Windows.Forms.RichTextBox textoSerie;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtIdSerie;
        public System.Windows.Forms.TextBox txtMatriculaSerie;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label txtIdAluno;
        public System.Windows.Forms.TextBox txtIdAvaliacaoSerie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
    }
}