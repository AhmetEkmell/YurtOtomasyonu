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
    public partial class FrmAdminOperations : Form
    {
        public FrmAdminOperations()
        {
            InitializeComponent();
        }

        Boolean isLastAdmin;
        

        //The Database Connection
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HARUN;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void FrmAdminOperations_Load(object sender, EventArgs e)
        {
            refreshTcBoxs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            this.ActiveControl = cBoxSaveEmployeeTc;
            this.ActiveControl = tBoxSaveEmployeeUsername;
            this.ActiveControl = tBoxSaveEmployeePassword;



            // Checking For Mandatory Fields
            if (isTheRegistrationValidSave())
            {

                // Save The Admin
                try
                {

                    sqlConnection.Open();
                    SqlCommand sqlCommandSaveAdmin = new SqlCommand("INSERT INTO Yonetici(personelTc, KullaniciAd, Sifre) Values (@pEmployeeTc,  @pEmployeeUsername, @pEmployeePassword) ", sqlConnection);
                    sqlCommandSaveAdmin.Parameters.AddWithValue("@pEmployeeTc", cBoxSaveEmployeeTc.SelectedItem);
                    sqlCommandSaveAdmin.Parameters.AddWithValue("@pEmployeeUsername", tBoxSaveEmployeeUsername.Text);
                    sqlCommandSaveAdmin.Parameters.AddWithValue("@pEmployeePassword", tBoxSaveEmployeePassword.Text);
                    sqlCommandSaveAdmin.ExecuteNonQuery();
                    sqlConnection.Close();

                    MessageBox.Show("Yönetici Kaydedildi");

                    refreshTcBoxs();

                    tBoxSaveEmployeeName.Clear();
                    tBoxSaveEmployeeSurname.Clear();
                    tBoxSaveEmployeeUsername.Clear();
                    tBoxSaveEmployeePassword.Clear();


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
                        MessageBox.Show("Zaten bu kullanıcı adıyla kayıtlı bir yönetici var!\n\nYönetici bilgilerini güncellemek için Yönetici Düzenle kısmını kullanabilirsiniz.");
                    }
                    else
                    {
                        MessageBox.Show("An SQL Exception Occoured!\n\nError Code = " + sqlException.Number);
                    }

                }
                catch (Exception exception)
                {
                    //General Exception

                    MessageBox.Show("Yönetici kaydedilirken bir hata oluştu!" + exception);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            this.ActiveControl = cBoxUpdateEmployeeTc;
            this.ActiveControl = tBoxUpdateEmployeeName;
            this.ActiveControl = tBoxUpdateEmployeeSurname;
            this.ActiveControl = tBoxUpdateEmployeeUsername;
            this.ActiveControl = tBoxUpdateEmployeePassword;

            // Checking For Mandatory Fields
            if (isTheRegistrationValidUpdate())
            {

                // Edit The Admin
                try
                {

                    sqlConnection.Open();
                    SqlCommand sqlCommandEditEmployee = new SqlCommand("UPDATE Yonetici SET KullaniciAd = @pUsername, Sifre = @pPassword WHERE personelTc = @pTc", sqlConnection);
                    sqlCommandEditEmployee.Parameters.AddWithValue("@pTc", cBoxUpdateEmployeeTc.SelectedItem);
                    sqlCommandEditEmployee.Parameters.AddWithValue("@pUsername", tBoxUpdateEmployeeUsername.Text.Trim());
                    sqlCommandEditEmployee.Parameters.AddWithValue("@pPassword", tBoxUpdateEmployeePassword.Text.Trim());
                    sqlCommandEditEmployee.ExecuteNonQuery();
                    sqlConnection.Close();

                    MessageBox.Show("Yönetici Bilgileri Güncellendi");

                    refreshTcBoxs();

                    tBoxUpdateEmployeeName.Clear();
                    tBoxUpdateEmployeeSurname.Clear();
                    tBoxUpdateEmployeeUsername.Clear();
                    tBoxUpdateEmployeePassword.Clear();

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
                        MessageBox.Show("Zaten bu TC kimlik numarasıyla kayıtlı bir personel var!\n\nPersonel bilgilerini güncellemek için Personel Düzenle butonunu kullanabilirsiniz.");
                    }
                    else
                    {
                        MessageBox.Show("An SQL Exception Occoured!\n\nError Code = " + sqlException.Number);
                    }

                }
                catch (Exception exception)
                {
                    //General Exception

                    MessageBox.Show("personel bilgileri düzenlenirken bir hata oluştu!" + exception);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            this.ActiveControl = cBoxDeleteEmployeeTc;
            this.ActiveControl = tBoxDeleteEmployeeName;
            this.ActiveControl = tBoxDeleteEmployeeSurname;
            this.ActiveControl = tBoxDeleteEmployeeUsername;
            this.ActiveControl = tBoxDeleteEmployeePassword;

            // Checking For Mandatory Fields
            if (isTheRegistrationValidUpdate())
            {

                sqlConnection.Open();
                SqlCommand sqlCommandGetAdminCount = new SqlCommand("SELECT COUNT(KullaniciAd) FROM Yonetici", sqlConnection);
                isLastAdmin = Convert.ToInt16(sqlCommandGetAdminCount.ExecuteScalar()) <= 1 ? true : false;
                sqlConnection.Close();



                if (!isLastAdmin)
                {


                    // Delete The Admin
                    try
                    {

                        sqlConnection.Open();
                        SqlCommand sqlCommandEditEmployee = new SqlCommand("DELETE FROM Yonetici WHERE KullaniciAd = @pUsername AND Sifre = @pPassword AND personelTc = @pTc", sqlConnection);
                        sqlCommandEditEmployee.Parameters.AddWithValue("@pTc", cBoxDeleteEmployeeTc.SelectedItem);
                        sqlCommandEditEmployee.Parameters.AddWithValue("@pUsername", tBoxDeleteEmployeeUsername.Text.Trim());
                        sqlCommandEditEmployee.Parameters.AddWithValue("@pPassword", tBoxDeleteEmployeePassword.Text.Trim());
                        sqlCommandEditEmployee.ExecuteNonQuery();
                        sqlConnection.Close();

                        MessageBox.Show("Yönetici Silindi");

                        refreshTcBoxs();

                        tBoxDeleteEmployeeName.Clear();
                        tBoxDeleteEmployeeSurname.Clear();
                        tBoxDeleteEmployeeUsername.Clear();
                        tBoxDeleteEmployeePassword.Clear();

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
                            MessageBox.Show("Zaten bu TC kimlik numarasıyla kayıtlı bir personel var!\n\nPersonel bilgilerini güncellemek için Personel Düzenle butonunu kullanabilirsiniz.");
                        }
                        else
                        {
                            MessageBox.Show("An SQL Exception Occoured!\n\nError Code = " + sqlException.Number);
                        }

                    }
                    catch (Exception exception)
                    {
                        //General Exception

                        MessageBox.Show("personel bilgileri düzenlenirken bir hata oluştu!" + exception);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }




                }
                else
                {
                    MessageBox.Show("Yönetici silinemedi!\n\nSisteme giriş yapmak için en az 1 yönetici olmalıdır!");
                }

            }
            else
            {
                //If A Mandatory Field Is Empty Show Message
                MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz!");
            }







































        }

        private void cBoxEmployeeTc_SelectedValueChanged(object sender, EventArgs e)
        {

            sqlConnection.Open();
            SqlCommand sqlCommandGetEmployeeInformations = new SqlCommand("SELECT Ad, Soyad FROM PERSONEL WHERE Tc = @pTc", sqlConnection);
            sqlCommandGetEmployeeInformations.Parameters.AddWithValue("@pTc", cBoxSaveEmployeeTc.SelectedItem.ToString().Trim());
            SqlDataReader sqlDataReaderGetEmployeeInformations = sqlCommandGetEmployeeInformations.ExecuteReader();
            while (sqlDataReaderGetEmployeeInformations.Read())
            {
                tBoxSaveEmployeeName.Text = sqlDataReaderGetEmployeeInformations[0].ToString();
                tBoxSaveEmployeeSurname.Text = sqlDataReaderGetEmployeeInformations[1].ToString();
            }

            sqlConnection.Close();



        }

        private void cBoxUpdateEmployeeTc_SelectedValueChanged(object sender, EventArgs e)
        {

            sqlConnection.Open();
            SqlCommand sqlCommandUpdateGetEmployeeInformations = new SqlCommand("SELECT Ad, Soyad, KullaniciAd, Sifre FROM Personel INNER JOIN Yonetici ON personelTc = @pTc AND Tc = @pTc", sqlConnection);
            sqlCommandUpdateGetEmployeeInformations.Parameters.AddWithValue("@pTc", cBoxUpdateEmployeeTc.SelectedItem.ToString().Trim());
            SqlDataReader sqlDataReaderUpdateGetEmployeeInformations = sqlCommandUpdateGetEmployeeInformations.ExecuteReader();
            while (sqlDataReaderUpdateGetEmployeeInformations.Read())
            {
                tBoxUpdateEmployeeName.Text = sqlDataReaderUpdateGetEmployeeInformations[0].ToString();
                tBoxUpdateEmployeeSurname.Text = sqlDataReaderUpdateGetEmployeeInformations[1].ToString();
                tBoxUpdateEmployeeUsername.Text = sqlDataReaderUpdateGetEmployeeInformations[2].ToString();
                tBoxUpdateEmployeePassword.Text = sqlDataReaderUpdateGetEmployeeInformations[3].ToString();
            }

            sqlConnection.Close();
        }

        private void cBoxDeleteEmployeeTc_SelectedValueChanged(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommandDeleteGetEmployeeInformations = new SqlCommand("SELECT Ad, Soyad, KullaniciAd, Sifre FROM PERSONEL INNER JOIN Yonetici ON personelTc = @pTc AND Tc = @pTc", sqlConnection);
            sqlCommandDeleteGetEmployeeInformations.Parameters.AddWithValue("@pTc", cBoxDeleteEmployeeTc.SelectedItem.ToString().Trim());
            SqlDataReader sqlDataReaderDeleteGetEmployeeInformations = sqlCommandDeleteGetEmployeeInformations.ExecuteReader();
            while (sqlDataReaderDeleteGetEmployeeInformations.Read())
            {
                tBoxDeleteEmployeeName.Text = sqlDataReaderDeleteGetEmployeeInformations[0].ToString();
                tBoxDeleteEmployeeSurname.Text = sqlDataReaderDeleteGetEmployeeInformations[1].ToString();
                tBoxDeleteEmployeeUsername.Text = sqlDataReaderDeleteGetEmployeeInformations[2].ToString();
                tBoxDeleteEmployeePassword.Text = sqlDataReaderDeleteGetEmployeeInformations[3].ToString();
            }

            sqlConnection.Close();
        }

        private void cBoxEmployeeTc_Validating(object sender, CancelEventArgs e)
        {

            //Employee Tc Validating Control
            if (string.IsNullOrEmpty(cBoxSaveEmployeeTc.Text.Trim()))
            {
                errProvider.SetError(cBoxSaveEmployeeTc, "Personel Tc boş olamaz!");
            }
            else
            {
                errProvider.SetError(cBoxSaveEmployeeTc, "");
            }
        }

        private void tBoxEmployeeUsername_Validating(object sender, CancelEventArgs e)
        {
            //Username Validating Control
            if (string.IsNullOrEmpty(tBoxSaveEmployeeUsername.Text.Trim()))
            {
                errProvider.SetError(tBoxSaveEmployeeUsername, "Kullanıcı adı boş olamaz!");
            }
            else
            {
                errProvider.SetError(tBoxSaveEmployeeUsername, "");
            }
        }

        private void tBoxEmployeePassword_Validating(object sender, CancelEventArgs e)
        {
            //Password Validating Control
            if (string.IsNullOrEmpty(tBoxSaveEmployeePassword.Text.Trim()))
            {
                errProvider.SetError(tBoxSaveEmployeePassword, "Şifre boş olamaz!");
            }
            else
            {
                errProvider.SetError(tBoxSaveEmployeePassword, "");
            }
        }

        private void cBoxUpdateEmployeeTc_Validating(object sender, CancelEventArgs e)
        {
            //Admin Tc Validating Control
            if (string.IsNullOrEmpty(cBoxUpdateEmployeeTc.Text.Trim()))
            {
                errProvider.SetError(cBoxUpdateEmployeeTc, "Personel Tc boş olamaz!");
            }
            else
            {
                errProvider.SetError(cBoxUpdateEmployeeTc, "");
            }

        }

        private void tBoxUpdateEmployeeUsername_Validating(object sender, CancelEventArgs e)
        {
            //Username Validating Control
            if (string.IsNullOrEmpty(tBoxUpdateEmployeeUsername.Text.Trim()))
            {
                errProvider.SetError(tBoxUpdateEmployeeUsername, "Kullanıcı adı boş olamaz!");
            }
            else
            {
                errProvider.SetError(tBoxUpdateEmployeeUsername, "");
            }
        }

        private void tBoxUpdateEmployeePassword_Validating(object sender, CancelEventArgs e)
        {
            //Password Validating Control
            if (string.IsNullOrEmpty(tBoxUpdateEmployeePassword.Text.Trim()))
            {
                errProvider.SetError(tBoxUpdateEmployeePassword, "Şifre boş olamaz!");
            }
            else
            {
                errProvider.SetError(tBoxUpdateEmployeePassword, "");
            }
        }

        private bool isTheRegistrationValidSave()
        {
            // The Registration Validation Control (General Validation Control)

            Control[] controls = { cBoxSaveEmployeeTc, tBoxSaveEmployeeUsername, tBoxSaveEmployeePassword  };

            foreach (Control c in controls)
            {

                if (errProvider.GetError(c) != "")
                    return false;
            }
            return true;
        }

        private bool isTheRegistrationValidUpdate()
        {
            // The Registration Validation Control (General Validation Control)

            Control[] controls = { cBoxUpdateEmployeeTc, tBoxUpdateEmployeeUsername, tBoxUpdateEmployeePassword };

            foreach (Control c in controls)
            {

                if (errProvider.GetError(c) != "")
                    return false;
            }
            return true;
        }

        private bool isTheRegistrationValidDelete()
        {
            // The Registration Validation Control (General Validation Control)

            Control[] controls = { cBoxDeleteEmployeeTc };

            foreach (Control c in controls)
            {

                if (errProvider.GetError(c) != "")
                    return false;
            }
            return true;
        }

        private void refreshTcBoxs()
        {

            //List Employee' Tc
            cBoxSaveEmployeeTc.Items.Clear();

            sqlConnection.Open();
            SqlCommand sqlCommandSaveGetEmployyeTc = new SqlCommand("SELECT Tc FROM Personel WHERE NOT EXISTS (SELECT 1 FROM Yonetici WHERE personelTc = Personel.Tc) ", sqlConnection);
            SqlDataReader dataReaderSaveGetEmployeeTc = sqlCommandSaveGetEmployyeTc.ExecuteReader();
            while (dataReaderSaveGetEmployeeTc.Read())
            {
                cBoxSaveEmployeeTc.Items.Add(dataReaderSaveGetEmployeeTc[0].ToString());
            }
            sqlConnection.Close();


            //List Employee' Tc
            cBoxUpdateEmployeeTc.Items.Clear();

            sqlConnection.Open();
            SqlCommand sqlCommandUpdateGetEmployyeTc = new SqlCommand("SELECT Tc FROM Personel WHERE EXISTS (SELECT 1 FROM Yonetici WHERE personelTc = Personel.Tc) ", sqlConnection);
            SqlDataReader dataReaderUpdateGetEmployeeTc = sqlCommandUpdateGetEmployyeTc.ExecuteReader();
            while (dataReaderUpdateGetEmployeeTc.Read())
            {
                cBoxUpdateEmployeeTc.Items.Add(dataReaderUpdateGetEmployeeTc[0].ToString());
            }
            sqlConnection.Close();




            //List Employee' Tc
            cBoxDeleteEmployeeTc.Items.Clear();

            sqlConnection.Open();
            SqlCommand sqlCommandDeleteGetEmployyeTc = new SqlCommand("SELECT Tc FROM Personel WHERE EXISTS (SELECT 1 FROM Yonetici WHERE personelTc = Personel.Tc) ", sqlConnection);
            SqlDataReader dataReaderDeleteGetEmployeeTc = sqlCommandDeleteGetEmployyeTc.ExecuteReader();
            while (dataReaderDeleteGetEmployeeTc.Read())
            {
                cBoxDeleteEmployeeTc.Items.Add(dataReaderDeleteGetEmployeeTc[0].ToString());
            }
            sqlConnection.Close();


        }

        private void cBoxDeleteEmployeeTc_Validating(object sender, CancelEventArgs e)
        {
            //Admin Tc Validating Control
            if (string.IsNullOrEmpty(cBoxDeleteEmployeeTc.Text.Trim()))
            {
                errProvider.SetError(cBoxDeleteEmployeeTc, "Personel Tc boş olamaz!");
            }
            else
            {
                errProvider.SetError(cBoxDeleteEmployeeTc, "");
            }
        }
    }
}
