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
    public partial class FrmDepartmentActions : Form
    {
        public FrmDepartmentActions()
        {
            InitializeComponent();
        }

        int selectedRow;
        int previousCount;
        int nextCount;

        Boolean isExist;


        //The Database Connection
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HARUN;Initial Catalog=YurtOtomasyonu;Integrated Security=True");


        private void FrmDepartmentActions_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSeti.Bolum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumTableAdapter.Fill(this.yurtOtomasyonuDataSeti.Bolum);

            dataGridViewDepartment.ClearSelection();

        }

        private void dataGridViewDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dataGridViewDepartment.SelectedCells[0].RowIndex;
            tBoxDepartmentName.Text = dataGridViewDepartment.Rows[selectedRow].Cells[0].Value.ToString();
        }

        private void picBoxAdd_Click(object sender, EventArgs e)
        {

            if (tBoxDepartmentName.Text.Trim().Length != 0)
            {
                sqlConnection.Open();
                SqlCommand sqlCommandPreviousCount = new SqlCommand("SELECT COUNT(ad) FROM Bolum", sqlConnection);
                previousCount = Convert.ToInt16(sqlCommandPreviousCount.ExecuteScalar());
                sqlConnection.Close();

                sqlConnection.Open();
                SqlCommand sqlCommandAddDepartment = new SqlCommand("IF NOT EXISTS(SELECT Ad FROM Bolum WHERE Ad = @pDepartmentName) INSERT INTO Bolum (Ad) VALUES (@pDepartmentName)", sqlConnection);
                sqlCommandAddDepartment.Parameters.AddWithValue("@pDepartmentName", tBoxDepartmentName.Text.Trim());
                sqlCommandAddDepartment.ExecuteNonQuery();
                sqlConnection.Close();

                sqlConnection.Open();
                SqlCommand sqlCommandNextCount = new SqlCommand("SELECT COUNT(ad) FROM Bolum", sqlConnection);
                nextCount = Convert.ToInt16(sqlCommandNextCount.ExecuteScalar());
                sqlConnection.Close();

                if (previousCount == nextCount)
                {
                    MessageBox.Show("Bu bölüm zaten mevcut!");
                }
                else
                {
                    MessageBox.Show("Bölüm eklendi.");
                    this.bolumTableAdapter.Fill(this.yurtOtomasyonuDataSeti.Bolum);
                }

            }
            else
            {
                MessageBox.Show("Bölüm eklemek için bölüm adı girmelisiniz!");
            }

          
        }

        private void picBoxEdit_Click(object sender, EventArgs e)
        {

            if (tBoxDepartmentName.Text.Trim().Length != 0)
            {
                sqlConnection.Open();
                SqlCommand sqlCommandIsTheDepartmentExist = new SqlCommand("SELECT CASE WHEN EXISTS(SELECT Ad FROM Bolum WHERE Ad = @pDepartmetName) THEN 'YES' ELSE 'NO' END", sqlConnection);
                sqlCommandIsTheDepartmentExist.Parameters.AddWithValue("@pDepartmetName", tBoxDepartmentName.Text.Trim());
                isExist = sqlCommandIsTheDepartmentExist.ExecuteScalar().ToString().Equals("YES") ? true : false;
                sqlConnection.Close();
                if (isExist)
                {
                    FrmDepartmentNewName frmDepartmentNewName = new FrmDepartmentNewName(tBoxDepartmentName.Text.Trim(), this);
                    frmDepartmentNewName.Show();
                }
                else
                {
                    MessageBox.Show("Bölüm Bulunamadı!");
                }
                
            }
            else
            {
                MessageBox.Show("Bölümü düzenlemek için bölüm adı girmelisiniz!");
            }

        }

        private void picBoxDelete_Click(object sender, EventArgs e)
        {

            if (tBoxDepartmentName.Text.Trim().Length != 0)
            {

                //Try Deleting The Department
                try
                {
                    //Get Count Of Departments Before Deleting
                    sqlConnection.Open();
                    SqlCommand sqlCommandPreviousCount = new SqlCommand("SELECT COUNT(ad) FROM Bolum", sqlConnection);
                    previousCount = Convert.ToInt16(sqlCommandPreviousCount.ExecuteScalar());
                    sqlConnection.Close();


                    //Delete The Department If Exist
                    sqlConnection.Open();
                    SqlCommand sqlCommandDeleteDepartment = new SqlCommand("IF EXISTS(SELECT Ad FROM Bolum WHERE Ad = @pDepartmentName) DELETE FROM Bolum WHERE Ad = @pDepartmentName", sqlConnection);
                    sqlCommandDeleteDepartment.Parameters.AddWithValue("@pDepartmentName", tBoxDepartmentName.Text.Trim());
                    sqlCommandDeleteDepartment.ExecuteNonQuery();
                    sqlConnection.Close();


                    //Get Count Of Departments After Deleting
                    sqlConnection.Open();
                    SqlCommand sqlCommandNextCount = new SqlCommand("SELECT COUNT(ad) FROM Bolum", sqlConnection);
                    nextCount = Convert.ToInt16(sqlCommandNextCount.ExecuteScalar());
                    sqlConnection.Close();

                    if (previousCount == nextCount)
                    {
                        MessageBox.Show("Girilen bölüm bulunamadı!");
                    }
                    else
                    {
                        MessageBox.Show("Bölüm silindi.");
                        this.bolumTableAdapter.Fill(this.yurtOtomasyonuDataSeti.Bolum);
                    }

                }
                catch (SqlException sqlException)
                {
                    if(sqlException.Number == 547)
                    {
                        MessageBox.Show("Girilen bölümde okuyan öğrenci olduğundan bölüm silinemedi!");
                    }
                    else
                    {
                        MessageBox.Show("An SQL Exception Occoured!\n\nError Code = " + sqlException.Number);
                    }

                }
                catch(Exception exception)
                {
                    MessageBox.Show("An Error Occurred While The Department Is Deleted!" + exception);
                }
                finally
                {
                    sqlConnection.Close();
                }

            }
            else
            {
                MessageBox.Show("Bölüm silmek için bölüm adı girmelisiniz!");
            }



        }

      


    }
}
