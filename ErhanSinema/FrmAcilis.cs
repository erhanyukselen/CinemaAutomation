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

namespace ErhanSinema
{
    public partial class FrmAcilis : Form
    {
        public FrmAcilis()
        {
            InitializeComponent();
        }
            //connectionstring 
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ErhanSinemaDB;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            conn.Open();

            SqlCommand sorgula = new SqlCommand("select * from Tbl_Kullanicilar WHERE KullaniciAdi=@usarname AND KullaniciSifre=@password", conn);
            sorgula.Parameters.AddWithValue("@usarname",txtKullaniciAdi.Text);
            sorgula.Parameters.AddWithValue("@password", txtSifre.Text);
            SqlDataReader reader = sorgula.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Giriş başarılı");
                FrmAnaForm frm = new FrmAnaForm();
                frm.kisiAdiSoyadi = reader["AdSoyad"].ToString();
                frm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kayıt bulunamadı ya da bilgiler hatalı!");
            }
            conn.Close();

            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtKullaniciAdi.Focus();

            //conn.Open();

            //if (conn.State==ConnectionState.Open)
            //{
            //    MessageBox.Show("Başarılı"); 
            //}
            //conn.Close();
        }
    }
}
