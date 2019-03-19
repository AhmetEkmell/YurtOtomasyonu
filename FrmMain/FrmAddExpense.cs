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
    public partial class FrmAddExpense : Form
    {
        public FrmAddExpense()
        {
            InitializeComponent();
        }

        //The Database Connection
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HARUN;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void FrmAddExpense_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommandGetExpenseTypes = new SqlCommand("SELECT Deger FROM Gider", sqlConnection);
            SqlDataReader sqlDataReaderGetExpenseTypes = sqlCommandGetExpenseTypes.ExecuteReader();
            while (sqlDataReaderGetExpenseTypes.Read())
            {
                cBoxExpenceType.Items.Add(sqlDataReaderGetExpenseTypes[0].ToString());
            }
            sqlConnection.Close();
        }

        private void mtBoxAmount_Validating(object sender, CancelEventArgs e)
        {

            //Amount Validating Control
            if (string.IsNullOrEmpty(mtBoxAmount.Text.Trim()))
            {
                errProvider.SetError(mtBoxAmount, "Gider miktarı boş olamaz!");
            }
            else
            {
                errProvider.SetError(mtBoxAmount, "");
            }
        }

        private void cBoxExpenceType_Validating(object sender, CancelEventArgs e)
        {
            //Expence Type Validating Control
            if (string.IsNullOrEmpty(cBoxExpenceType.Text.Trim()))
            {
                errProvider.SetError(cBoxExpenceType, "Gider türü boş olamaz!");
            }
            else
            {
                errProvider.SetError(cBoxExpenceType, "");
            }
        }

        private void dtPickerPaymentDate_Validating(object sender, CancelEventArgs e)
        {
            //Payment Date Validating Control
            if (string.IsNullOrEmpty(dtPickerPaymentDate.Text.Trim()))
            {
                errProvider.SetError(dtPickerPaymentDate, "Ödeme Tarihi boş olamaz!");
            }
            else
            {
                errProvider.SetError(dtPickerPaymentDate, "");
            }
        }

        private bool isTheRegistrationValid()
        {
            // The Registration Validation Control (General Validation Control)

            Control[] controls = { mtBoxAmount, cBoxExpenceType, dtPickerPaymentDate };

            foreach (Control c in controls)
            {

                if (errProvider.GetError(c) != "")
                    return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            this.ActiveControl = dtPickerPaymentDate;
            this.ActiveControl = cBoxExpenceType;
            this.ActiveControl = mtBoxAmount;

            // Checking For Mandatory Fields
            if (isTheRegistrationValid())
            {

                // Save The Expense
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommandSaveExpense = new SqlCommand("INSERT INTO GiderOdeme(Miktar, Tarih, GiderId) values (@pAmount, @pExpenseDate, (SELECT Id FROM Gider WHERE Deger = @pExpenseType))", sqlConnection);
                    sqlCommandSaveExpense.Parameters.AddWithValue("@pAmount", Convert.ToInt32(mtBoxAmount.Text.ToString().Trim()));
                    sqlCommandSaveExpense.Parameters.AddWithValue("@pExpenseDate", (Object)dtPickerPaymentDate.Value.ToString("yyyy-MM-dd"));
                    sqlCommandSaveExpense.Parameters.AddWithValue("@pExpenseType", cBoxExpenceType.Text);
                    sqlCommandSaveExpense.ExecuteNonQuery();
                    sqlConnection.Close();

                    MessageBox.Show("Gider Kaydedildi");

                    mtBoxAmount.Text = "";


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
    }
}
