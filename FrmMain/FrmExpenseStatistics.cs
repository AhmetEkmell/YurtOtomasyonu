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
    public partial class FrmExpenseStatistics : Form
    {
        public FrmExpenseStatistics()
        {
            InitializeComponent();
        }


        //The Database Connection
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HARUN;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void FrmExpenseStatistics_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("Select Sum(Miktar) from GiderOdeme", sqlConnection);
            SqlDataReader oku = komut.ExecuteReader();
            int k = 0;
            while (oku.Read())
            {
                toplamGiderlbl.Text = oku[k].ToString();
                k = k + 1;
            }
            sqlConnection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            
            SqlCommand komut = new SqlCommand("Select Sum(Miktar) from GiderOdeme where Tarih>= Convert(date,@p1,104) and Tarih<=Convert(date,@p2,104)", sqlConnection);
            komut.Parameters.AddWithValue("@p1", BASLANGİCTrh.Value.ToShortDateString());
            komut.Parameters.AddWithValue("@p2", BitisTrh.Value.ToShortDateString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                sclnAyGiderLbl.Text = oku[0].ToString();
                
            }
            sqlConnection.Close();


            this.chart1.ChartAreas[0].AxisY.Maximum = Convert.ToInt64(toplamGiderlbl.Text);
            this.chart1.Series["GIDER"].Points.AddXY(BASLANGİCTrh.Value.ToShortDateString() + "   &&  " + BitisTrh.Value.ToShortDateString(), sclnAyGiderLbl.Text);
            sqlConnection.Close();

        }
    }
}
