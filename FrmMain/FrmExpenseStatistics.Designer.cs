namespace FrmMain
{
    partial class FrmExpenseStatistics
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
            this.button1 = new System.Windows.Forms.Button();
            this.sclnAyGiderLbl = new System.Windows.Forms.Label();
            this.toplamGiderlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BitisTrh = new System.Windows.Forms.DateTimePicker();
            this.BASLANGİCTrh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(854, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "Grafik Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sclnAyGiderLbl
            // 
            this.sclnAyGiderLbl.AutoSize = true;
            this.sclnAyGiderLbl.Location = new System.Drawing.Point(712, 95);
            this.sclnAyGiderLbl.Name = "sclnAyGiderLbl";
            this.sclnAyGiderLbl.Size = new System.Drawing.Size(0, 17);
            this.sclnAyGiderLbl.TabIndex = 17;
            // 
            // toplamGiderlbl
            // 
            this.toplamGiderlbl.AutoSize = true;
            this.toplamGiderlbl.Location = new System.Drawing.Point(712, 51);
            this.toplamGiderlbl.Name = "toplamGiderlbl";
            this.toplamGiderlbl.Size = new System.Drawing.Size(0, 17);
            this.toplamGiderlbl.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "SEÇİLEN AY GİDER=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "TOPLAM GİDER=";
            // 
            // BitisTrh
            // 
            this.BitisTrh.Location = new System.Drawing.Point(170, 95);
            this.BitisTrh.Name = "BitisTrh";
            this.BitisTrh.Size = new System.Drawing.Size(200, 22);
            this.BitisTrh.TabIndex = 13;
            // 
            // BASLANGİCTrh
            // 
            this.BASLANGİCTrh.Location = new System.Drawing.Point(170, 51);
            this.BASLANGİCTrh.Name = "BASLANGİCTrh";
            this.BASLANGİCTrh.Size = new System.Drawing.Size(200, 22);
            this.BASLANGİCTrh.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "BİTİŞ TARİHİ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "BAŞLANGIÇ  TARİHİ:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(74, 138);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "GIDER";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(761, 300);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // FrmExpenseStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sclnAyGiderLbl);
            this.Controls.Add(this.toplamGiderlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BitisTrh);
            this.Controls.Add(this.BASLANGİCTrh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmExpenseStatistics";
            this.Text = "Gider İstatistikleri";
            this.Load += new System.EventHandler(this.FrmExpenseStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sclnAyGiderLbl;
        private System.Windows.Forms.Label toplamGiderlbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker BitisTrh;
        private System.Windows.Forms.DateTimePicker BASLANGİCTrh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}