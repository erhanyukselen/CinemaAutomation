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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void X_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
        public string kisiAdiSoyadi = "";
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hoşgeldin " + kisiAdiSoyadi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmYonetmenKayit frm = new FrmYonetmenKayit();

            frm.ShowDialog();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYonetmenListesi frm = new FrmYonetmenListesi();

            frm.ShowDialog();
        }
    }
}
