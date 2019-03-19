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
    public partial class FrmExpenseList : Form
    {
        public FrmExpenseList()
        {
            InitializeComponent();
        }


        //The Database Connection
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HARUN;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void FrmExpenseList_Load(object sender, EventArgs e)
        {

            sqlConnection.Open();
            SqlCommand sqlCommandExperenseList = new SqlCommand("SELECT Tarih, Miktar, Gider.Tur, Gider.Deger FROM GiderOdeme INNER JOIN Gider ON Gider.Id = GiderOdeme.GiderId ", sqlConnection);
            SqlDataAdapter sqlDataAdapterExperenseList = new SqlDataAdapter(sqlCommandExperenseList);
            DataTable dataTableExperenseList = new DataTable();
            sqlDataAdapterExperenseList.Fill(dataTableExperenseList);
            dataGridViewExpenseList.DataSource = dataTableExperenseList;

        }
    }
}
