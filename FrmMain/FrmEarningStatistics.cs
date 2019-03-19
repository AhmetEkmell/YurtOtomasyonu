using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrmMain
{
    public partial class FrmEarningStatistics : Form
    {
        public FrmEarningStatistics()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HARUN;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void FrmEarningStatistics_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("Select Sum(Miktar) from Odeme", sqlConnection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                toplamGelirLbl.Text = oku[0].ToString();
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

            // Seçilen aya göre toplam elde edilen gelir
            SqlCommand komut = new SqlCommand("Select Sum(Miktar) from Odeme where Tarih>= Convert(date,@p1,104) and Tarih<=Convert(date,@p2,104)", sqlConnection);
            komut.Parameters.AddWithValue("@p1", BASLANGİCTrh.Value.ToShortDateString());
            komut.Parameters.AddWithValue("@p2", BitisTrh.Value.ToShortDateString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                sclnAyGelirLbl.Text = oku[0].ToString();
            }
            sqlConnection.Close();

            this.chart1.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(toplamGelirLbl.Text);
            this.chart1.Series["GELIR"].Points.AddXY(BASLANGİCTrh.Value.ToShortDateString() + "   &&  " + BitisTrh.Value.ToShortDateString(), sclnAyGelirLbl.Text);

            sqlConnection.Close();
        }

    }
}

