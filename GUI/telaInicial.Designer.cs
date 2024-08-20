namespace GUI
{
    partial class telaInicial
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
            this.btnNovoAluno = new System.Windows.Forms.Button();
            this.btnPesquisarAluno = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovoAluno
            // 
            this.btnNovoAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoAluno.Location = new System.Drawing.Point(14, 14);
            this.btnNovoAluno.Name = "btnNovoAluno";
            this.btnNovoAluno.Size = new System.Drawing.Size(104, 23);
            this.btnNovoAluno.TabIndex = 0;
            this.btnNovoAluno.Text = "Novo Aluno";
            this.btnNovoAluno.UseVisualStyleBackColor = true;
            this.btnNovoAluno.Click += new System.EventHandler(this.btnNovoAluno_Click);
            // 
            // btnPesquisarAluno
            // 
            this.btnPesquisarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarAluno.Location = new System.Drawing.Point(319, 14);
            this.btnPesquisarAluno.Name = "btnPesquisarAluno";
            this.btnPesquisarAluno.Size = new System.Drawing.Size(104, 23);
            this.btnPesquisarAluno.TabIndex = 1;
            this.btnPesquisarAluno.Text = "Pesquisar Aluno";
            this.btnPesquisarAluno.UseVisualStyleBackColor = true;
            this.btnPesquisarAluno.Click += new System.EventHandler(this.btnPesquisarAluno_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnPesquisarAluno);
            this.panel1.Controls.Add(this.btnNovoAluno);
            this.panel1.Location = new System.Drawing.Point(72, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 55);
            this.panel1.TabIndex = 2;
            // 
            // telaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel1);
            this.Name = "telaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                            FitOnline";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaInicial_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.telaInicial_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoAluno;
        public System.Windows.Forms.Button btnPesquisarAluno;
        private System.Windows.Forms.Panel panel1;
    }
}

