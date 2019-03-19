namespace FrmMain
{
    partial class FrmStudentDeleting
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.picBoxPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rTBoxParentAddress = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tBoxParentName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tBoxParentSurname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mtBoxParentPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxCardNo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtBoxTc = new System.Windows.Forms.MaskedTextBox();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.cBoxDepartment = new System.Windows.Forms.ComboBox();
            this.dTPickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.mtBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(615, 720);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(225, 50);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // picBoxPhoto
            // 
            this.picBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxPhoto.Image = global::FrmMain.Properties.Resources.EducationHouse;
            this.picBoxPhoto.Location = new System.Drawing.Point(615, 38);
            this.picBoxPhoto.Name = "picBoxPhoto";
            this.picBoxPhoto.Size = new System.Drawing.Size(225, 215);
            this.picBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPhoto.TabIndex = 44;
            this.picBoxPhoto.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rTBoxParentAddress);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tBoxParentName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tBoxParentSurname);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.mtBoxParentPhoneNumber);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(39, 470);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 300);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VELİ";
            // 
            // rTBoxParentAddress
            // 
            this.rTBoxParentAddress.Enabled = false;
            this.rTBoxParentAddress.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTBoxParentAddress.Location = new System.Drawing.Point(162, 155);
            this.rTBoxParentAddress.Name = "rTBoxParentAddress";
            this.rTBoxParentAddress.Size = new System.Drawing.Size(276, 96);
            this.rTBoxParentAddress.TabIndex = 12;
            this.rTBoxParentAddress.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(116, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ad:";
            // 
            // tBoxParentName
            // 
            this.tBoxParentName.Enabled = false;
            this.tBoxParentName.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxParentName.Location = new System.Drawing.Point(162, 48);
            this.tBoxParentName.Name = "tBoxParentName";
            this.tBoxParentName.Size = new System.Drawing.Size(276, 28);
            this.tBoxParentName.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(89, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Soyad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(88, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 23);
            this.label12.TabIndex = 28;
            this.label12.Text = "Adres:";
            // 
            // tBoxParentSurname
            // 
            this.tBoxParentSurname.Enabled = false;
            this.tBoxParentSurname.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxParentSurname.Location = new System.Drawing.Point(162, 82);
            this.tBoxParentSurname.Name = "tBoxParentSurname";
            this.tBoxParentSurname.Size = new System.Drawing.Size(276, 28);
            this.tBoxParentSurname.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(75, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "Telefon:";
            // 
            // mtBoxParentPhoneNumber
            // 
            this.mtBoxParentPhoneNumber.Enabled = false;
            this.mtBoxParentPhoneNumber.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtBoxParentPhoneNumber.Location = new System.Drawing.Point(162, 116);
            this.mtBoxParentPhoneNumber.Mask = "(999) 000-0000";
            this.mtBoxParentPhoneNumber.Name = "mtBoxParentPhoneNumber";
            this.mtBoxParentPhoneNumber.Size = new System.Drawing.Size(276, 28);
            this.mtBoxParentPhoneNumber.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxCardNo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtBoxTc);
            this.groupBox1.Controls.Add(this.tBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBoxSurname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tBoxMail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cBoxRoomNumber);
            this.groupBox1.Controls.Add(this.cBoxDepartment);
            this.groupBox1.Controls.Add(this.dTPickerDateOfBirth);
            this.groupBox1.Controls.Add(this.mtBoxPhoneNumber);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(39, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 379);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖĞRENCİ";
            // 
            // cBoxCardNo
            // 
            this.cBoxCardNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCardNo.Enabled = false;
            this.cBoxCardNo.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxCardNo.FormattingEnabled = true;
            this.cBoxCardNo.Location = new System.Drawing.Point(162, 310);
            this.cBoxCardNo.Name = "cBoxCardNo";
            this.cBoxCardNo.Size = new System.Drawing.Size(276, 29);
            this.cBoxCardNo.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(73, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 23);
            this.label14.TabIndex = 41;
            this.label14.Text = "Kart No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(82, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "TC No:";
            // 
            // mtBoxTc
            // 
            this.mtBoxTc.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtBoxTc.Location = new System.Drawing.Point(162, 37);
            this.mtBoxTc.Mask = "00000000000";
            this.mtBoxTc.Name = "mtBoxTc";
            this.mtBoxTc.Size = new System.Drawing.Size(276, 28);
            this.mtBoxTc.TabIndex = 0;
            this.mtBoxTc.ValidatingType = typeof(int);
            this.mtBoxTc.TextChanged += new System.EventHandler(this.mtBoxTc_TextChanged);
            this.mtBoxTc.Validating += new System.ComponentModel.CancelEventHandler(this.mtBoxTc_Validating);
            // 
            // tBoxName
            // 
            this.tBoxName.Enabled = false;
            this.tBoxName.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxName.Location = new System.Drawing.Point(162, 71);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(276, 28);
            this.tBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(116, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(89, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // tBoxSurname
            // 
            this.tBoxSurname.Enabled = false;
            this.tBoxSurname.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxSurname.Location = new System.Drawing.Point(162, 105);
            this.tBoxSurname.Name = "tBoxSurname";
            this.tBoxSurname.Size = new System.Drawing.Size(276, 28);
            this.tBoxSurname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(75, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(98, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mail:";
            // 
            // tBoxMail
            // 
            this.tBoxMail.Enabled = false;
            this.tBoxMail.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxMail.Location = new System.Drawing.Point(162, 208);
            this.tBoxMail.Name = "tBoxMail";
            this.tBoxMail.Size = new System.Drawing.Size(276, 28);
            this.tBoxMail.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(82, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bölüm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(75, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Oda No:";
            // 
            // cBoxRoomNumber
            // 
            this.cBoxRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxRoomNumber.Enabled = false;
            this.cBoxRoomNumber.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxRoomNumber.FormattingEnabled = true;
            this.cBoxRoomNumber.Location = new System.Drawing.Point(162, 275);
            this.cBoxRoomNumber.Name = "cBoxRoomNumber";
            this.cBoxRoomNumber.Size = new System.Drawing.Size(276, 29);
            this.cBoxRoomNumber.TabIndex = 7;
            // 
            // cBoxDepartment
            // 
            this.cBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDepartment.Enabled = false;
            this.cBoxDepartment.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxDepartment.FormattingEnabled = true;
            this.cBoxDepartment.Location = new System.Drawing.Point(162, 241);
            this.cBoxDepartment.Name = "cBoxDepartment";
            this.cBoxDepartment.Size = new System.Drawing.Size(276, 29);
            this.cBoxDepartment.TabIndex = 6;
            // 
            // dTPickerDateOfBirth
            // 
            this.dTPickerDateOfBirth.Checked = false;
            this.dTPickerDateOfBirth.CustomFormat = "";
            this.dTPickerDateOfBirth.Enabled = false;
            this.dTPickerDateOfBirth.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dTPickerDateOfBirth.Location = new System.Drawing.Point(162, 139);
            this.dTPickerDateOfBirth.Name = "dTPickerDateOfBirth";
            this.dTPickerDateOfBirth.Size = new System.Drawing.Size(276, 28);
            this.dTPickerDateOfBirth.TabIndex = 3;
            this.dTPickerDateOfBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // mtBoxPhoneNumber
            // 
            this.mtBoxPhoneNumber.Enabled = false;
            this.mtBoxPhoneNumber.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtBoxPhoneNumber.Location = new System.Drawing.Point(162, 176);
            this.mtBoxPhoneNumber.Mask = "(999) 000-0000";
            this.mtBoxPhoneNumber.Name = "mtBoxPhoneNumber";
            this.mtBoxPhoneNumber.Size = new System.Drawing.Size(276, 28);
            this.mtBoxPhoneNumber.TabIndex = 4;
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // FrmStudentDeleting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 813);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.picBoxPhoto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmStudentDeleting";
            this.Text = "Öğrenci Sil";
            this.Load += new System.EventHandler(this.FrmStudentDeleting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picBoxPhoto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rTBoxParentAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBoxParentName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBoxParentSurname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtBoxParentPhoneNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxCardNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtBoxTc;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBoxRoomNumber;
        private System.Windows.Forms.ComboBox cBoxDepartment;
        private System.Windows.Forms.DateTimePicker dTPickerDateOfBirth;
        private System.Windows.Forms.MaskedTextBox mtBoxPhoneNumber;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}