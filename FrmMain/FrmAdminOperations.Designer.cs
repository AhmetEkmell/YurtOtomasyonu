namespace FrmMain
{
    partial class FrmAdminOperations
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBoxSaveEmployeePassword = new System.Windows.Forms.TextBox();
            this.tBoxSaveEmployeeUsername = new System.Windows.Forms.TextBox();
            this.tBoxSaveEmployeeSurname = new System.Windows.Forms.TextBox();
            this.tBoxSaveEmployeeName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxSaveEmployeeTc = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBoxUpdateEmployeePassword = new System.Windows.Forms.TextBox();
            this.tBoxUpdateEmployeeUsername = new System.Windows.Forms.TextBox();
            this.tBoxUpdateEmployeeSurname = new System.Windows.Forms.TextBox();
            this.tBoxUpdateEmployeeName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cBoxUpdateEmployeeTc = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tBoxDeleteEmployeePassword = new System.Windows.Forms.TextBox();
            this.tBoxDeleteEmployeeUsername = new System.Windows.Forms.TextBox();
            this.tBoxDeleteEmployeeSurname = new System.Windows.Forms.TextBox();
            this.tBoxDeleteEmployeeName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cBoxDeleteEmployeeTc = new System.Windows.Forms.ComboBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBoxSaveEmployeePassword);
            this.groupBox1.Controls.Add(this.tBoxSaveEmployeeUsername);
            this.groupBox1.Controls.Add(this.tBoxSaveEmployeeSurname);
            this.groupBox1.Controls.Add(this.tBoxSaveEmployeeName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxSaveEmployeeTc);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 400);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici Ekle";
            // 
            // tBoxSaveEmployeePassword
            // 
            this.tBoxSaveEmployeePassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxSaveEmployeePassword.Location = new System.Drawing.Point(194, 259);
            this.tBoxSaveEmployeePassword.Name = "tBoxSaveEmployeePassword";
            this.tBoxSaveEmployeePassword.Size = new System.Drawing.Size(333, 30);
            this.tBoxSaveEmployeePassword.TabIndex = 4;
            this.tBoxSaveEmployeePassword.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxEmployeePassword_Validating);
            // 
            // tBoxSaveEmployeeUsername
            // 
            this.tBoxSaveEmployeeUsername.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxSaveEmployeeUsername.Location = new System.Drawing.Point(194, 208);
            this.tBoxSaveEmployeeUsername.Name = "tBoxSaveEmployeeUsername";
            this.tBoxSaveEmployeeUsername.Size = new System.Drawing.Size(333, 30);
            this.tBoxSaveEmployeeUsername.TabIndex = 3;
            this.tBoxSaveEmployeeUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxEmployeeUsername_Validating);
            // 
            // tBoxSaveEmployeeSurname
            // 
            this.tBoxSaveEmployeeSurname.Enabled = false;
            this.tBoxSaveEmployeeSurname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxSaveEmployeeSurname.Location = new System.Drawing.Point(194, 157);
            this.tBoxSaveEmployeeSurname.Name = "tBoxSaveEmployeeSurname";
            this.tBoxSaveEmployeeSurname.Size = new System.Drawing.Size(333, 30);
            this.tBoxSaveEmployeeSurname.TabIndex = 2;
            // 
            // tBoxSaveEmployeeName
            // 
            this.tBoxSaveEmployeeName.Enabled = false;
            this.tBoxSaveEmployeeName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxSaveEmployeeName.Location = new System.Drawing.Point(194, 109);
            this.tBoxSaveEmployeeName.Name = "tBoxSaveEmployeeName";
            this.tBoxSaveEmployeeName.Size = new System.Drawing.Size(333, 30);
            this.tBoxSaveEmployeeName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(390, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 42);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(104, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(89, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(126, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel TC :";
            // 
            // cBoxSaveEmployeeTc
            // 
            this.cBoxSaveEmployeeTc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSaveEmployeeTc.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxSaveEmployeeTc.FormattingEnabled = true;
            this.cBoxSaveEmployeeTc.Location = new System.Drawing.Point(194, 59);
            this.cBoxSaveEmployeeTc.Name = "cBoxSaveEmployeeTc";
            this.cBoxSaveEmployeeTc.Size = new System.Drawing.Size(333, 32);
            this.cBoxSaveEmployeeTc.TabIndex = 0;
            this.cBoxSaveEmployeeTc.SelectedValueChanged += new System.EventHandler(this.cBoxEmployeeTc_SelectedValueChanged);
            this.cBoxSaveEmployeeTc.Validating += new System.ComponentModel.CancelEventHandler(this.cBoxEmployeeTc_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBoxUpdateEmployeePassword);
            this.groupBox2.Controls.Add(this.tBoxUpdateEmployeeUsername);
            this.groupBox2.Controls.Add(this.tBoxUpdateEmployeeSurname);
            this.groupBox2.Controls.Add(this.tBoxUpdateEmployeeName);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cBoxUpdateEmployeeTc);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(621, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 400);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yönetici Bilgisi Güncelle";
            // 
            // tBoxUpdateEmployeePassword
            // 
            this.tBoxUpdateEmployeePassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxUpdateEmployeePassword.Location = new System.Drawing.Point(193, 259);
            this.tBoxUpdateEmployeePassword.Name = "tBoxUpdateEmployeePassword";
            this.tBoxUpdateEmployeePassword.Size = new System.Drawing.Size(333, 30);
            this.tBoxUpdateEmployeePassword.TabIndex = 10;
            this.tBoxUpdateEmployeePassword.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxUpdateEmployeePassword_Validating);
            // 
            // tBoxUpdateEmployeeUsername
            // 
            this.tBoxUpdateEmployeeUsername.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxUpdateEmployeeUsername.Location = new System.Drawing.Point(193, 208);
            this.tBoxUpdateEmployeeUsername.Name = "tBoxUpdateEmployeeUsername";
            this.tBoxUpdateEmployeeUsername.Size = new System.Drawing.Size(333, 30);
            this.tBoxUpdateEmployeeUsername.TabIndex = 9;
            this.tBoxUpdateEmployeeUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxUpdateEmployeeUsername_Validating);
            // 
            // tBoxUpdateEmployeeSurname
            // 
            this.tBoxUpdateEmployeeSurname.Enabled = false;
            this.tBoxUpdateEmployeeSurname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxUpdateEmployeeSurname.Location = new System.Drawing.Point(193, 157);
            this.tBoxUpdateEmployeeSurname.Name = "tBoxUpdateEmployeeSurname";
            this.tBoxUpdateEmployeeSurname.Size = new System.Drawing.Size(333, 30);
            this.tBoxUpdateEmployeeSurname.TabIndex = 8;
            // 
            // tBoxUpdateEmployeeName
            // 
            this.tBoxUpdateEmployeeName.Enabled = false;
            this.tBoxUpdateEmployeeName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxUpdateEmployeeName.Location = new System.Drawing.Point(193, 109);
            this.tBoxUpdateEmployeeName.Name = "tBoxUpdateEmployeeName";
            this.tBoxUpdateEmployeeName.Size = new System.Drawing.Size(333, 30);
            this.tBoxUpdateEmployeeName.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(389, 306);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 42);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(103, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Şifre :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(17, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Kullanıcı Adı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(88, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Soyad :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(125, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ad :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(29, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Personel TC :";
            // 
            // cBoxUpdateEmployeeTc
            // 
            this.cBoxUpdateEmployeeTc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxUpdateEmployeeTc.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxUpdateEmployeeTc.FormattingEnabled = true;
            this.cBoxUpdateEmployeeTc.Location = new System.Drawing.Point(193, 59);
            this.cBoxUpdateEmployeeTc.Name = "cBoxUpdateEmployeeTc";
            this.cBoxUpdateEmployeeTc.Size = new System.Drawing.Size(333, 32);
            this.cBoxUpdateEmployeeTc.TabIndex = 6;
            this.cBoxUpdateEmployeeTc.SelectedValueChanged += new System.EventHandler(this.cBoxUpdateEmployeeTc_SelectedValueChanged);
            this.cBoxUpdateEmployeeTc.Validating += new System.ComponentModel.CancelEventHandler(this.cBoxUpdateEmployeeTc_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tBoxDeleteEmployeePassword);
            this.groupBox3.Controls.Add(this.tBoxDeleteEmployeeUsername);
            this.groupBox3.Controls.Add(this.tBoxDeleteEmployeeSurname);
            this.groupBox3.Controls.Add(this.tBoxDeleteEmployeeName);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cBoxDeleteEmployeeTc);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(304, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 400);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yönetici Sil";
            // 
            // tBoxDeleteEmployeePassword
            // 
            this.tBoxDeleteEmployeePassword.Enabled = false;
            this.tBoxDeleteEmployeePassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxDeleteEmployeePassword.Location = new System.Drawing.Point(199, 259);
            this.tBoxDeleteEmployeePassword.Name = "tBoxDeleteEmployeePassword";
            this.tBoxDeleteEmployeePassword.Size = new System.Drawing.Size(333, 30);
            this.tBoxDeleteEmployeePassword.TabIndex = 16;
            // 
            // tBoxDeleteEmployeeUsername
            // 
            this.tBoxDeleteEmployeeUsername.Enabled = false;
            this.tBoxDeleteEmployeeUsername.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxDeleteEmployeeUsername.Location = new System.Drawing.Point(199, 208);
            this.tBoxDeleteEmployeeUsername.Name = "tBoxDeleteEmployeeUsername";
            this.tBoxDeleteEmployeeUsername.Size = new System.Drawing.Size(333, 30);
            this.tBoxDeleteEmployeeUsername.TabIndex = 15;
            // 
            // tBoxDeleteEmployeeSurname
            // 
            this.tBoxDeleteEmployeeSurname.Enabled = false;
            this.tBoxDeleteEmployeeSurname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxDeleteEmployeeSurname.Location = new System.Drawing.Point(199, 157);
            this.tBoxDeleteEmployeeSurname.Name = "tBoxDeleteEmployeeSurname";
            this.tBoxDeleteEmployeeSurname.Size = new System.Drawing.Size(333, 30);
            this.tBoxDeleteEmployeeSurname.TabIndex = 14;
            // 
            // tBoxDeleteEmployeeName
            // 
            this.tBoxDeleteEmployeeName.Enabled = false;
            this.tBoxDeleteEmployeeName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxDeleteEmployeeName.Location = new System.Drawing.Point(199, 109);
            this.tBoxDeleteEmployeeName.Name = "tBoxDeleteEmployeeName";
            this.tBoxDeleteEmployeeName.Size = new System.Drawing.Size(333, 30);
            this.tBoxDeleteEmployeeName.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(395, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 42);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(109, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 24);
            this.label11.TabIndex = 31;
            this.label11.Text = "Şifre :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(23, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "Kullanıcı Adı :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(94, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 24);
            this.label13.TabIndex = 29;
            this.label13.Text = "Soyad :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(131, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 24);
            this.label14.TabIndex = 28;
            this.label14.Text = "Ad :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(35, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 24);
            this.label15.TabIndex = 27;
            this.label15.Text = "Personel TC :";
            // 
            // cBoxDeleteEmployeeTc
            // 
            this.cBoxDeleteEmployeeTc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDeleteEmployeeTc.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxDeleteEmployeeTc.FormattingEnabled = true;
            this.cBoxDeleteEmployeeTc.Location = new System.Drawing.Point(199, 59);
            this.cBoxDeleteEmployeeTc.Name = "cBoxDeleteEmployeeTc";
            this.cBoxDeleteEmployeeTc.Size = new System.Drawing.Size(333, 32);
            this.cBoxDeleteEmployeeTc.TabIndex = 12;
            this.cBoxDeleteEmployeeTc.SelectedValueChanged += new System.EventHandler(this.cBoxDeleteEmployeeTc_SelectedValueChanged);
            this.cBoxDeleteEmployeeTc.Validating += new System.ComponentModel.CancelEventHandler(this.cBoxDeleteEmployeeTc_Validating);
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // FrmAdminOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 871);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAdminOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici İşlemleri";
            this.Load += new System.EventHandler(this.FrmAdminOperations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBoxSaveEmployeePassword;
        private System.Windows.Forms.TextBox tBoxSaveEmployeeUsername;
        private System.Windows.Forms.TextBox tBoxSaveEmployeeSurname;
        private System.Windows.Forms.TextBox tBoxSaveEmployeeName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxSaveEmployeeTc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.TextBox tBoxUpdateEmployeePassword;
        private System.Windows.Forms.TextBox tBoxUpdateEmployeeUsername;
        private System.Windows.Forms.TextBox tBoxUpdateEmployeeSurname;
        private System.Windows.Forms.TextBox tBoxUpdateEmployeeName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cBoxUpdateEmployeeTc;
        private System.Windows.Forms.TextBox tBoxDeleteEmployeePassword;
        private System.Windows.Forms.TextBox tBoxDeleteEmployeeUsername;
        private System.Windows.Forms.TextBox tBoxDeleteEmployeeSurname;
        private System.Windows.Forms.TextBox tBoxDeleteEmployeeName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cBoxDeleteEmployeeTc;
    }
}