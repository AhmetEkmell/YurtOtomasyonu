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
    public partial class FrmStudentList : Form
    {
        public FrmStudentList()
        {
            InitializeComponent();
        }
        



        //The Database Connection
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HARUN;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void FrmStudentList_Load(object sender, EventArgs e)
        {


            sqlConnection.Open();
            SqlCommand sqlCommandStudentList = new SqlCommand("SELECT Tc, Ogrenci.Ad, Soyad, DogumTarihi, Telefon, Mail, Bolum.Ad AS BolumAdi, OdaNo, KalanBorc, VeliAd, VeliSoyad, VeliTelefon, VeliAdres FROM Ogrenci INNER JOIN Bolum ON Ogrenci.BolumId = Bolum.Id ", sqlConnection);
            SqlDataAdapter sqlDataAdapterStudentList = new SqlDataAdapter(sqlCommandStudentList);
            DataTable dataTableStudentList = new DataTable();
            sqlDataAdapterStudentList.Fill(dataTableStudentList);
            dataGridViewStudentList.DataSource = dataTableStudentList;
            
          
        }


    }

    }
