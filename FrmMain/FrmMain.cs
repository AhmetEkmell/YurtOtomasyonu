using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmMain.YurtOtomasyonuDataSetEmployeeTableAdapters;
using FrmMain.YurtOtomasyonuDataSetExpenseListTableAdapters;

namespace FrmMain
{
    public partial class FrmMain : Form
    {

        String username;

        public FrmMain(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer.Start();
            lblUsername.Text = username.ToUpper();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword.exe");
        }

        private void mSExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel.exe");
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void picBoxWord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword.exe");
        }

        private void picBoxCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void picBoxExcel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel.exe");
        }
       
        private void girişÇıkışKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSelectPortDialog frmSelectPortDialog = new FrmSelectPortDialog("FrmStudentTracking");
            frmSelectPortDialog.Show();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentRegister frmStudentRegister = new FrmStudentRegister();
            frmStudentRegister.Show();
        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentEditer frmStudentEditer = new FrmStudentEditer();
            frmStudentEditer.Show();
        }

        private void kartEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSelectPortDialog frmSelectPortDialog = new FrmSelectPortDialog("FrmAddCard");
            frmSelectPortDialog.Show();
        }

        private void öğrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentDeleting frmStudentDeleting = new FrmStudentDeleting();
            frmStudentDeleting.Show();
        }

        private void bölümİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartmentActions frmDepartmentActions = new FrmDepartmentActions();
            frmDepartmentActions.Show();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentList frmStudentList = new FrmStudentList();
            frmStudentList.Show();
        }

        internal class YurtOtomasyonuDataSet1TableAdapters
        {
            internal class OgrenciTableAdapter
            {
            }
        }



        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployeeOperations frmEmployeeOperations = new FrmEmployeeOperations();
            frmEmployeeOperations.Show();
        }

        internal class YurtOtomasyonuDataSetEmployee : global::FrmMain.YurtOtomasyonuDataSetEmployee
        {
        }

        internal class YurtOtomasyonuDataSetEmployeeTableAdapters
        {
            internal class PersonelTableAdapter : global::FrmMain.YurtOtomasyonuDataSetEmployeeTableAdapters.PersonelTableAdapter
            {
            }
        }

        private void yöneticiİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminOperations frmAdminOperations = new FrmAdminOperations();
            frmAdminOperations.Show();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReceivePayment frmReceivePayment = new FrmReceivePayment();
            frmReceivePayment.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddExpense frmAddExpense = new FrmAddExpense();
            frmAddExpense.Show();
        }

        internal class YurtOtomasyonuDataSetExpenseList : global::FrmMain.YurtOtomasyonuDataSetExpenseList
        {
        }

        internal class YurtOtomasyonuDataSetExpenseListTableAdapters
        {
            internal class GiderOdemeTableAdapter : global::FrmMain.YurtOtomasyonuDataSetExpenseListTableAdapters.GiderOdemeTableAdapter
            {
            }
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExpenseList frmExpenseList = new FrmExpenseList();
            frmExpenseList.Show();
        }

        private void giderİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExpenseStatistics frmExpenseStatistics = new FrmExpenseStatistics();
            frmExpenseStatistics.Show();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEarningStatistics frmEarningStatistics = new FrmEarningStatistics();
            frmEarningStatistics.Show();
        }

        private void picBoxStatistics_Click(object sender, EventArgs e)
        {
            FrmEarningStatistics frmEarningStatistics = new FrmEarningStatistics();
            frmEarningStatistics.Show();
        }

        private void picBoxOsym_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ais.osym.gov.tr/");
        }

        private void picBoxGsb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.gsb.gov.tr/");
        }

        private void picBoxFirat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.firat.edu.tr/tr");
        }
    }
}
