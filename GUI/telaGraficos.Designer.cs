namespace GUI
{
    partial class telaGraficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graficoRCQ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.graficoPesoCorporal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoFlexaoBraco = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoForcaAbdominal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoVO2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoMassaMagra = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoPercGordura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAjuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graficoRCQ)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoPesoCorporal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoFlexaoBraco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoForcaAbdominal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoVO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoMassaMagra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoPercGordura)).BeginInit();
            this.SuspendLayout();
            // 
            // graficoRCQ
            // 
            this.graficoRCQ.BackColor = System.Drawing.Color.MediumAquamarine;
            this.graficoRCQ.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.graficoRCQ.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoRCQ.Legends.Add(legend1);
            this.graficoRCQ.Location = new System.Drawing.Point(19, 22);
            this.graficoRCQ.Name = "graficoRCQ";
            this.graficoRCQ.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Índice de RCQ";
            this.graficoRCQ.Series.Add(series1);
            this.graficoRCQ.Size = new System.Drawing.Size(375, 208);
            this.graficoRCQ.TabIndex = 0;
            this.graficoRCQ.Text = "chart1";
            this.graficoRCQ.Click += new System.EventHandler(this.graficoRCQ_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1203, 740);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.btnAjuda);
            this.tabPage1.Controls.Add(this.btnVoltar);
            this.tabPage1.Controls.Add(this.graficoPesoCorporal);
            this.tabPage1.Controls.Add(this.graficoFlexaoBraco);
            this.tabPage1.Controls.Add(this.graficoForcaAbdominal);
            this.tabPage1.Controls.Add(this.graficoVO2);
            this.tabPage1.Controls.Add(this.graficoMassaMagra);
            this.tabPage1.Controls.Add(this.graficoPercGordura);
            this.tabPage1.Controls.Add(this.graficoRCQ);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1195, 708);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gráficos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(1068, 623);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // graficoPesoCorporal
            // 
            this.graficoPesoCorporal.BackColor = System.Drawing.Color.MediumAquamarine;
            chartArea2.Name = "ChartArea1";
            this.graficoPesoCorporal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graficoPesoCorporal.Legends.Add(legend2);
            this.graficoPesoCorporal.Location = new System.Drawing.Point(19, 478);
            this.graficoPesoCorporal.Name = "graficoPesoCorporal";
            this.graficoPesoCorporal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Peso Corporal";
            this.graficoPesoCorporal.Series.Add(series2);
            this.graficoPesoCorporal.Size = new System.Drawing.Size(375, 208);
            this.graficoPesoCorporal.TabIndex = 6;
            this.graficoPesoCorporal.Text = "chart1";
            // 
            // graficoFlexaoBraco
            // 
            this.graficoFlexaoBraco.BackColor = System.Drawing.Color.MediumAquamarine;
            chartArea3.Name = "ChartArea1";
            this.graficoFlexaoBraco.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graficoFlexaoBraco.Legends.Add(legend3);
            this.graficoFlexaoBraco.Location = new System.Drawing.Point(808, 250);
            this.graficoFlexaoBraco.Name = "graficoFlexaoBraco";
            this.graficoFlexaoBraco.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Flexão de Braço";
            this.graficoFlexaoBraco.Series.Add(series3);
            this.graficoFlexaoBraco.Size = new System.Drawing.Size(368, 208);
            this.graficoFlexaoBraco.TabIndex = 5;
            this.graficoFlexaoBraco.Text = "chart1";
            // 
            // graficoForcaAbdominal
            // 
            this.graficoForcaAbdominal.BackColor = System.Drawing.Color.MediumAquamarine;
            chartArea4.Name = "ChartArea1";
            this.graficoForcaAbdominal.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.graficoForcaAbdominal.Legends.Add(legend4);
            this.graficoForcaAbdominal.Location = new System.Drawing.Point(422, 250);
            this.graficoForcaAbdominal.Name = "graficoForcaAbdominal";
            this.graficoForcaAbdominal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Índice de Força Abdominal";
            this.graficoForcaAbdominal.Series.Add(series4);
            this.graficoForcaAbdominal.Size = new System.Drawing.Size(355, 208);
            this.graficoForcaAbdominal.TabIndex = 4;
            this.graficoForcaAbdominal.Text = "chart1";
            // 
            // graficoVO2
            // 
            this.graficoVO2.BackColor = System.Drawing.Color.MediumAquamarine;
            chartArea5.Name = "ChartArea1";
            this.graficoVO2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.graficoVO2.Legends.Add(legend5);
            this.graficoVO2.Location = new System.Drawing.Point(19, 250);
            this.graficoVO2.Name = "graficoVO2";
            this.graficoVO2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Índice de VO2";
            this.graficoVO2.Series.Add(series5);
            this.graficoVO2.Size = new System.Drawing.Size(375, 208);
            this.graficoVO2.TabIndex = 3;
            this.graficoVO2.Text = "chart1";
            // 
            // graficoMassaMagra
            // 
            this.graficoMassaMagra.BackColor = System.Drawing.Color.MediumAquamarine;
            chartArea6.Name = "ChartArea1";
            this.graficoMassaMagra.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.graficoMassaMagra.Legends.Add(legend6);
            this.graficoMassaMagra.Location = new System.Drawing.Point(808, 22);
            this.graficoMassaMagra.Name = "graficoMassaMagra";
            this.graficoMassaMagra.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Índice de Massa Magra";
            this.graficoMassaMagra.Series.Add(series6);
            this.graficoMassaMagra.Size = new System.Drawing.Size(368, 208);
            this.graficoMassaMagra.TabIndex = 2;
            this.graficoMassaMagra.Text = "chart1";
            // 
            // graficoPercGordura
            // 
            this.graficoPercGordura.BackColor = System.Drawing.Color.MediumAquamarine;
            chartArea7.Name = "ChartArea1";
            this.graficoPercGordura.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.graficoPercGordura.Legends.Add(legend7);
            this.graficoPercGordura.Location = new System.Drawing.Point(422, 22);
            this.graficoPercGordura.Name = "graficoPercGordura";
            this.graficoPercGordura.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Índice de %G";
            this.graficoPercGordura.Series.Add(series7);
            this.graficoPercGordura.Size = new System.Drawing.Size(355, 208);
            this.graficoPercGordura.TabIndex = 1;
            this.graficoPercGordura.Text = "chart1";
            // 
            // btnAjuda
            // 
            this.btnAjuda.Location = new System.Drawing.Point(1068, 578);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(75, 23);
            this.btnAjuda.TabIndex = 8;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // telaGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 741);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "telaGraficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaGraficos";
            ((System.ComponentModel.ISupportInitialize)(this.graficoRCQ)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graficoPesoCorporal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoFlexaoBraco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoForcaAbdominal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoVO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoMassaMagra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoPercGordura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart graficoRCQ;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataVisualization.Charting.Chart graficoPercGordura;
        public System.Windows.Forms.DataVisualization.Charting.Chart graficoMassaMagra;
        public System.Windows.Forms.DataVisualization.Charting.Chart graficoVO2;
        public System.Windows.Forms.DataVisualization.Charting.Chart graficoForcaAbdominal;
        public System.Windows.Forms.DataVisualization.Charting.Chart graficoFlexaoBraco;
        public System.Windows.Forms.DataVisualization.Charting.Chart graficoPesoCorporal;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAjuda;

    }
}