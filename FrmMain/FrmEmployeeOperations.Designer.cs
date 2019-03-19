namespace FrmMain
{
    partial class FrmEmployeeOperations
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
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSetEmployee = new FrmMain.YurtOtomasyonuDataSetEmployee();
            this.picBoxDelete = new System.Windows.Forms.PictureBox();
            this.picBoxEdit = new System.Windows.Forms.PictureBox();
            this.picBoxAdd = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtBoxEmployeeSalary = new System.Windows.Forms.MaskedTextBox();
            this.mtBoxEmployeeTc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxEmployeeDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxEmployeeSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.personelTableAdapter = new FrmMain.YurtOtomasyonuDataSetEmployeeTableAdapters.PersonelTableAdapter();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSetEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AutoGenerateColumns = false;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.departmanDataGridViewTextBoxColumn,
            this.maasDataGridViewTextBoxColumn});
            this.dataGridViewEmployee.DataSource = this.personelBindingSource;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(473, 27);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(698, 392);
            this.dataGridViewEmployee.TabIndex = 9;
            this.dataGridViewEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellClick);
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "Tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "Tc";
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            this.tcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmanDataGridViewTextBoxColumn
            // 
            this.departmanDataGridViewTextBoxColumn.DataPropertyName = "Departman";
            this.departmanDataGridViewTextBoxColumn.HeaderText = "Departman";
            this.departmanDataGridViewTextBoxColumn.Name = "departmanDataGridViewTextBoxColumn";
            this.departmanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maasDataGridViewTextBoxColumn
            // 
            this.maasDataGridViewTextBoxColumn.DataPropertyName = "Maas";
            this.maasDataGridViewTextBoxColumn.HeaderText = "Maas";
            this.maasDataGridViewTextBoxColumn.Name = "maasDataGridViewTextBoxColumn";
            this.maasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.yurtOtomasyonuDataSetEmployee;
            // 
            // yurtOtomasyonuDataSetEmployee
            // 
            this.yurtOtomasyonuDataSetEmployee.DataSetName = "YurtOtomasyonuDataSetEmployee";
            this.yurtOtomasyonuDataSetEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // picBoxDelete
            // 
            this.picBoxDelete.Image = global::FrmMain.Properties.Resources.delete;
            this.picBoxDelete.Location = new System.Drawing.Point(374, 344);
            this.picBoxDelete.Name = "picBoxDelete";
            this.picBoxDelete.Size = new System.Drawing.Size(75, 75);
            this.picBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDelete.TabIndex = 24;
            this.picBoxDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.picBoxDelete, "Personel sil");
            this.picBoxDelete.Click += new System.EventHandler(this.picBoxDelete_Click);
            // 
            // picBoxEdit
            // 
            this.picBoxEdit.Image = global::FrmMain.Properties.Resources.edit;
            this.picBoxEdit.Location = new System.Drawing.Point(196, 344);
            this.picBoxEdit.Name = "picBoxEdit";
            this.picBoxEdit.Size = new System.Drawing.Size(75, 75);
            this.picBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxEdit.TabIndex = 23;
            this.picBoxEdit.TabStop = false;
            this.toolTip1.SetToolTip(this.picBoxEdit, "Personeli düzenle");
            this.picBoxEdit.Click += new System.EventHandler(this.picBoxEdit_Click);
            // 
            // picBoxAdd
            // 
            this.picBoxAdd.Image = global::FrmMain.Properties.Resources.add;
            this.picBoxAdd.Location = new System.Drawing.Point(12, 344);
            this.picBoxAdd.Name = "picBoxAdd";
            this.picBoxAdd.Size = new System.Drawing.Size(75, 75);
            this.picBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAdd.TabIndex = 22;
            this.picBoxAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.picBoxAdd, "Personel ekle");
            this.picBoxAdd.Click += new System.EventHandler(this.picBoxAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtBoxEmployeeSalary);
            this.groupBox1.Controls.Add(this.mtBoxEmployeeTc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tBoxEmployeeDepartment);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tBoxEmployeeSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBoxEmployeeName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 301);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel";
            // 
            // mtBoxEmployeeSalary
            // 
            this.mtBoxEmployeeSalary.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtBoxEmployeeSalary.Location = new System.Drawing.Point(161, 235);
            this.mtBoxEmployeeSalary.Mask = "00000000";
            this.mtBoxEmployeeSalary.Name = "mtBoxEmployeeSalary";
            this.mtBoxEmployeeSalary.Size = new System.Drawing.Size(242, 30);
            this.mtBoxEmployeeSalary.TabIndex = 4;
            this.mtBoxEmployeeSalary.ValidatingType = typeof(int);
            // 
            // mtBoxEmployeeTc
            // 
            this.mtBoxEmployeeTc.Location = new System.Drawing.Point(161, 50);
            this.mtBoxEmployeeTc.Mask = "00000000000";
            this.mtBoxEmployeeTc.Name = "mtBoxEmployeeTc";
            this.mtBoxEmployeeTc.Size = new System.Drawing.Size(242, 30);
            this.mtBoxEmployeeTc.TabIndex = 0;
            this.mtBoxEmployeeTc.ValidatingType = typeof(int);
            this.mtBoxEmployeeTc.Validating += new System.ComponentModel.CancelEventHandler(this.mtBoxEmployeeTc_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(73, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Maaş :";
            // 
            // tBoxEmployeeDepartment
            // 
            this.tBoxEmployeeDepartment.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxEmployeeDepartment.Location = new System.Drawing.Point(161, 188);
            this.tBoxEmployeeDepartment.Name = "tBoxEmployeeDepartment";
            this.tBoxEmployeeDepartment.Size = new System.Drawing.Size(242, 30);
            this.tBoxEmployeeDepartment.TabIndex = 3;
            this.tBoxEmployeeDepartment.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxEmployeeDepartment_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Departman :";
            // 
            // tBoxEmployeeSurname
            // 
            this.tBoxEmployeeSurname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxEmployeeSurname.Location = new System.Drawing.Point(161, 142);
            this.tBoxEmployeeSurname.Name = "tBoxEmployeeSurname";
            this.tBoxEmployeeSurname.Size = new System.Drawing.Size(242, 30);
            this.tBoxEmployeeSurname.TabIndex = 2;
            this.tBoxEmployeeSurname.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxEmployeeSurname_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Soyad :";
            // 
            // tBoxEmployeeName
            // 
            this.tBoxEmployeeName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxEmployeeName.Location = new System.Drawing.Point(161, 96);
            this.tBoxEmployeeName.Name = "tBoxEmployeeName";
            this.tBoxEmployeeName.Size = new System.Drawing.Size(242, 30);
            this.tBoxEmployeeName.TabIndex = 1;
            this.tBoxEmployeeName.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxEmployeeName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(73, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "TC No :";
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // FrmEmployeeOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBoxDelete);
            this.Controls.Add(this.picBoxEdit);
            this.Controls.Add(this.picBoxAdd);
            this.Controls.Add(this.dataGridViewEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEmployeeOperations";
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.FrmEmployeeOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSetEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.PictureBox picBoxDelete;
        private System.Windows.Forms.PictureBox picBoxEdit;
        private System.Windows.Forms.PictureBox picBoxAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tBoxEmployeeDepartment;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tBoxEmployeeSurname;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tBoxEmployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maasDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox mtBoxEmployeeTc;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.MaskedTextBox mtBoxEmployeeSalary;
        private System.Windows.Forms.ToolTip toolTip1;
        private FrmMain.YurtOtomasyonuDataSetEmployee yurtOtomasyonuDataSetEmployee;
        private FrmMain.YurtOtomasyonuDataSetEmployeeTableAdapters.PersonelTableAdapter personelTableAdapter;
    }
}