namespace FrmMain
{
    partial class FrmEarningStatistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BASLANGİCTrh = new System.Windows.Forms.DateTimePicker();
            this.BitisTrh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toplamGelirLbl = new System.Windows.Forms.Label();
            this.sclnAyGelirLbl = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "BAŞLANGIÇ  TARİHİ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "BİTİŞ TARİHİ:";
            // 
            // BASLANGİCTrh
            // 
            this.BASLANGİCTrh.Location = new System.Drawing.Point(197, 50);
            this.BASLANGİCTrh.Name = "BASLANGİCTrh";
            this.BASLANGİCTrh.Size = new System.Drawing.Size(200, 22);
            this.BASLANGİCTrh.TabIndex = 2;
            // 
            // BitisTrh
            // 
            this.BitisTrh.Location = new System.Drawing.Point(197, 94);
            this.BitisTrh.Name = "BitisTrh";
            this.BitisTrh.Size = new System.Drawing.Size(200, 22);
            this.BitisTrh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "TOPLAM GELİR=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "SEÇİLEN AY TUTAR GELİRİ=";
            // 
            // toplamGelirLbl
            // 
            this.toplamGelirLbl.AutoSize = true;
            this.toplamGelirLbl.Location = new System.Drawing.Point(739, 50);
            this.toplamGelirLbl.Name = "toplamGelirLbl";
            this.toplamGelirLbl.Size = new System.Drawing.Size(0, 17);
            this.toplamGelirLbl.TabIndex = 6;
            // 
            // sclnAyGelirLbl
            // 
            this.sclnAyGelirLbl.AutoSize = true;
            this.sclnAyGelirLbl.Location = new System.Drawing.Point(739, 94);
            this.sclnAyGelirLbl.Name = "sclnAyGelirLbl";
            this.sclnAyGelirLbl.Size = new System.Drawing.Size(0, 17);
            this.sclnAyGelirLbl.TabIndex = 7;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(115, 138);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "GELIR";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(777, 300);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(881, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Grafik Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEarningStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.sclnAyGelirLbl);
            this.Controls.Add(this.toplamGelirLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BitisTrh);
            this.Controls.Add(this.BASLANGİCTrh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEarningStatistics";
            this.Text = "Gelir İstatistikleri";
            this.Load += new System.EventHandler(this.FrmEarningStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BASLANGİCTrh;
        private System.Windows.Forms.DateTimePicker BitisTrh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label toplamGelirLbl;
        private System.Windows.Forms.Label sclnAyGelirLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}