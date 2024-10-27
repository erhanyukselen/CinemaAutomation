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
    public partial class FrmYonetmenKayit : Form
    {
        public FrmYonetmenKayit()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ErhanSinemaDB;Integrated Security=True");

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string photoPath = "";
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Upload Photo";
            openFileDialog.Filter = "PNG |*.png | JPG | *.jpg | JPEG | *.jpeg | All Files | *.*";
            openFileDialog.FilterIndex = 4;

            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
               //Resim alma işlemi 
               pbPhoto.Image = new Bitmap(openFileDialog.FileName);
               photoPath = openFileDialog.FileName.ToString();
            }
        }

        private void rMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "M";
        }

        private void rFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "F";
        }

        public string gender = "M";

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            calculateAge();

            if (txtName.Text != "" && txtSurname.Text != "" && txtBiography.Text != "" && photoPath != "")
            {
                //CRUD
                conn.Open();
                SqlCommand save = new SqlCommand("insert into Tbl_Yonetmenler (Name, Surname, Gender, Age, Biography, Photo) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
                save.Parameters.AddWithValue("@p1", txtName.Text.ToString());
                save.Parameters.AddWithValue("@p2", txtSurname.Text.ToString());
                save.Parameters.AddWithValue("@p3", gender);
                save.Parameters.AddWithValue("@p4", cAge);
                save.Parameters.AddWithValue("@p5", txtBiography.Text.ToString());
                save.Parameters.AddWithValue("@p6", photoPath);
                save.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kayıt Başarılı");
                cleanInputs();
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz!");
            }

        }

        void cleanInputs()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtBiography.Text = "";
            nDay.Value = 1;
            nMonth.Value = 1;
            nYear.Value = 2000;
            rMale.Checked = true;
            rFemale.Checked = false;
            lblCharCount.Text = "300";
            gender = "M";
            cAge = "00";
            pbPhoto.ImageLocation = @"C:\Users\Erhan\Desktop\HRD\photo.png";
            txtName.Focus();
        }

        public string cAge="00";

        void calculateAge()
        {
            string age = nDay.Value.ToString() + "-" + nMonth.Value.ToString() + "-" + nYear.Value.ToString();
           
            DateTime dateOfBirth = Convert.ToDateTime(age);

            DateTime today = DateTime.Today;

            int countage = today.Year - dateOfBirth.Year;

            //if (countage<0)
            //{
            //    MessageBox.Show("Yaşınız negatif olamaz");
            //}

            //else if(countage<18)
            //{
            //    MessageBox.Show("Yaşınız 18'den küçüktür!");
            //}

            //else 
            //{
            //    MessageBox.Show(countage.ToString());
            //}

            cAge = countage.ToString();
        }

        private void txtBiography_TextChanged(object sender, EventArgs e)
        {
            int characterCount = txtBiography.Text.Length;
            int countdown = 300 - characterCount;
            lblCharCount.Text = countdown.ToString();

            if (countdown > 20)
            {
                lblCharCount.ForeColor = Color.FromArgb(84, 110, 122);
            }

            if (countdown<=20)
            {
                lblCharCount.ForeColor = Color.Orange;
            }

            if (countdown<=10) 
            {
                lblCharCount.ForeColor = Color.Red;
            }
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
