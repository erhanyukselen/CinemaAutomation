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

namespace ErhanSinema
{
    public partial class FrmYonetmenListesi : Form
    {
        public FrmYonetmenListesi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ErhanSinemaDB;Integrated Security=True");

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmYonetmenListesi_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            conn.Open();
            string sorgu = "select * from Tbl_Yonetmenler ORDER BY Name ASC";
            SqlCommand komut = new SqlCommand(sorgu, conn);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               //işlemler 
               YonetmenListesi arac = new YonetmenListesi();
                arac.lblAdSoyad.Text = dr["Name"].ToString();
                arac.lblSoyad.Text = dr["Surname"].ToString();
                arac.lblId.Text = dr["ID"].ToString();
                arac.pbResimDetay.ImageLocation= dr["Photo"].ToString();
               ListePaneli.Controls.Add(arac);
            }



            conn.Close();
        }
    }
}
