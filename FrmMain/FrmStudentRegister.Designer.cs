namespace FrmMain
{
    partial class FrmStudentRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.tBoxSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dTPickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.mtBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.cBoxDepartment = new System.Windows.Forms.ComboBox();
            this.cBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.tBoxParentSurname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tBoxParentName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtBoxParentPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rTBoxParentAddress = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.mtBoxTc = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.picBoxPhoto = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cBoxCardNo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
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
            // tBoxName
            // 
            this.tBoxName.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxName.Location = new System.Drawing.Point(162, 71);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(276, 28);
            this.tBoxName.TabIndex = 1;
            this.tBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxName_Validating);
            // 
            // tBoxSurname
            // 
            this.tBoxSurname.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxSurname.Location = new System.Drawing.Point(162, 105);
            this.tBoxSurname.Name = "tBoxSurname";
            this.tBoxSurname.Size = new System.Drawing.Size(276, 28);
            this.tBoxSurname.TabIndex = 2;
            this.tBoxSurname.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxSurname_Validating);
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
            // tBoxMail
            // 
            this.tBoxMail.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxMail.Location = new System.Drawing.Point(162, 208);
            this.tBoxMail.Name = "tBoxMail";
            this.tBoxMail.Size = new System.Drawing.Size(276, 28);
            this.tBoxMail.TabIndex = 5;
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
            // dTPickerDateOfBirth
            // 
            this.dTPickerDateOfBirth.Checked = false;
            this.dTPickerDateOfBirth.CustomFormat = "";
            this.dTPickerDateOfBirth.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dTPickerDateOfBirth.Location = new System.Drawing.Point(162, 139);
            this.dTPickerDateOfBirth.Name = "dTPickerDateOfBirth";
            this.dTPickerDateOfBirth.Size = new System.Drawing.Size(276, 28);
            this.dTPickerDateOfBirth.TabIndex = 3;
            this.dTPickerDateOfBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dTPickerDateOfBirth.Validating += new System.ComponentModel.CancelEventHandler(this.dTPickerDateOfBirth_Validating);
            // 
            // mtBoxPhoneNumber
            // 
            this.mtBoxPhoneNumber.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtBoxPhoneNumber.Location = new System.Drawing.Point(162, 176);
            this.mtBoxPhoneNumber.Mask = "(999) 000-0000";
            this.mtBoxPhoneNumber.Name = "mtBoxPhoneNumber";
            this.mtBoxPhoneNumber.Size = new System.Drawing.Size(276, 28);
            this.mtBoxPhoneNumber.TabIndex = 4;
            // 
            // cBoxDepartment
            // 
            this.cBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDepartment.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxDepartment.FormattingEnabled = true;
            this.cBoxDepartment.Location = new System.Drawing.Point(162, 241);
            this.cBoxDepartment.Name = "cBoxDepartment";
            this.cBoxDepartment.Size = new System.Drawing.Size(276, 29);
            this.cBoxDepartment.TabIndex = 6;
            this.cBoxDepartment.Validating += new System.ComponentModel.CancelEventHandler(this.cBoxDepartment_Validating);
            // 
            // cBoxRoomNumber
            // 
            this.cBoxRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxRoomNumber.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxRoomNumber.FormattingEnabled = true;
            this.cBoxRoomNumber.Location = new System.Drawing.Point(162, 275);
            this.cBoxRoomNumber.Name = "cBoxRoomNumber";
            this.cBoxRoomNumber.Size = new System.Drawing.Size(276, 29);
            this.cBoxRoomNumber.TabIndex = 7;
            this.cBoxRoomNumber.Validating += new System.ComponentModel.CancelEventHandler(this.cBoxRoomNumber_Validating);
            // 
            // tBoxParentSurname
            // 
            this.tBoxParentSurname.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxParentSurname.Location = new System.Drawing.Point(162, 82);
            this.tBoxParentSurname.Name = "tBoxParentSurname";
            this.tBoxParentSurname.Size = new System.Drawing.Size(276, 28);
            this.tBoxParentSurname.TabIndex = 10;
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
            // tBoxParentName
            // 
            this.tBoxParentName.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxParentName.Location = new System.Drawing.Point(162, 48);
            this.tBoxParentName.Name = "tBoxParentName";
            this.tBoxParentName.Size = new System.Drawing.Size(276, 28);
            this.tBoxParentName.TabIndex = 9;
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
            // mtBoxParentPhoneNumber
            // 
            this.mtBoxParentPhoneNumber.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtBoxParentPhoneNumber.Location = new System.Drawing.Point(162, 116);
            this.mtBoxParentPhoneNumber.Mask = "(999) 000-0000";
            this.mtBoxParentPhoneNumber.Name = "mtBoxParentPhoneNumber";
            this.mtBoxParentPhoneNumber.Size = new System.Drawing.Size(276, 28);
            this.mtBoxParentPhoneNumber.TabIndex = 11;
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
            // rTBoxParentAddress
            // 
            this.rTBoxParentAddress.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTBoxParentAddress.Location = new System.Drawing.Point(162, 155);
            this.rTBoxParentAddress.Name = "rTBoxParentAddress";
            this.rTBoxParentAddress.Size = new System.Drawing.Size(276, 96);
            this.rTBoxParentAddress.TabIndex = 12;
            this.rTBoxParentAddress.Text = "";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxCardNo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
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
            this.groupBox1.Location = new System.Drawing.Point(45, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 379);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖĞRENCİ";
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
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(56, 315);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 24);
            this.label20.TabIndex = 42;
            this.label20.Text = "*";
            this.toolTip1.SetToolTip(this.label20, "Zorunlu Alan");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(59, 281);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 24);
            this.label19.TabIndex = 39;
            this.label19.Text = "*";
            this.toolTip1.SetToolTip(this.label19, "Zorunlu Alan");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(67, 247);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 24);
            this.label18.TabIndex = 38;
            this.label18.Text = "*";
            this.toolTip1.SetToolTip(this.label18, "Zorunlu Alan");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(3, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 24);
            this.label17.TabIndex = 37;
            this.label17.Text = "*";
            this.toolTip1.SetToolTip(this.label17, "Zorunlu Alan");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(73, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 24);
            this.label16.TabIndex = 36;
            this.label16.Text = "*";
            this.toolTip1.SetToolTip(this.label16, "Zorunlu Alan");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(99, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 24);
            this.label15.TabIndex = 35;
            this.label15.Text = "*";
            this.toolTip1.SetToolTip(this.label15, "Zorunlu Alan");
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(65, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 24);
            this.label13.TabIndex = 34;
            this.label13.Text = "*";
            this.toolTip1.SetToolTip(this.label13, "Zorunlu Alan");
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
            this.mtBoxTc.Validating += new System.ComponentModel.CancelEventHandler(this.mtBoxTc_Validating);
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
            this.groupBox2.Location = new System.Drawing.Point(45, 464);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 300);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VELİ";
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectPhoto.Location = new System.Drawing.Point(621, 269);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(225, 50);
            this.btnSelectPhoto.TabIndex = 13;
            this.btnSelectPhoto.Text = "Resim Seç";
            this.btnSelectPhoto.UseVisualStyleBackColor = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            this.btnSelectPhoto.Validating += new System.ComponentModel.CancelEventHandler(this.btnSelectPhoto_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(621, 714);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 50);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picBoxPhoto
            // 
            this.picBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxPhoto.Image = global::FrmMain.Properties.Resources.EducationHouse;
            this.picBoxPhoto.Location = new System.Drawing.Point(621, 32);
            this.picBoxPhoto.Name = "picBoxPhoto";
            this.picBoxPhoto.Size = new System.Drawing.Size(225, 215);
            this.picBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPhoto.TabIndex = 33;
            this.picBoxPhoto.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(598, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 24);
            this.label21.TabIndex = 35;
            this.label21.Text = "*";
            this.toolTip1.SetToolTip(this.label21, "Zorunlu Alan");
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // cBoxCardNo
            // 
            this.cBoxCardNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCardNo.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxCardNo.FormattingEnabled = true;
            this.cBoxCardNo.Location = new System.Drawing.Point(162, 313);
            this.cBoxCardNo.Name = "cBoxCardNo";
            this.cBoxCardNo.Size = new System.Drawing.Size(276, 29);
            this.cBoxCardNo.TabIndex = 43;
            this.cBoxCardNo.Validating += new System.ComponentModel.CancelEventHandler(this.cBoxCardNo_Validating);
            // 
            // FrmStudentRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(882, 813);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectPhoto);
            this.Controls.Add(this.picBoxPhoto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmStudentRegister";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.FrmStudentRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.TextBox tBoxSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dTPickerDateOfBirth;
        private System.Windows.Forms.MaskedTextBox mtBoxPhoneNumber;
        private System.Windows.Forms.ComboBox cBoxDepartment;
        private System.Windows.Forms.ComboBox cBoxRoomNumber;
        private System.Windows.Forms.TextBox tBoxParentSurname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBoxParentName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtBoxParentPhoneNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rTBoxParentAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picBoxPhoto;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtBoxTc;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cBoxCardNo;
    }
}