using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class FrmAddCard : Form
    {

        String selectedPortName;
        String cardNo;
        
        public FrmAddCard(String selectedPortName)
        {
            InitializeComponent();
            this.selectedPortName = selectedPortName;
        }

        //The Database Connection
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HARUN;Initial Catalog=YurtOtomasyonu;Integrated Security=True");


        private void FrmAddCard_Load(object sender, EventArgs e)
        {
            //Set SerialPort Settings
            serialPort2.PortName = selectedPortName;
            serialPort2.BaudRate = 9600;

            //Try To Opening The SerialPort
            try
            {
                if (serialPort2.IsOpen != true)
                {
                    serialPort2.Open();
                }
            }
            catch (IOException exception)
            {
                MessageBox.Show("An Error Occured While COM4 Port Is Opened!\n\nError Code = " + exception);
                //Close This Form
                this.Close();
            }


            this.ActiveControl = mtBoxCardNo;
        }

     

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommandAddCard = new SqlCommand("INSERT INTO Kart(KartNo) VALUES (@pKartNo)", sqlConnection);
                sqlCommandAddCard.Parameters.AddWithValue("@pKartNo", mtBoxCardNo.Text.Trim());
                sqlCommandAddCard.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Kart Eklendi.");
            }
            catch (SqlException sqlException)
            {

                if (sqlException.Number == 2627)
                {
                    MessageBox.Show("Bu Kart Sistemde Zaten Kayıtlı!");
                }
                else
                {
                    MessageBox.Show("An SQL Exception Occoured!\n\nError Code = " + sqlException.Number);
                }

                
            }catch(Exception exception)
            {
                MessageBox.Show("An Error Occurred While The Card Is Added!" + exception);
            }
            finally
            {
                sqlConnection.Close();
            }
            mtBoxCardNo.Text = "";
            this.ActiveControl = mtBoxCardNo;

        }

        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Read Card No From Serial Communiciation
            try
            {
                cardNo = serialPort2.ReadLine().Trim();
                mtBoxCardNo.BeginInvoke(new Action(delegate () { mtBoxCardNo.Text = cardNo; }));
                this.ActiveControl.BeginInvoke(new Action(delegate () { this.ActiveControl = btnAddCard; })); 
            }
            catch (Exception exception)
            {
                MessageBox.Show("An Error Occurred While Data Is Readed From Serial Communication!\n\nError Code = " + exception);
            }

        }

        private void mtBoxCardNo_TextChanged(object sender, EventArgs e)
        {
            if (mtBoxCardNo.Text.Trim().Length == 0)
            {
                btnAddCard.Enabled = false;
            }
            else
            {
                btnAddCard.Enabled = true;
            }
        }
    }
}
