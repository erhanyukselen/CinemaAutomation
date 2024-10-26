using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErhanSinema
{
    public partial class FrmYonetmenKayit : Form
    {
        public FrmYonetmenKayit()
        {
            InitializeComponent();
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

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
               MessageBox.Show(openFileDialog.ToString());
            }
        }

        private void rMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "0";
        }

        private void rFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "1";
        }

        public string gender = "0";

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(gender);
            calculateAge();

            MessageBox.Show(cAge);
        }

        public string cAge="0";

        void calculateAge()
        {
            string age = nDay.Value.ToString() + "-" + nMonth.Value.ToString() + "-" + nYear.Value.ToString();
           
            DateTime dateOfBirth = Convert.ToDateTime(age);

            DateTime today = DateTime.Today;

            int countage = today.Year - dateOfBirth.Year;

            if (countage<0)
            {
                MessageBox.Show("Yaşınız negatif olamaz");
            }

            else if(countage<18)
            {
                MessageBox.Show("Yaşınız 18'den küçüktür!");
            }

            else 
            {
                MessageBox.Show(countage.ToString());
            }

            cAge = countage.ToString();
        }

        private void txtBiography_TextChanged(object sender, EventArgs e)
        {
            int characterCount = txtBiography.Text.Length;
            int countdown = 300 - characterCount;
            lblCharCount.Text = countdown.ToString();
            if (countdown<=20)
            {
                lblCharCount.ForeColor = Color.Orange;
            }
        }
    }
}
