namespace ErhanSinema
{
    partial class YonetmenListesi
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YonetmenListesi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.pbResimDetay = new System.Windows.Forms.PictureBox();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbResimDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 90);
            this.panel1.TabIndex = 0;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblAdSoyad.Location = new System.Drawing.Point(174, 10);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(61, 25);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "label1";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblSoyad.Location = new System.Drawing.Point(241, 10);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(61, 25);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "label1";
            // 
            // pbResimDetay
            // 
            this.pbResimDetay.Image = ((System.Drawing.Image)(resources.GetObject("pbResimDetay.Image")));
            this.pbResimDetay.Location = new System.Drawing.Point(11, 0);
            this.pbResimDetay.Name = "pbResimDetay";
            this.pbResimDetay.Size = new System.Drawing.Size(101, 90);
            this.pbResimDetay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResimDetay.TabIndex = 3;
            this.pbResimDetay.TabStop = false;
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUploadPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadPhoto.FlatAppearance.BorderSize = 0;
            this.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPhoto.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUploadPhoto.ForeColor = System.Drawing.Color.White;
            this.btnUploadPhoto.Location = new System.Drawing.Point(267, 56);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(180, 34);
            this.btnUploadPhoto.TabIndex = 6;
            this.btnUploadPhoto.Text = "Detay";
            this.btnUploadPhoto.UseVisualStyleBackColor = false;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblId.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblId.Location = new System.Drawing.Point(377, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(61, 25);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "label1";
            this.lblId.Visible = false;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.OrangeRed;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(453, 56);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(47, 34);
            this.delete.TabIndex = 8;
            this.delete.Text = "Sil";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // YonetmenListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.delete);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnUploadPhoto);
            this.Controls.Add(this.pbResimDetay);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.panel1);
            this.Name = "YonetmenListesi";
            this.Size = new System.Drawing.Size(500, 90);
            this.Load += new System.EventHandler(this.YonetmenListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResimDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblAdSoyad;
        public System.Windows.Forms.Label lblSoyad;
        public System.Windows.Forms.PictureBox pbResimDetay;
        private System.Windows.Forms.Button btnUploadPhoto;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button delete;
    }
}
