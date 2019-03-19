using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace FrmMain
{
    public partial class FrmSelectPortDialog : Form
    {
        String nextForm;

        public FrmSelectPortDialog(String nextForm)
        {
            InitializeComponent();
            this.nextForm = nextForm;
        }

        static String selectedPortName = "";

        private void FrmSelectPortDialog_Load(object sender, EventArgs e)
        {

            if (SerialPort.GetPortNames().Length == 0)
            {
                MessageBox.Show("Kullanılabilir bağlantı noktası bulunamadı!\n\nCihaz bağlantısını kontrol edin!");
                this.Close();
            }
            else
            {
                foreach (String portName in SerialPort.GetPortNames())
                {
                    cBoxPorts.Items.Add(portName);
                }

                cBoxPorts.SelectedIndex = 0;
            }


           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            selectedPortName = cBoxPorts.SelectedItem.ToString();

            if(nextForm.Equals("FrmStudentTracking"))
            {
                FrmStudentTracking frmStudentTracking = new FrmStudentTracking(selectedPortName);
                frmStudentTracking.Show();
            }
            else if(nextForm.Equals("FrmAddCard"))
            {
                FrmAddCard frmAddCard = new FrmAddCard(selectedPortName);
                frmAddCard.Show();
            }
            
            
            this.Close();
        }



    }
}
