using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class FrmReceivePayment : Form
    {
        public FrmReceivePayment()
        {
            InitializeComponent();
        }

        //The Database Connection
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HARUN;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void FrmReceivePayment_Load(object sender, EventArgs e)
        {
            //List Student Tc
            sqlConnection.Open();
            SqlCommand commandGetStudentTc = new SqlCommand("SELECT Tc FROM Ogrenci", sqlConnection);
            SqlDataReader dataReaderGetStudentTc = commandGetStudentTc.ExecuteReader();
            while (dataReaderGetStudentTc.Read())
            {
                cBoxStudentTc.Items.Add(dataReaderGetStudentTc[0].ToString());
            }
            sqlConnection.Close();
        }

        private void btnReceivePayment_Click(object sender, EventArgs e)
        {

            this.ActiveControl = cBoxStudentTc;
            this.ActiveControl = mtBoxPaymentAmount;
            this.ActiveControl = btnReceivePayment;


            // Checking For Mandatory Fields
            if (isTheRegistrationValid())
            {

                // Save The Payment
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommandReceivePayment = new SqlCommand("INSERT INTO Odeme(OgrenciTc, Tarih, Miktar) values (@pStudentTc, @pDate, @pPaymentAmount)", sqlConnection);
                    sqlCommandReceivePayment.Parameters.AddWithValue("@pStudentTc", cBoxStudentTc.SelectedItem.ToString().Trim());
                    sqlCommandReceivePayment.Parameters.AddWithValue("@pDate", DateTime.Now.Date);
                    sqlCommandReceivePayment.Parameters.AddWithValue("@pPaymentAmount", Convert.ToInt32(mtBoxPaymentAmount.Text.ToString().Trim()));
                    sqlCommandReceivePayment.ExecuteNonQuery();
                    sqlConnection.Close();


                    sqlConnection.Open();
                    SqlCommand sqlCommandUpdateStudentDept = new SqlCommand("UPDATE Ogrenci SET KalanBorc = KalanBorc - @pPaymentAmount WHERE Tc = @pStudentTc", sqlConnection);
                    sqlCommandUpdateStudentDept.Parameters.AddWithValue("@pStudentTc", cBoxStudentTc.SelectedItem.ToString().Trim());
                    sqlCommandUpdateStudentDept.Parameters.AddWithValue("@pPaymentAmount", Convert.ToInt32(mtBoxPaymentAmount.Text.ToString().Trim()));
                    sqlCommandUpdateStudentDept.ExecuteNonQuery();
                    sqlConnection.Close();


                    MessageBox.Show("Ödeme Alındı.");

                    lblStudentName.Text = "";
                    lblStudentSurname.Text = "";
                    lblRemainDept.Text = "";
                    mtBoxPaymentAmount.Text = "";


                }
                catch (SqlException sqlException)
                {
                    //SQL Exceptions 

                    if (sqlException.Number == 515)
                    {
                        MessageBox.Show("Lütfen zorunlu alanları eksiksiz doldurunuz!");

                    }
                    else if (sqlException.Number == 8178)
                    {
                        MessageBox.Show("A Given Value Isn't Match With Expected Value!");

                    }
                    else if (sqlException.Number == 2627)
                    {
                        MessageBox.Show("Zaten bu TC kimlik numarasıyla kayıtlı bir öğrenci var!\n\nÖğrenci bilgilerini güncellemek için Öğrenci Düzenle formunu kullanabilirsiniz.");
                    }
                    else
                    {
                        MessageBox.Show("An SQL Exception Occoured!\n\nError Code = " + sqlException.Number);
                    }

                }
                catch (Exception exception)
                {
                    //General Exception

                    MessageBox.Show("Öğrenci kaydedilirken bir hata oluştu!" + exception);
                }
                finally
                {
                    sqlConnection.Close();
                }


            }
            else
            {
                //If A Mandatory Field Is Empty Show Message
                MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz!");
            }





        }

        private bool isTheRegistrationValid()
        {
            // The Registration Validation Control (General Validation Control)

            Control[] controls = { cBoxStudentTc, mtBoxPaymentAmount };

            foreach (Control c in controls)
            {

                if (errProvider.GetError(c) != "")
                    return false;
            }
            return true;
        }

        private void cBoxStudentTc_Validating(object sender, CancelEventArgs e)
        {
            //Card No Validating Control
            if (string.IsNullOrEmpty(cBoxStudentTc.Text.Trim()))
            {
                errProvider.SetError(cBoxStudentTc, "TC No boş olamaz!");
            }
            else
            {
                errProvider.SetError(cBoxStudentTc, "");
            }
        }

        private void mtBoxPaymentAmount_Validating(object sender, CancelEventArgs e)
        {
            //Payment Amount Validating Control
            if (string.IsNullOrEmpty(mtBoxPaymentAmount.Text.Trim()))
            {
                errProvider.SetError(mtBoxPaymentAmount, "Ödeme Miktarı boş olamaz!");
            }
            else if (Convert.ToInt32(lblRemainDept.Text) < Convert.ToInt32(mtBoxPaymentAmount.Text.ToString().Trim()))
            {
                MessageBox.Show("Ödeme miktarı kalan borçtan büyük olamaz!");
                mtBoxPaymentAmount.Clear();
            }
            else
            {
                errProvider.SetError(mtBoxPaymentAmount, "");
            }
        }

        private void cBoxStudentTc_SelectedValueChanged(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommandGetStudentInformations = new SqlCommand("SELECT Ad, Soyad, KalanBorc FROM Ogrenci WHERE Tc = @pTc", sqlConnection);
            sqlCommandGetStudentInformations.Parameters.AddWithValue("@pTc", cBoxStudentTc.SelectedItem.ToString());
            SqlDataReader sqlDataReaderGetStudentInformations = sqlCommandGetStudentInformations.ExecuteReader();
            while (sqlDataReaderGetStudentInformations.Read())
            {
                lblStudentName.Text = sqlDataReaderGetStudentInformations[0].ToString();
                lblStudentSurname.Text = sqlDataReaderGetStudentInformations[1].ToString();
                lblRemainDept.Text = sqlDataReaderGetStudentInformations[2].ToString();
            }
            sqlConnection.Close();
        }
    }
}
