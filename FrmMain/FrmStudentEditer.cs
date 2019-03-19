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
    public partial class FrmStudentEditer : Form
    {
        public FrmStudentEditer()
        {
            InitializeComponent();
        }


        //The Database Connection
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HARUN;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        String tempTc;
        String oldCardNo;
        String oldRoomNumber;
        byte[] photo = null;

        private void FrmStudentEditer_Load(object sender, EventArgs e)
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

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {

            String imageLocation;

            try
            {
                //Select Photo From Disk And Place To The PictureBox.
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "all files(*.*)| *.*|png Files(*.png)|*.png|jpg Files(*.jpg)|*.jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName.ToString();
                    picBoxPhoto.ImageLocation = imageLocation;

                    FileStream fileStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    photo = binaryReader.ReadBytes((int)fileStream.Length);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Fotoğraf seçilirken bir hata oluştu!");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Checking For Mandatory Fields
            if (isTheRegistrationValid())
            {

                // Edit The Student
                try
                {
                    sqlConnection.Open();
                    SqlCommand commandSave = new SqlCommand("UPDATE Ogrenci SET Tc = @pTc, Ad = @pAd, Soyad = @pSoyad, DogumTarihi = @pDogumTarihi, Fotograf = @pFotograf, Telefon = @pTelefon, Mail = @pMail, BolumId = (SELECT Id FROM Bolum WHERE Ad = @pBolumAd), OdaNo = @pOdaNo, VeliAd = @pVeliAd, VeliSoyad = @pVeliSoyad, VeliTelefon = @pVeliTelefon, VeliAdres = @pVeliAdres WHERE Tc = @pTc", sqlConnection);
                    commandSave.Parameters.AddWithValue("@pTc", mtBoxTc.Text.Trim().Length == 0 ? DBNull.Value : (Object)mtBoxTc.Text);
                    commandSave.Parameters.AddWithValue("@pAd", tBoxName.Text.Trim().Length == 0 ? DBNull.Value : (Object)tBoxName.Text);
                    commandSave.Parameters.AddWithValue("@pSoyad", tBoxSurname.Text.Trim().Length == 0 ? DBNull.Value : (Object)tBoxSurname.Text);
                    commandSave.Parameters.AddWithValue("@pDogumTarihi", dTPickerDateOfBirth.Text.ToString().Trim().Length == 0 ? DBNull.Value : (Object)dTPickerDateOfBirth.Value.ToString("yyyy-MM-dd"));
                    commandSave.Parameters.AddWithValue("@pFotograf", photo == null ? DBNull.Value : (Object)photo).SqlDbType = SqlDbType.Image;
                    commandSave.Parameters.AddWithValue("@pTelefon", Regex.Replace(mtBoxPhoneNumber.Text, "[^0-9]", "").Trim().Length == 0 ? DBNull.Value : (Object)mtBoxPhoneNumber.Text);
                    commandSave.Parameters.AddWithValue("@pMail", tBoxMail.Text.Trim().Length == 0 ? DBNull.Value : (Object)tBoxMail.Text);
                    commandSave.Parameters.AddWithValue("@pBolumAd", cBoxDepartment.Text.Trim().Length == 0 ? DBNull.Value : (Object)cBoxDepartment.Text);
                    commandSave.Parameters.AddWithValue("@pOdaNo", cBoxRoomNumber.Text.Trim().Length == 0 ? DBNull.Value : (Object)cBoxRoomNumber.Text);
                    commandSave.Parameters.AddWithValue("@pVeliAd", tBoxParentName.Text.Trim().Length == 0 ? DBNull.Value : (Object)tBoxParentName.Text);
                    commandSave.Parameters.AddWithValue("@pVeliSoyad", tBoxParentSurname.Text.Trim().Length == 0 ? DBNull.Value : (Object)tBoxParentSurname.Text);
                    commandSave.Parameters.AddWithValue("@pVeliTelefon", Regex.Replace(mtBoxParentPhoneNumber.Text, "[^0-9]", "").Trim().Length == 0 ? DBNull.Value : (Object)mtBoxParentPhoneNumber.Text);
                    commandSave.Parameters.AddWithValue("@pVeliAdres", rTBoxParentAddress.Text.Trim().Length == 0 ? DBNull.Value : (Object)rTBoxParentAddress.Text);
                    commandSave.ExecuteNonQuery();
                    sqlConnection.Close();

                    //Update Old Card Owner Informations
                    sqlConnection.Open();
                    SqlCommand sqlCommandReleaseOldCard = new SqlCommand("UPDATE Kart SET KartSahibiTc = NULL, SonGiris = NULL, SonCikis = NULL WHERE KartNo = @pOldCardNo ", sqlConnection);
                    sqlCommandReleaseOldCard.Parameters.AddWithValue("@pOldCardNo", (Object)oldCardNo);
                    sqlCommandReleaseOldCard.ExecuteNonQuery();
                    sqlConnection.Close();

                    //Update New Card Owner Informations
                    sqlConnection.Open();
                    SqlCommand sqlCommandAddFirstAction = new SqlCommand("UPDATE Kart SET KartSahibiTc = @pKartSahibiTc, SonCikis = @pSonCikis, SonGiris = @pSonGiris  WHERE KartNo = @pKartNo", sqlConnection);
                    sqlCommandAddFirstAction.Parameters.AddWithValue("@pKartNo", cBoxCardNo.Text);
                    sqlCommandAddFirstAction.Parameters.AddWithValue("@pKartSahibiTc", mtBoxTc.Text.Trim().Length == 0 ? DBNull.Value : (Object)mtBoxTc.Text);
                    sqlCommandAddFirstAction.Parameters.AddWithValue("@pSonCikis", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    sqlCommandAddFirstAction.Parameters.AddWithValue("@pSonGiris", DateTime.Now.AddMinutes(1).ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    sqlCommandAddFirstAction.ExecuteNonQuery();
                    sqlConnection.Close();

                    sqlConnection.Open();
                    SqlCommand sqlCommandUpdateOldRoomNumber = new SqlCommand("UPDATE Oda SET Mevcut = Mevcut-1 WHERE No = @pOldRoomNumber", sqlConnection);
                    sqlCommandUpdateOldRoomNumber.Parameters.AddWithValue("@pOldRoomNumber", oldRoomNumber);
                    sqlCommandUpdateOldRoomNumber.ExecuteNonQuery();
                    sqlConnection.Close();


                    sqlConnection.Open();
                    SqlCommand sqlCommandUpdateNewRoomNumber = new SqlCommand("UPDATE Oda SET Mevcut = Mevcut+1 WHERE No = @pNewRoomNumber", sqlConnection);
                    sqlCommandUpdateNewRoomNumber.Parameters.AddWithValue("@pNewRoomNumber", cBoxRoomNumber.Text.Trim());
                    sqlCommandUpdateNewRoomNumber.ExecuteNonQuery();
                    sqlConnection.Close();



                    MessageBox.Show("Öğrenci Bilgileri Güncellendi");

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

                        oldRoomNumber = cBoxRoomNumber.SelectedItem.ToString();

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

        private void tBoxName_Validating(object sender, CancelEventArgs e)
        {
            //Name Validating Control
            if (string.IsNullOrEmpty(tBoxName.Text.Trim()))
            {
                errProvider.SetError(tBoxName, "Ad boş olamaz!");
            }
            else
            {
                errProvider.SetError(tBoxName, "");
            }

        }

        private void tBoxSurname_Validating(object sender, CancelEventArgs e)
        {
            //Surname Validating Control
            if (string.IsNullOrEmpty(tBoxSurname.Text.Trim()))
            {
                errProvider.SetError(tBoxSurname, "Soyad boş olamaz!");
            }
            else
            {
                errProvider.SetError(tBoxSurname, "");
            }
        }

        private void dTPickerDateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            //Date Of Birth Validating Control
            if (string.IsNullOrEmpty(dTPickerDateOfBirth.Text.Trim()))
            {
                errProvider.SetError(dTPickerDateOfBirth, "Doğum Tarihi boş olamaz!");
            }
            else
            {
                errProvider.SetError(dTPickerDateOfBirth, "");
            }
        }

        private void cBoxDepartment_Validating(object sender, CancelEventArgs e)
        {
            //Department Validating Control
            if (string.IsNullOrEmpty(cBoxDepartment.Text.Trim()))
            {
                errProvider.SetError(cBoxDepartment, "Bölüm boş olamaz!");
            }
            else
            {
                errProvider.SetError(cBoxDepartment, "");
            }
        }

        private void cBoxRoomNumber_Validating(object sender, CancelEventArgs e)
        {
            //Room Number Validating Control
            if (string.IsNullOrEmpty(cBoxRoomNumber.Text.Trim()))
            {
                errProvider.SetError(cBoxRoomNumber, "Oda No boş olamaz!");
            }
            else
            {
                errProvider.SetError(cBoxRoomNumber, "");
            }
        }

        private void cBoxCardNo_Validating(object sender, CancelEventArgs e)
        {
            //Card No Validating Control
            if (string.IsNullOrEmpty(cBoxCardNo.Text.Trim()))
            {
                errProvider.SetError(cBoxCardNo, "Kart No boş olamaz!");
            }
            else
            {
                errProvider.SetError(cBoxCardNo, "");
            }
        }

        private void btnSelectPhoto_Validating(object sender, CancelEventArgs e)
        {
            if (photo == null)
            {
                errProvider.SetError(picBoxPhoto, "Fotoğraf boş olamaz!");
            }
            else
            {
                errProvider.SetError(picBoxPhoto, "");
            }
        }

        private bool isTheRegistrationValid()
        {
            // The Registration Validation Control (General Validation Control)

            Control[] controls = { mtBoxTc, tBoxName, tBoxSurname, dTPickerDateOfBirth, cBoxDepartment, cBoxRoomNumber, cBoxCardNo, btnSelectPhoto};

            foreach (Control c in controls)
            {

                if (errProvider.GetError(c) != "")
                    return false;
            }
            return true;
        }


       
       

       
      
    }
}
