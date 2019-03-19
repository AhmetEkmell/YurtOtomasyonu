namespace FrmMain
{
    partial class FrmAddCard
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
            this.btnAddCard = new System.Windows.Forms.Button();
            this.mtBoxCardNo = new System.Windows.Forms.MaskedTextBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kart No :";
            // 
            // btnAddCard
            // 
            this.btnAddCard.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCard.Location = new System.Drawing.Point(448, 42);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(102, 33);
            this.btnAddCard.TabIndex = 0;
            this.btnAddCard.Text = "Ekle";
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // mtBoxCardNo
            // 
            this.mtBoxCardNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtBoxCardNo.Location = new System.Drawing.Point(112, 42);
            this.mtBoxCardNo.Mask = "00000000000000000000";
            this.mtBoxCardNo.Name = "mtBoxCardNo";
            this.mtBoxCardNo.Size = new System.Drawing.Size(299, 30);
            this.mtBoxCardNo.TabIndex = 1;
            this.mtBoxCardNo.ValidatingType = typeof(int);
            this.mtBoxCardNo.TextChanged += new System.EventHandler(this.mtBoxCardNo_TextChanged);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // FrmAddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 107);
            this.Controls.Add(this.mtBoxCardNo);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmAddCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kart Ekle";
            this.Load += new System.EventHandler(this.FrmAddCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort2;
        public System.Windows.Forms.MaskedTextBox mtBoxCardNo;
        public System.Windows.Forms.Button btnAddCard;
    }
}