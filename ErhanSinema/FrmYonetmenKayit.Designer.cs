namespace ErhanSinema
{
    partial class FrmYonetmenKayit
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYonetmenKayit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rFemale = new System.Windows.Forms.RadioButton();
            this.rMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.nYear = new System.Windows.Forms.NumericUpDown();
            this.nMonth = new System.Windows.Forms.NumericUpDown();
            this.nDay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBiography = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDay)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.X);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 40);
            this.panel1.TabIndex = 2;
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X.Dock = System.Windows.Forms.DockStyle.Right;
            this.X.FlatAppearance.BorderSize = 0;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X.Location = new System.Drawing.Point(657, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(40, 40);
            this.X.TabIndex = 1;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "[Yönetmen Kayıt Ekranı]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rFemale);
            this.groupBox1.Controls.Add(this.rMale);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nYear);
            this.groupBox1.Controls.Add(this.nMonth);
            this.groupBox1.Controls.Add(this.nDay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 244);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rFemale
            // 
            this.rFemale.AutoSize = true;
            this.rFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rFemale.Location = new System.Drawing.Point(181, 186);
            this.rFemale.Name = "rFemale";
            this.rFemale.Size = new System.Drawing.Size(79, 25);
            this.rFemale.TabIndex = 16;
            this.rFemale.Text = "Female";
            this.rFemale.UseVisualStyleBackColor = true;
            this.rFemale.CheckedChanged += new System.EventHandler(this.rFemale_CheckedChanged);
            // 
            // rMale
            // 
            this.rMale.AutoSize = true;
            this.rMale.Checked = true;
            this.rMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rMale.Location = new System.Drawing.Point(104, 186);
            this.rMale.Name = "rMale";
            this.rMale.Size = new System.Drawing.Size(63, 25);
            this.rMale.TabIndex = 15;
            this.rMale.TabStop = true;
            this.rMale.Text = "Male";
            this.rMale.UseVisualStyleBackColor = true;
            this.rMale.CheckedChanged += new System.EventHandler(this.rMale_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender";
            // 
            // nYear
            // 
            this.nYear.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.nYear.Location = new System.Drawing.Point(200, 119);
            this.nYear.Maximum = new decimal(new int[] {
            2300,
            0,
            0,
            0});
            this.nYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nYear.Name = "nYear";
            this.nYear.Size = new System.Drawing.Size(60, 27);
            this.nYear.TabIndex = 10;
            this.nYear.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // nMonth
            // 
            this.nMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.nMonth.Location = new System.Drawing.Point(152, 119);
            this.nMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMonth.Name = "nMonth";
            this.nMonth.Size = new System.Drawing.Size(42, 27);
            this.nMonth.TabIndex = 10;
            this.nMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nDay
            // 
            this.nDay.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.nDay.Location = new System.Drawing.Point(104, 119);
            this.nDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nDay.Name = "nDay";
            this.nDay.Size = new System.Drawing.Size(42, 27);
            this.nDay.TabIndex = 10;
            this.nDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date of Birth";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.txtSurname.Location = new System.Drawing.Point(104, 73);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(156, 20);
            this.txtSurname.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.txtName.Location = new System.Drawing.Point(104, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 20);
            this.txtName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Surname";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUploadPhoto);
            this.groupBox2.Controls.Add(this.pbPhoto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox2.Location = new System.Drawing.Point(357, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 244);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUploadPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadPhoto.FlatAppearance.BorderSize = 0;
            this.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPhoto.ForeColor = System.Drawing.Color.White;
            this.btnUploadPhoto.Location = new System.Drawing.Point(26, 204);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(266, 34);
            this.btnUploadPhoto.TabIndex = 5;
            this.btnUploadPhoto.Text = "Upload";
            this.btnUploadPhoto.UseVisualStyleBackColor = false;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbPhoto.Image")));
            this.pbPhoto.Location = new System.Drawing.Point(26, 56);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(266, 135);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 9;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Photo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCharCount);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBiography);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(676, 190);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // lblCharCount
            // 
            this.lblCharCount.Location = new System.Drawing.Point(630, 157);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCharCount.Size = new System.Drawing.Size(37, 21);
            this.lblCharCount.TabIndex = 8;
            this.lblCharCount.Text = "300";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(535, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "(max length 300)";
            // 
            // txtBiography
            // 
            this.txtBiography.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBiography.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBiography.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.txtBiography.Location = new System.Drawing.Point(3, 40);
            this.txtBiography.MaxLength = 300;
            this.txtBiography.Multiline = true;
            this.txtBiography.Name = "txtBiography";
            this.txtBiography.Size = new System.Drawing.Size(670, 147);
            this.txtBiography.TabIndex = 6;
            this.txtBiography.TextChanged += new System.EventHandler(this.txtBiography_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Biography";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(0, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(697, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmYonetmenKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 541);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(700, 110);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmYonetmenKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmYonetmenKayit";
            this.Load += new System.EventHandler(this.FrmYonetmenKayit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nMonth;
        private System.Windows.Forms.NumericUpDown nDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rFemale;
        private System.Windows.Forms.RadioButton rMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nYear;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBiography;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbPhoto;
    }
}