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
    public partial class FrmDepartmentNewName : Form
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HARUN;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
        String oldDepartmentName;
        FrmDepartmentActions frmDepartmentActions;
        public FrmDepartmentNewName()
        {
            InitializeComponent();
        }

        public FrmDepartmentNewName(String oldDepartmentName, FrmDepartmentActions frmDepartmentActions)
        {
            InitializeComponent();
            this.oldDepartmentName = oldDepartmentName;
            this.frmDepartmentActions = frmDepartmentActions;
        }
        

        private void btnOk_Click(object sender, EventArgs e)
        {

            this.ActiveControl = tBoxDepartmentNewName;


            if (isTheRegistrationValid())
            {

                //Try Editing The Department
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommandAddDepartment = new SqlCommand("IF EXISTS(SELECT Ad FROM Bolum WHERE Ad = @pOldDepartmentName) UPDATE Bolum SET Ad = @pNewDepartmentName WHERE Ad = @pOldDepartmentName", sqlConnection);
                    sqlCommandAddDepartment.Parameters.AddWithValue("@pOldDepartmentName", oldDepartmentName);
                    sqlCommandAddDepartment.Parameters.AddWithValue("@pNewDepartmentName", tBoxDepartmentNewName.Text.Trim());
                    sqlCommandAddDepartment.ExecuteNonQuery();
                    sqlConnection.Close();

                    frmDepartmentActions.Close();
                    new FrmDepartmentActions().ShowDialog();
                   

                }
                catch (SqlException sqlException)
                {
                    if (sqlException.Number == 547)
                    {
                        MessageBox.Show("Girilen bölümde okuyan öğrenci olduğundan bölüm Düzenlenemedi!");
                    }
                    else
                    {
                        MessageBox.Show("An SQL Exception Occoured!\n\nError Code = " + sqlException.Number);
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show("An Error Occurred While The Department Is Edited!" + exception);
                }
                finally
                {
                    sqlConnection.Close();
                }


                this.Close();

            }
            else
            {
                MessageBox.Show("Bölüm adı geçersiz!");
            }


        }

        private bool isTheRegistrationValid()
        {
            // The Registration Validation Control (General Validation Control)

            Control[] controls = { tBoxDepartmentNewName };

            foreach (Control c in controls)
            {

                if (errProvider.GetError(c) != "")
                    return false;
            }
            return true;
        }

        private void tBoxDepartmentNewName_Validating(object sender, CancelEventArgs e)
        {
            //Department Name Validating Control
            if (string.IsNullOrEmpty(tBoxDepartmentNewName.Text.Trim()))
            {
                errProvider.SetError(tBoxDepartmentNewName, "Bölüm adı boş olamaz!");
            }
            else
            {
                errProvider.SetError(tBoxDepartmentNewName, "");
            }
        }
    }
}
