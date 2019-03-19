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
    public partial class FrmAdmin : Form
    {

        //The Database Connection
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HARUN;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        Boolean isAdmin;
        String username;

        public FrmAdmin()
        {
            InitializeComponent();
        }


       

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tBoxUserName;
        }

        private void tBoxUserName_Validating(object sender, CancelEventArgs e)
        {
            //Username Validating Control
            if (string.IsNullOrEmpty(tBoxUserName.Text.Trim()))
            {
                errProvider.SetError(tBoxUserName, "Kullanıcı adı boş olamaz!");
            }
            else
            {
                errProvider.SetError(tBoxUserName, "");
            }
        }

        private void tBoxPassword_Validated(object sender, EventArgs e)
        {
            //Password Validating Control
            if (string.IsNullOrEmpty(tBoxPassword.Text.Trim()))
            {
                errProvider.SetError(tBoxPassword, "Şifre boş olamaz!");
            }
            else
            {
                errProvider.SetError(tBoxPassword, "");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.ActiveControl = tBoxPassword;

            // Checking For Mandatory Fields
            if (isTheRegistrationValid())
            {

                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommandIsAdmin = new SqlCommand("SELECT CASE WHEN EXISTS(SELECT personelTc FROM Yonetici WHERE KullaniciAd = @pUsername COLLATE SQL_Latin1_General_CP1_CS_AS AND Sifre = @pPassword COLLATE SQL_Latin1_General_CP1_CS_AS) THEN 'YES' ELSE 'NO' END ", sqlConnection);
                    sqlCommandIsAdmin.Parameters.AddWithValue("@pUsername", tBoxUserName.Text.Trim());
                    sqlCommandIsAdmin.Parameters.AddWithValue("@pPassword", tBoxPassword.Text.Trim());
                    isAdmin = (String)sqlCommandIsAdmin.ExecuteScalar() == "YES" ? true : false;
                    sqlConnection.Close();

                    if (isAdmin)
                    {
                            username = tBoxUserName.Text;

                            this.Hide();
                            FrmMain frmMain = new FrmMain(username);
                            frmMain.ShowDialog();
                            this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre yanlış!");
                        lblUsername.ForeColor = Color.Red;
                        lblPassword.ForeColor = Color.Red;

                    }
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

            Control[] controls = { tBoxUserName, tBoxPassword };

            foreach (Control c in controls)
            {

                if (errProvider.GetError(c) != "")
                    return false;
            }
            return true;
        }





    }
}
