namespace FrmMain
{
    partial class FrmDepartmentActions
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
            this.picBoxAdd = new System.Windows.Forms.PictureBox();
            this.dataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSeti = new YurtOtomasyonuDataSeti();
            this.picBoxEdit = new System.Windows.Forms.PictureBox();
            this.picBoxDelete = new System.Windows.Forms.PictureBox();
            this.tBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bolumTableAdapter = new YurtOtomasyonuDataSetiTableAdapters.BolumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxAdd
            // 
            this.picBoxAdd.Image = global::FrmMain.Properties.Resources.add;
            this.picBoxAdd.Location = new System.Drawing.Point(422, 37);
            this.picBoxAdd.Name = "picBoxAdd";
            this.picBoxAdd.Size = new System.Drawing.Size(75, 75);
            this.picBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAdd.TabIndex = 2;
            this.picBoxAdd.TabStop = false;
            this.picBoxAdd.Click += new System.EventHandler(this.picBoxAdd_Click);
            // 
            // dataGridViewDepartment
            // 
            this.dataGridViewDepartment.AutoGenerateColumns = false;
            this.dataGridViewDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn});
            this.dataGridViewDepartment.DataSource = this.bolumBindingSource;
            this.dataGridViewDepartment.Location = new System.Drawing.Point(27, 146);
            this.dataGridViewDepartment.Name = "dataGridViewDepartment";
            this.dataGridViewDepartment.RowTemplate.Height = 24;
            this.dataGridViewDepartment.Size = new System.Drawing.Size(698, 401);
            this.dataGridViewDepartment.TabIndex = 3;
            this.dataGridViewDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartment_CellClick);
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // bolumBindingSource
            // 
            this.bolumBindingSource.DataMember = "Bolum";
            this.bolumBindingSource.DataSource = this.yurtOtomasyonuDataSeti;
            // 
            // yurtOtomasyonuDataSeti
            // 
            this.yurtOtomasyonuDataSeti.DataSetName = "YurtOtomasyonuDataSeti";
            this.yurtOtomasyonuDataSeti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // picBoxEdit
            // 
            this.picBoxEdit.Image = global::FrmMain.Properties.Resources.edit;
            this.picBoxEdit.Location = new System.Drawing.Point(541, 37);
            this.picBoxEdit.Name = "picBoxEdit";
            this.picBoxEdit.Size = new System.Drawing.Size(75, 75);
            this.picBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxEdit.TabIndex = 4;
            this.picBoxEdit.TabStop = false;
            this.picBoxEdit.Click += new System.EventHandler(this.picBoxEdit_Click);
            // 
            // picBoxDelete
            // 
            this.picBoxDelete.Image = global::FrmMain.Properties.Resources.delete;
            this.picBoxDelete.Location = new System.Drawing.Point(650, 37);
            this.picBoxDelete.Name = "picBoxDelete";
            this.picBoxDelete.Size = new System.Drawing.Size(75, 75);
            this.picBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDelete.TabIndex = 5;
            this.picBoxDelete.TabStop = false;
            this.picBoxDelete.Click += new System.EventHandler(this.picBoxDelete_Click);
            // 
            // tBoxDepartmentName
            // 
            this.tBoxDepartmentName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxDepartmentName.Location = new System.Drawing.Point(147, 60);
            this.tBoxDepartmentName.Name = "tBoxDepartmentName";
            this.tBoxDepartmentName.Size = new System.Drawing.Size(242, 30);
            this.tBoxDepartmentName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bölüm Ad :";
            // 
            // bolumTableAdapter
            // 
            this.bolumTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDepartmentActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 566);
            this.Controls.Add(this.tBoxDepartmentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBoxDelete);
            this.Controls.Add(this.picBoxEdit);
            this.Controls.Add(this.dataGridViewDepartment);
            this.Controls.Add(this.picBoxAdd);
            this.MaximizeBox = false;
            this.Name = "FrmDepartmentActions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölüm İşlemleri";
            this.Load += new System.EventHandler(this.FrmDepartmentActions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoxAdd;
        private System.Windows.Forms.DataGridView dataGridViewDepartment;
        private System.Windows.Forms.PictureBox picBoxEdit;
        private System.Windows.Forms.PictureBox picBoxDelete;
        private System.Windows.Forms.Label label2;
        private YurtOtomasyonuDataSeti yurtOtomasyonuDataSeti;
        private System.Windows.Forms.BindingSource bolumBindingSource;
        private YurtOtomasyonuDataSetiTableAdapters.BolumTableAdapter bolumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox tBoxDepartmentName;
    }
}