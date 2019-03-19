using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace FrmMain
{
    public partial class FrmStudentTracking : Form
    {
        String selectedPortName;

        public FrmStudentTracking(String selectedPortName)
        {
            InitializeComponent();
            //Assign The Value Which Is Comes From FrmSelectPortName To X
            this.selectedPortName = selectedPortName;
        }

        //Create SQL Connection
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HARUN;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        String cardNo = "";
        Boolean isTheCardValid;
        byte[] photo;

        private void FrmStudentTracking_Load(object sender, EventArgs e)
        {
            //Set SerialPort Settings
            serialPort1.PortName = selectedPortName;
            serialPort1.BaudRate = 9600;

            //Try To Opening The SerialPort
            try
            {
                    if (serialPort1.IsOpen != true)
                    {
                        serialPort1.Open();
                    }                
            }
            catch (IOException  exception)
            {
                MessageBox.Show("An Error Occured While COM4 Port Is Opened!\n\nError Code = " + exception);
                //Close This Form
                this.Close();
            }
            

        }



        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Read Card No From Serial Communiciation
            try
            {
                cardNo = serialPort1.ReadLine().Trim();
            }
            catch (Exception exception)
            {
                MessageBox.Show("An Error Occurred While Data Is Readed From Serial Communication!\n\nError Code = " + exception);
            }



            try
            {

                sqlConnection.Open();
                SqlCommand sqlCommandIsTheCardValid = new SqlCommand("SELECT COUNT(KartSahibiTc) FROM Kart WHERE KartNo = @pCardNo", sqlConnection);
                sqlCommandIsTheCardValid.Parameters.AddWithValue("@pCardNo", cardNo);
                isTheCardValid = (int)sqlCommandIsTheCardValid.ExecuteScalar() == 1 ? true : false;
                sqlConnection.Close();

                if (isTheCardValid) { 

                //Update The Last Action Of The Person Who Owns This Card
                sqlConnection.Open();

                SqlCommand sqlCommandUpdateLastAction = new SqlCommand("IF (SELECT SonGiris FROM Kart WHERE KartNo = @pCardNo) < (SELECT SonCikis FROM Kart WHERE KartNo = @pCardNo) " +
                                                                            "BEGIN UPDATE Kart SET SonGiris = @pActionTime WHERE KartNo = @pCardNo END " +
                                                                            "ELSE BEGIN UPDATE Kart SET SonCikis = @pActionTime WHERE KartNo = @pCardNo END", sqlConnection);
                sqlCommandUpdateLastAction.Parameters.AddWithValue("@pCardNo", cardNo);
                sqlCommandUpdateLastAction.Parameters.AddWithValue("@pActionTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                sqlCommandUpdateLastAction.ExecuteNonQuery();
                sqlConnection.Close();

                }
                else
                {
                    
                    pictBoxLogin.BeginInvoke(new Action(delegate () { pictBoxLogin.Image = Properties.Resources.disallowedIcon; }));
                    lblLoginWarning.BeginInvoke(new Action(delegate () { lblLoginWarning.Text = "Kart Geçersiz!"; }));
                    Thread.Sleep(1000);
                    lblLoginWarning.BeginInvoke(new Action(delegate () { lblLoginWarning.Text = ""; }));
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("An SQL Error Occured!\n\nError Code = " + exception);
            }
            finally
            {
                sqlConnection.Close();
            }


            
            try
            {

                //Get Last 14 Persons Who Last Login
                sqlConnection.Open();
                SqlCommand sqlCommandLogin = new SqlCommand("SELECT TOP 14 Tc, Ad, Soyad, SonGiris, Fotograf  FROM  Ogrenci INNER JOIN Kart ON (Ogrenci.Tc = Kart.KartSahibiTc) AND SonGiris IS NOT NULL ORDER BY SonGiris DESC", sqlConnection);

                SqlDataAdapter sqlDataAdapterLogin = new SqlDataAdapter(sqlCommandLogin);
                DataTable dataTableLogin = new DataTable();
                sqlDataAdapterLogin.Fill(dataTableLogin);
                                    
                photo = dataTableLogin.Rows[0][4] == DBNull.Value ? null : (Byte[])dataTableLogin.Rows[0][4];
                MemoryStream memoryStreamLogin = new MemoryStream(photo);
                pictBoxLogin.Image = Image.FromStream(memoryStreamLogin) == null ? Properties.Resources.EducationHouse : Image.FromStream(memoryStreamLogin);
                dataTableLogin.Columns.Remove("Fotograf");
                lblLastLoginNameSurname.BeginInvoke(new Action(delegate () { lblLastLoginNameSurname.Text = (String)dataTableLogin.Rows[0][1] + " " + (String)dataTableLogin.Rows[0][2]; }));
                lblLastLoginTime.BeginInvoke(new Action(delegate () { lblLastLoginTime.Text = dataTableLogin.Rows[0][3].ToString(); }));
                dataGridViewLogin.BeginInvoke(new Action(delegate () { dataGridViewLogin.DataSource = dataTableLogin; }));
                dataGridViewLogin.BeginInvoke(new Action(delegate () { dataGridViewLogin.ClearSelection(); }));

                sqlConnection.Close();
                                   


            }
            catch (Exception exception)
            {
                MessageBox.Show("An SQL Error Occured!\n\nError Code = " + exception);
            }
            finally
            {
                sqlConnection.Close();
            }







            try
            {

                //Get Last 14 Persons Who Last Logout
                sqlConnection.Open();
                SqlCommand sqlCommandLogout = new SqlCommand("SELECT TOP 14 Tc, Ad, Soyad, SonCikis, Fotograf  FROM  Ogrenci INNER JOIN Kart ON (Ogrenci.Tc = Kart.KartSahibiTc) AND SonGiris IS NOT NULL ORDER BY SonCikis DESC", sqlConnection);

                SqlDataAdapter sqlDataAdapterLogout = new SqlDataAdapter(sqlCommandLogout);
                DataTable dataTableLogout = new DataTable();
                sqlDataAdapterLogout.Fill(dataTableLogout);

                photo = dataTableLogout.Rows[0][4] == DBNull.Value ? null : (Byte[])dataTableLogout.Rows[0][4];
                MemoryStream memoryStreamLogout = new MemoryStream(photo);
                pictBoxLogout.Image = Image.FromStream(memoryStreamLogout) == null ? Properties.Resources.EducationHouse : Image.FromStream(memoryStreamLogout);
                dataTableLogout.Columns.Remove("Fotograf");
                lblLastLogoutNameSurname.BeginInvoke(new Action(delegate () { lblLastLogoutNameSurname.Text = (String)dataTableLogout.Rows[0][1] + " " + (String)dataTableLogout.Rows[0][2]; }));
                lblLastLogoutTime.BeginInvoke(new Action(delegate () { lblLastLogoutTime.Text = dataTableLogout.Rows[0][3].ToString(); }));
                dataGridViewLogout.BeginInvoke(new Action(delegate () { dataGridViewLogout.DataSource = dataTableLogout; }));
                dataGridViewLogout.BeginInvoke(new Action(delegate () { dataGridViewLogout.ClearSelection(); }));

                sqlConnection.Close();



            }
            catch (Exception exception)
            {
                MessageBox.Show("An SQL Error Occured!\n\nError Code = " + exception);
            }
            finally
            {
                sqlConnection.Close();
            }






        }

        private void FrmStudentTracking_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }
    }
}
