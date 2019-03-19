using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class FrmStudentDeleting : Form
    {
        public FrmStudentDeleting()
        {
            InitializeComponent();
        }

        String tempTc;
        String oldCardNo;
        byte[] photo = null;

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HARUN;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void FrmStudentDeleting_Load(object sender, EventArgs e)
        {

            //List Empty Rooms
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT No FROM Oda", sqlConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cBoxRoomNumber.Items.Add(dataReader[0].ToString());
            }
            sqlConnection.Close();

            //List Departments
            sqlConnection.Open();
            SqlCommand command2 = new SqlCommand("SELECT Ad FROM Bolum", sqlConnection);
            SqlDataReader dataReader2 = command2.ExecuteReader();
            while (dataReader2.Read())
            {
                cBoxDepartment.Items.Add(dataReader2[0].ToString());
            }
            sqlConnection.Close();


            //List Empty Cards
            sqlConnection.Open();
            SqlCommand commandGetCard = new SqlCommand("SELECT KartNo FROM Kart WHERE KartSahibiTc IS NULL", sqlConnection);
            SqlDataReader dataReaderGetCard = commandGetCard.ExecuteReader();
            while (dataReaderGetCard.Read())
            {
                cBoxCardNo.Items.Add(dataReaderGetCard[0].ToString());
            }
            sqlConnection.Close();


            //Focus The mtBoxTc While Form Is Loaded
            dTPickerDateOfBirth.Value = DateTime.Now.Date;
            this.ActiveControl = mtBoxTc;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.ActiveControl = mtBoxTc;

            // Checking For Mandatory Fields
            if (isTheRegistrationValid())
            {

                // Delete The Student
                try
                {
                    sqlConnection.Open();
                    SqlCommand commandSave = new SqlCommand("DELETE FROM Ogrenci WHERE Tc = @pTc", sqlConnection);
                    commandSave.Parameters.AddWithValue("@pTc", mtBoxTc.Text.Trim());
                    commandSave.ExecuteNonQuery();
                    sqlConnection.Close();

                    //Update Old Card Owner Informations
                    sqlConnection.Open();
                    SqlCommand sqlCommandReleaseOldCard = new SqlCommand("UPDATE Kart SET KartSahibiTc = NULL, SonGiris = NULL, SonCikis = NULL WHERE KartNo = @pOldCardNo ", sqlConnection);
                    sqlCommandReleaseOldCard.Parameters.AddWithValue("@pOldCardNo", (Object)oldCardNo);
                    sqlCommandReleaseOldCard.ExecuteNonQuery();
                    sqlConnection.Close();

                    //Update Old Room Number Available
                    sqlConnection.Open();
                    SqlCommand sqlCommandUpdateOldRoomNumber = new SqlCommand("UPDATE Oda SET Mevcut = Mevcut-1 WHERE No = @pOldRoomNumber", sqlConnection);
                    sqlCommandUpdateOldRoomNumber.Parameters.AddWithValue("@pOldRoomNumber", cBoxRoomNumber.SelectedItem.ToString());
                    sqlCommandUpdateOldRoomNumber.ExecuteNonQuery();
                    sqlConnection.Close();

                    MessageBox.Show("Öğrenci silindi.");

                    this.Close();

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
                    this.Close();
                }


            }
            else
            {
                //If A Mandatory Field Is Empty Show Message
                MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz!");
            }




        }

        private void mtBoxTc_TextChanged(object sender, EventArgs e)
        {
            if (mtBoxTc.Text.Trim().Length == 11)
            {

                try
                {


                    sqlConnection.Open();
                    SqlCommand sqlCommandGetStudent = new SqlCommand("SELECT Ad, Soyad, DogumTarihi, Telefon, Mail, (SELECT Ad FROM Bolum WHERE Id = BolumId), OdaNo, (SELECT KartNo FROM Kart WHERE KartSahibiTc = @pTc), VeliAd, VeliSoyad, VeliTelefon, VeliAdres, Fotograf FROM Ogrenci WHERE Tc = @pTc", sqlConnection);
                    sqlCommandGetStudent.Parameters.AddWithValue("@pTc", mtBoxTc.Text.Trim());

                    SqlDataAdapter sqlDataAdapterGetStudent = new SqlDataAdapter(sqlCommandGetStudent);
                    DataTable dataTableGetStudent = new DataTable();
                    sqlDataAdapterGetStudent.Fill(dataTableGetStudent);

                    if (dataTableGetStudent.Rows.Count != 0)
                    {

                        tempTc = mtBoxTc.Text.Trim();

                        cBoxCardNo.Items.Add(dataTableGetStudent.Rows[0][7].ToString());
                        oldCardNo = dataTableGetStudent.Rows[0][7].ToString();

                        tBoxName.Text = (String)dataTableGetStudent.Rows[0][0];
                        tBoxSurname.Text = (String)dataTableGetStudent.Rows[0][1];
                        dTPickerDateOfBirth.Value = (DateTime)dataTableGetStudent.Rows[0][2];
                        mtBoxPhoneNumber.Text = dataTableGetStudent.Rows[0][3] == DBNull.Value ? "" : (String)dataTableGetStudent.Rows[0][3];
                        tBoxMail.Text = dataTableGetStudent.Rows[0][4] == DBNull.Value ? "" : (String)dataTableGetStudent.Rows[0][4];
                        cBoxDepartment.SelectedItem = dataTableGetStudent.Rows[0][5].ToString().Trim();
                        cBoxRoomNumber.SelectedItem = dataTableGetStudent.Rows[0][6].ToString();
                        cBoxCardNo.SelectedItem = dataTableGetStudent.Rows[0][7].ToString();
                        tBoxParentName.Text = dataTableGetStudent.Rows[0][8] == DBNull.Value ? "" : (String)dataTableGetStudent.Rows[0][8];
                        tBoxParentSurname.Text = dataTableGetStudent.Rows[0][9] == DBNull.Value ? "" : (String)dataTableGetStudent.Rows[0][9];
                        mtBoxParentPhoneNumber.Text = dataTableGetStudent.Rows[0][10] == DBNull.Value ? "" : (String)dataTableGetStudent.Rows[0][10];
                        rTBoxParentAddress.Text = dataTableGetStudent.Rows[0][11] == DBNull.Value ? "" : (String)dataTableGetStudent.Rows[0][11];

                        photo = (Byte[])dataTableGetStudent.Rows[0][12];
                        picBoxPhoto.Image = dataTableGetStudent.Rows[0][12] == DBNull.Value ? Properties.Resources.EducationHouse : Image.FromStream(new MemoryStream(photo));

                        sqlConnection.Close();

                    }
                    else
                    {
                        MessageBox.Show("Girilen TC kimlik numarasına kayıtlı öğrenci bulunamadı!");
                        sqlConnection.Close();
                        mtBoxTc.Text = tempTc;
                    }


                }
                catch (Exception sqlException)
                {
                    MessageBox.Show("An SQL Exception Occoured!\n\nError Code = " + sqlException);
                }
                finally
                {
                    sqlConnection.Close();
                }


            }
        }

        private void mtBoxTc_Validating(object sender, CancelEventArgs e)
        {
            //TC No Validating Control
            if (string.IsNullOrEmpty(mtBoxTc.Text.Trim()))
            {
                errProvider.SetError(mtBoxTc, "TC No boş olamaz!");
            }
            else if (mtBoxTc.Text.Trim().Length < 11)
            {
                errProvider.SetError(mtBoxTc, "TC No geçersiz!");
            }
            else
            {
                errProvider.SetError(mtBoxTc, "");
            }
        }


        private bool isTheRegistrationValid()
        {
            // The Registration Validation Control (General Validation Control)

            Control[] controls = { mtBoxTc };

            foreach (Control c in controls)
            {

                if (errProvider.GetError(c) != "")
                    return false;
            }
            return true;
        }

        
    }
}
