namespace FrmMain
{
    partial class FrmStudentTracking
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblLoginWarning = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLastLoginNameSurname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLastLoginTime = new System.Windows.Forms.Label();
            this.dataGridViewLogin = new System.Windows.Forms.DataGridView();
            this.pictBoxLogin = new System.Windows.Forms.PictureBox();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.lblLogoutWarning = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastLogoutNameSurname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLastLogoutTime = new System.Windows.Forms.Label();
            this.dataGridViewLogout = new System.Windows.Forms.DataGridView();
            this.pictBoxLogout = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pnlLogin.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogin)).BeginInit();
            this.pnlLogout.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLogin.Controls.Add(this.lblLoginWarning);
            this.pnlLogin.Controls.Add(this.panel3);
            this.pnlLogin.Controls.Add(this.dataGridViewLogin);
            this.pnlLogin.Controls.Add(this.pictBoxLogin);
            this.pnlLogin.Location = new System.Drawing.Point(50, 50);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(900, 900);
            this.pnlLogin.TabIndex = 18;
            // 
            // lblLoginWarning
            // 
            this.lblLoginWarning.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLoginWarning.ForeColor = System.Drawing.Color.Red;
            this.lblLoginWarning.Location = new System.Drawing.Point(25, 357);
            this.lblLoginWarning.Name = "lblLoginWarning";
            this.lblLoginWarning.Size = new System.Drawing.Size(500, 31);
            this.lblLoginWarning.TabIndex = 20;
            this.lblLoginWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblLastLoginNameSurname);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblLastLoginTime);
            this.panel3.Location = new System.Drawing.Point(25, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 300);
            this.panel3.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 100);
            this.label4.TabIndex = 19;
            this.label4.Text = "Giriş Zamanı:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastLoginNameSurname
            // 
            this.lblLastLoginNameSurname.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastLoginNameSurname.Location = new System.Drawing.Point(190, 50);
            this.lblLastLoginNameSurname.Name = "lblLastLoginNameSurname";
            this.lblLastLoginNameSurname.Size = new System.Drawing.Size(300, 100);
            this.lblLastLoginNameSurname.TabIndex = 18;
            this.lblLastLoginNameSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 100);
            this.label7.TabIndex = 17;
            this.label7.Text = "Son Giriş:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastLoginTime
            // 
            this.lblLastLoginTime.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastLoginTime.Location = new System.Drawing.Point(190, 150);
            this.lblLastLoginTime.Name = "lblLastLoginTime";
            this.lblLastLoginTime.Size = new System.Drawing.Size(302, 100);
            this.lblLastLoginTime.TabIndex = 16;
            this.lblLastLoginTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewLogin
            // 
            this.dataGridViewLogin.AllowUserToAddRows = false;
            this.dataGridViewLogin.AllowUserToDeleteRows = false;
            this.dataGridViewLogin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLogin.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridViewLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogin.Enabled = false;
            this.dataGridViewLogin.Location = new System.Drawing.Point(25, 425);
            this.dataGridViewLogin.Name = "dataGridViewLogin";
            this.dataGridViewLogin.RowTemplate.Height = 24;
            this.dataGridViewLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewLogin.Size = new System.Drawing.Size(850, 442);
            this.dataGridViewLogin.TabIndex = 7;
            // 
            // pictBoxLogin
            // 
            this.pictBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBoxLogin.Location = new System.Drawing.Point(575, 25);
            this.pictBoxLogin.Name = "pictBoxLogin";
            this.pictBoxLogin.Size = new System.Drawing.Size(300, 300);
            this.pictBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxLogin.TabIndex = 6;
            this.pictBoxLogin.TabStop = false;
            // 
            // pnlLogout
            // 
            this.pnlLogout.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlLogout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLogout.Controls.Add(this.lblLogoutWarning);
            this.pnlLogout.Controls.Add(this.panel2);
            this.pnlLogout.Controls.Add(this.dataGridViewLogout);
            this.pnlLogout.Controls.Add(this.pictBoxLogout);
            this.pnlLogout.Location = new System.Drawing.Point(1070, 50);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(900, 900);
            this.pnlLogout.TabIndex = 19;
            // 
            // lblLogoutWarning
            // 
            this.lblLogoutWarning.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogoutWarning.ForeColor = System.Drawing.Color.Red;
            this.lblLogoutWarning.Location = new System.Drawing.Point(25, 348);
            this.lblLogoutWarning.Name = "lblLogoutWarning";
            this.lblLogoutWarning.Size = new System.Drawing.Size(500, 31);
            this.lblLogoutWarning.TabIndex = 25;
            this.lblLogoutWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblLastLogoutNameSurname);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblLastLogoutTime);
            this.panel2.Location = new System.Drawing.Point(25, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 300);
            this.panel2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 100);
            this.label1.TabIndex = 19;
            this.label1.Text = "Çıkış Zamanı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastLogoutNameSurname
            // 
            this.lblLastLogoutNameSurname.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastLogoutNameSurname.Location = new System.Drawing.Point(190, 50);
            this.lblLastLogoutNameSurname.Name = "lblLastLogoutNameSurname";
            this.lblLastLogoutNameSurname.Size = new System.Drawing.Size(300, 100);
            this.lblLastLogoutNameSurname.TabIndex = 18;
            this.lblLastLogoutNameSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 100);
            this.label5.TabIndex = 17;
            this.label5.Text = "Son Çıkış:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastLogoutTime
            // 
            this.lblLastLogoutTime.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastLogoutTime.Location = new System.Drawing.Point(190, 150);
            this.lblLastLogoutTime.Name = "lblLastLogoutTime";
            this.lblLastLogoutTime.Size = new System.Drawing.Size(302, 100);
            this.lblLastLogoutTime.TabIndex = 16;
            this.lblLastLogoutTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewLogout
            // 
            this.dataGridViewLogout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLogout.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridViewLogout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewLogout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogout.Enabled = false;
            this.dataGridViewLogout.Location = new System.Drawing.Point(25, 425);
            this.dataGridViewLogout.Name = "dataGridViewLogout";
            this.dataGridViewLogout.ReadOnly = true;
            this.dataGridViewLogout.RowTemplate.Height = 24;
            this.dataGridViewLogout.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewLogout.Size = new System.Drawing.Size(850, 442);
            this.dataGridViewLogout.TabIndex = 19;
            // 
            // pictBoxLogout
            // 
            this.pictBoxLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBoxLogout.Location = new System.Drawing.Point(575, 25);
            this.pictBoxLogout.Name = "pictBoxLogout";
            this.pictBoxLogout.Size = new System.Drawing.Size(300, 300);
            this.pictBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxLogout.TabIndex = 18;
            this.pictBoxLogout.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // FrmStudentTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pnlLogout);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmStudentTracking";
            this.Text = "Öğrenci Takip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStudentTracking_FormClosing);
            this.Load += new System.EventHandler(this.FrmStudentTracking_Load);
            this.pnlLogin.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogin)).EndInit();
            this.pnlLogout.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.DataGridView dataGridViewLogin;
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.DataGridView dataGridViewLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        public System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.PictureBox pictBoxLogin;
        public System.Windows.Forms.PictureBox pictBoxLogout;
        public System.Windows.Forms.Label lblLastLogoutNameSurname;
        public System.Windows.Forms.Label lblLastLogoutTime;
        public System.Windows.Forms.Label lblLastLoginNameSurname;
        public System.Windows.Forms.Label lblLastLoginTime;
        private System.Windows.Forms.Label lblLoginWarning;
        private System.Windows.Forms.Label lblLogoutWarning;
    }
}