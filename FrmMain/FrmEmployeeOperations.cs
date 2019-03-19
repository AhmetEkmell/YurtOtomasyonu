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
    public partial class FrmEmployeeOperations : Form
    {

        int selectedRow;
        int previousCount;
        int nextCount;

        Boolean isExist;

        //The Database Connection
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HARUN;Initial Catalog=YurtOtomasyonu;Integrated Security=True");


        public FrmEmployeeOperations()
        {
            InitializeComponent();
        }

        private void FrmEmployeeOperations_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSetEmployee.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSetEmployee.Personel);

            dataGridViewEmployee.ClearSelection();

        }

        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dataGridViewEmployee.SelectedCells[0].RowIndex;
            mtBoxEmployeeTc.Text = dataGridViewEmployee.Rows[selectedRow].Cells[0].Value.ToString();
            tBoxEmployeeName.Text = dataGridViewEmployee.Rows[selectedRow].Cells[1].Value.ToString();
            tBoxEmployeeSurname.Text = dataGridViewEmployee.Rows[selectedRow].Cells[2].Value.ToString();
            tBoxEmployeeDepartment.Text = dataGridViewEmployee.Rows[selectedRow].Cells[3].Value.ToString();
            mtBoxEmployeeSalary.Text = dataGridViewEmployee.Rows[selectedRow].Cells[4].Value.ToString();

            this.ActiveControl = tBoxEmployeeName;
            this.ActiveControl = tBoxEmployeeSurname;
            this.ActiveControl = tBoxEmployeeDepartment;
            this.ActiveControl = mtBoxEmployeeSalary;
            this.ActiveControl = mtBoxEmployeeTc;

        }

        private void picBoxAdd_Click(object sender, EventArgs e)
        {
            this.ActiveControl = tBoxEmployeeName;
            this.ActiveControl = tBoxEmployeeSurname;
            this.ActiveControl = tBoxEmployeeDepartment;
            this.ActiveControl = mtBoxEmployeeSalary;
            this.ActiveControl = mtBoxEmployeeTc;

            // Checking For Mandatory Fields
            if (isTheRegistrationValid())
            {

                // Save The Student
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommandPreviousCount = new SqlCommand("SELECT COUNT(Tc) FROM Personel", sqlConnection);
                    previousCount = Convert.ToInt16(sqlCommandPreviousCount.ExecuteScalar());
                    sqlConnection.Close();

                    sqlConnection.Open();
                    SqlCommand sqlCommandAddEmployee = new SqlCommand("IF NOT EXISTS(SELECT Tc FROM Personel WHERE Tc = @pTc) INSERT INTO Personel(Tc, Ad, Soyad, Departman, Maas) VALUES(@pTc, @pName, @pSurname, @pDepartment, @pSalary)", sqlConnection);
                    sqlCommandAddEmployee.Parameters.AddWithValue("@pTc", mtBoxEmployeeTc.Text.Trim());
                    sqlCommandAddEmployee.Parameters.AddWithValue("@pName", tBoxEmployeeName.Text.Trim());
                    sqlCommandAddEmployee.Parameters.AddWithValue("@pSurname", tBoxEmployeeSurname.Text.Trim());
                    sqlCommandAddEmployee.Parameters.AddWithValue("@pDepartment", tBoxEmployeeDepartment.Text.Trim());
                    sqlCommandAddEmployee.Parameters.AddWithValue("@pSalary", mtBoxEmployeeSalary.Text.Trim());
                    sqlCommandAddEmployee.ExecuteNonQuery();
                    sqlConnection.Close();

                    sqlConnection.Open();
                    SqlCommand sqlCommandNextCount = new SqlCommand("SELECT COUNT(Tc) FROM Personel", sqlConnection);
                    nextCount = Convert.ToInt16(sqlCommandNextCount.ExecuteScalar());
                    sqlConnection.Close();

                    if (previousCount == nextCount)
                    {
                        MessageBox.Show("Bu Tc kimlik numarasıyla kayıtlı bir personel zaten mevcut!");
                    }
                    else
                    {
                        MessageBox.Show("Personel eklendi.");
                        this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSetEmployee.Personel);
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

                    MessageBox.Show("Personel kaydedilirken bir hata oluştu!" + exception);
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

















/*


            if ()
            {
                sqlConnection.Open();
                SqlCommand sqlCommandPreviousCount = new SqlCommand("SELECT COUNT(Tc) FROM Personel", sqlConnection);
                previousCount = Convert.ToInt16(sqlCommandPreviousCount.ExecuteScalar());
                sqlConnection.Close();

                sqlConnection.Open();
                SqlCommand sqlCommandAddEmployee = new SqlCommand("IF NOT EXISTS(SELECT Tc FROM Personel WHERE Tc = @pTc) INSERT INTO Personel(Tc, Ad, Soyad, Departman, Maas) VALUES(@pTc, @pName, @pSurname, @pDepartment, @pSalary)", sqlConnection);
                sqlCommandAddEmployee.Parameters.AddWithValue("@pTc", mtBoxEmployeeTc.Text.Trim());
                sqlCommandAddEmployee.Parameters.AddWithValue("@pName", tBoxEmployeeName.Text.Trim());
                sqlCommandAddEmployee.Parameters.AddWithValue("@pSurname", tBoxEmployeeSurname.Text.Trim());
                sqlCommandAddEmployee.Parameters.AddWithValue("@pDepartment", tBoxEmployeeDepartment.Text.Trim());
                sqlCommandAddEmployee.Parameters.AddWithValue("@pSalary", tBoxEmployeeSalary.Text.Trim());
                sqlCommandAddEmployee.ExecuteNonQuery();
                sqlConnection.Close();

                sqlConnection.Open();
                SqlCommand sqlCommandNextCount = new SqlCommand("SELECT COUNT(Tc) FROM Personel", sqlConnection);
                nextCount = Convert.ToInt16(sqlCommandNextCount.ExecuteScalar());
                sqlConnection.Close();

                if (previousCount == nextCount)
                {
                    MessageBox.Show("Bu Tc kimlik numarasıyla kayıtlı bir personel zaten mevcut!");
                }
                else
                {
                    MessageBox.Show("Personel eklendi.");
                    this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSetEmployee.Personel);
                }

            }
            else
            {
                MessageBox.Show("Personel eklemek için personel bilgilerini girmelisiniz!");
            }
            */
        }

        private void picBoxEdit_Click(object sender, EventArgs e)
        {
            this.ActiveControl = tBoxEmployeeName;
            this.ActiveControl = tBoxEmployeeSurname;
            this.ActiveControl = tBoxEmployeeDepartment;
            this.ActiveControl = mtBoxEmployeeSalary;
            this.ActiveControl = mtBoxEmployeeTc;

            // Checking For Mandatory Fields
            if (isTheRegistrationValid())
            {

                // Edit The Employee
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommandIsTheEmployeeExist = new SqlCommand("SELECT CASE WHEN EXISTS(SELECT Tc FROM Personel WHERE Tc = @pTc) THEN 'YES' ELSE 'NO' END", sqlConnection);
                    sqlCommandIsTheEmployeeExist.Parameters.AddWithValue("@pTc", mtBoxEmployeeTc.Text.Trim());
                    isExist = sqlCommandIsTheEmployeeExist.ExecuteScalar().ToString().Equals("YES") ? true : false;
                    sqlConnection.Close();

                    if (isExist)
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommandEditEmployee = new SqlCommand("UPDATE Personel SET Ad = @pName, Soyad = @pSurname, Departman = @pDepartment, Maas = @pSalary WHERE Tc = @pTc", sqlConnection);
                        sqlCommandEditEmployee.Parameters.AddWithValue("@pTc", mtBoxEmployeeTc.Text.Trim());
                        sqlCommandEditEmployee.Parameters.AddWithValue("@pName", tBoxEmployeeName.Text.Trim());
                        sqlCommandEditEmployee.Parameters.AddWithValue("@pSurname", tBoxEmployeeSurname.Text.Trim());
                        sqlCommandEditEmployee.Parameters.AddWithValue("@pDepartment", tBoxEmployeeDepartment.Text.Trim());
                        sqlCommandEditEmployee.Parameters.AddWithValue("@pSalary", mtBoxEmployeeSalary.Text.Trim());
                        sqlCommandEditEmployee.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Girilen Tc No ile ilişkili personel bulunamadı!");
                    }

      
                    MessageBox.Show("Personel Bilgileri Güncellendi");

                    

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

        private void picBoxDelete_Click(object sender, EventArgs e)
        {

            this.ActiveControl = tBoxEmployeeName;
            this.ActiveControl = tBoxEmployeeSurname;
            this.ActiveControl = tBoxEmployeeDepartment;
            this.ActiveControl = mtBoxEmployeeSalary;
            this.ActiveControl = mtBoxEmployeeTc;

            // Checking For Mandatory Fields
            if (isTheRegistrationValid())
            {

                // Delete The Student
                try
                {
                    sqlConnection.Open();
                    SqlCommand commandSave = new SqlCommand("DELETE FROM Personel WHERE Tc = @pTc", sqlConnection);
                    commandSave.Parameters.AddWithValue("@pTc", mtBoxEmployeeTc.Text.Trim());
                    commandSave.ExecuteNonQuery();
                    sqlConnection.Close();

                    MessageBox.Show("Personel silindi.");

                    mtBoxEmployeeTc.Text = "";
                    tBoxEmployeeName.Text = "";
                    tBoxEmployeeSurname.Text = "";
                    tBoxEmployeeDepartment.Text = "";
                    mtBoxEmployeeSalary.Text = "";


                }
                catch (SqlException sqlException)
                {
                    //SQL Exceptions 

                    if (sqlException.Number == 515)
                    {
                        MessageBox.Show("Lütfen zorunlu alanları eksiksiz doldurunuz!");

                    }
                    if (sqlException.Number == 547)
                    {
                        MessageBox.Show("Seçilen kişi yönetici olduğundan silinemedi!");
                    }
                    else if (sqlException.Number == 8178)
                    {
                        MessageBox.Show("A Given Value Isn't Match With Expected Value!");

                    }
                    else if (sqlException.Number == 2627)
                    {
                        MessageBox.Show("Zaten bu TC kimlik numarasıyla kayıtlı bir Personel var!\n\nPersonel bilgilerini güncellemek için Personel Düzenle butonunu kullanabilirsiniz.");
                    }
                    else
                    {
                        MessageBox.Show("An SQL Exception Occoured!\n\nError Code = " + sqlException.Number);
                    }
                    

                }
                catch (Exception exception)
                {
                    //General Exception

                    MessageBox.Show("Personel silinirken bir hata oluştu!" + exception);
                    
                }
                finally
                {
                    sqlConnection.Close();

                    this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSetEmployee.Personel);

                }



            }
            else
            {
                //If A Mandatory Field Is Empty Show Message
                MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz!");
            }





        }

        private void mtBoxEmployeeTc_Validating(object sender, CancelEventArgs e)
        {
            //TC No Validating Control
            if (string.IsNullOrEmpty(mtBoxEmployeeTc.Text.Trim()))
            {
                errProvider.SetError(mtBoxEmployeeTc, "TC No boş olamaz!");
            }
            else if (mtBoxEmployeeTc.Text.Trim().Length < 11)
            {
                errProvider.SetError(mtBoxEmployeeTc, "TC No geçersiz!");
            }
            else
            {
                errProvider.SetError(mtBoxEmployeeTc, "");
            }
        }

        private void tBoxEmployeeName_Validating(object sender, CancelEventArgs e)
        {
            //Name Validating Control
            if (string.IsNullOrEmpty(tBoxEmployeeName.Text.Trim()))
            {
                errProvider.SetError(tBoxEmployeeName, "Ad boş olamaz!");
            }
            else
            {
                errProvider.SetError(tBoxEmployeeName, "");
            }
        }

        private void tBoxEmployeeSurname_Validating(object sender, CancelEventArgs e)
        {
            //Surname Validating Control
            if (string.IsNullOrEmpty(tBoxEmployeeSurname.Text.Trim()))
            {
                errProvider.SetError(tBoxEmployeeSurname, "Soyad boş olamaz!");
            }
            else
            {
                errProvider.SetError(tBoxEmployeeSurname, "");
            }
        }

        private void tBoxEmployeeDepartment_Validating(object sender, CancelEventArgs e)
        {

            //Department Validating Control
            if (string.IsNullOrEmpty(tBoxEmployeeDepartment.Text.Trim()))
            {
                errProvider.SetError(tBoxEmployeeDepartment, "Departman boş olamaz!");
            }
            else
            {
                errProvider.SetError(tBoxEmployeeDepartment, "");
            }
        }

        private void tBoxEmployeeSalary_Validating(object sender, CancelEventArgs e)
        {

            //Salary Validating Control
            if (string.IsNullOrEmpty(mtBoxEmployeeSalary.Text.Trim()))
            {
                errProvider.SetError(mtBoxEmployeeSalary, "Maaş boş olamaz!");
            }
            else
            {
                errProvider.SetError(mtBoxEmployeeSalary, "");
            }
        }

        private bool isTheRegistrationValid()
        {
            // The Registration Validation Control (General Validation Control)

            Control[] controls = { mtBoxEmployeeTc, tBoxEmployeeName, tBoxEmployeeSurname, tBoxEmployeeDepartment, mtBoxEmployeeSalary };

            foreach (Control c in controls)
            {

                if (errProvider.GetError(c) != "")
                    return false;
            }
            return true;
        }

       
    }
}
