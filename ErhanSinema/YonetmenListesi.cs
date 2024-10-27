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
    public partial class YonetmenListesi : UserControl
    {
        public YonetmenListesi()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ErhanSinemaDB;Integrated Security=True");


        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sorgu = "select * from Tbl_Yonetmenler WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, conn);
            komut.Parameters.AddWithValue("@p1", lblId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Biyografi: "+ dr["Biography"].ToString(), dr["Name"].ToString(),MessageBoxButtons.OK,MessageBoxIcon.Information);
            }



            conn.Close();
        }

        private void YonetmenListesi_Load(object sender, EventArgs e)
        {
           



           
        }

        private void delete_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand sil = new SqlCommand("delete from Tbl_Yonetmenler Where ID=@p1", conn);
            sil.Parameters.AddWithValue("@p1", lblId.Text);
            sil.ExecuteNonQuery();
            conn.Close();
            this.Hide();
            MessageBox.Show(lblAdSoyad.Text + "Yönetmen Başarılı Şekilde Silindi.");
        }
    }
}
