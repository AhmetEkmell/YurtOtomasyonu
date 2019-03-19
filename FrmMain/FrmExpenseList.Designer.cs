namespace FrmMain
{
    partial class FrmExpenseList
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewExpenseList = new System.Windows.Forms.DataGridView();
            this.giderOdemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSetExpenseList = new FrmMain.YurtOtomasyonuDataSetExpenseList();
            this.giderOdemeTableAdapter = new FrmMain.YurtOtomasyonuDataSetExpenseListTableAdapters.GiderOdemeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderOdemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSetExpenseList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExpenseList
            // 
            this.dataGridViewExpenseList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewExpenseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExpenseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpenseList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewExpenseList.Name = "dataGridViewExpenseList";
            this.dataGridViewExpenseList.RowTemplate.Height = 24;
            this.dataGridViewExpenseList.Size = new System.Drawing.Size(788, 449);
            this.dataGridViewExpenseList.TabIndex = 0;
            // 
            // giderOdemeBindingSource
            // 
            this.giderOdemeBindingSource.DataMember = "GiderOdeme";
            this.giderOdemeBindingSource.DataSource = this.yurtOtomasyonuDataSetExpenseList;
            // 
            // yurtOtomasyonuDataSetExpenseList
            // 
            this.yurtOtomasyonuDataSetExpenseList.DataSetName = "YurtOtomasyonuDataSetExpenseList";
            this.yurtOtomasyonuDataSetExpenseList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderOdemeTableAdapter
            // 
            this.giderOdemeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmExpenseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewExpenseList);
            this.Name = "FrmExpenseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Listesi";
            this.Load += new System.EventHandler(this.FrmExpenseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderOdemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSetExpenseList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExpenseList;
        private System.Windows.Forms.BindingSource giderOdemeBindingSource;
        private FrmMain.YurtOtomasyonuDataSetExpenseList yurtOtomasyonuDataSetExpenseList;
        private FrmMain.YurtOtomasyonuDataSetExpenseListTableAdapters.GiderOdemeTableAdapter giderOdemeTableAdapter;
    }
}