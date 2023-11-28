namespace XIIRPL1_25_Ticketing.MasterForm
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Daftarkan = new Label();
            txtUsername = new Label();
            txtNama = new Label();
            txtTglLahir = new Label();
            txtNomorTlp = new Label();
            txtPaswword = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            txtLinkLabel = new LinkLabel();
            btnDaftar = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(485, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 239);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 37);
            label1.TabIndex = 1;
            label1.Text = "Daftar Akun";
            label1.Click += label1_Click;
            // 
            // Daftarkan
            // 
            Daftarkan.AutoSize = true;
            Daftarkan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Daftarkan.Location = new Point(8, 46);
            Daftarkan.Name = "Daftarkan";
            Daftarkan.Size = new Size(330, 17);
            Daftarkan.TabIndex = 2;
            Daftarkan.Text = "Daftarkan diri anda untuk menggunakan Bromo Airlines";
            Daftarkan.Click += Daftarkan_Click;
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(8, 109);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(67, 17);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "Username";
            txtUsername.Click += label2_Click;
            // 
            // txtNama
            // 
            txtNama.AutoSize = true;
            txtNama.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(8, 143);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(43, 17);
            txtNama.TabIndex = 4;
            txtNama.Text = "Nama";
            txtNama.Click += label3_Click;
            // 
            // txtTglLahir
            // 
            txtTglLahir.AutoSize = true;
            txtTglLahir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTglLahir.Location = new Point(8, 180);
            txtTglLahir.Name = "txtTglLahir";
            txtTglLahir.Size = new Size(86, 17);
            txtTglLahir.TabIndex = 5;
            txtTglLahir.Text = "Tanggal Lahir";
            // 
            // txtNomorTlp
            // 
            txtNomorTlp.AutoSize = true;
            txtNomorTlp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomorTlp.Location = new Point(8, 217);
            txtNomorTlp.Name = "txtNomorTlp";
            txtNomorTlp.Size = new Size(100, 17);
            txtNomorTlp.TabIndex = 6;
            txtNomorTlp.Text = "Nomor Telepon";
            txtNomorTlp.Click += label5_Click;
            // 
            // txtPaswword
            // 
            txtPaswword.AutoSize = true;
            txtPaswword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaswword.Location = new Point(8, 250);
            txtPaswword.Name = "txtPaswword";
            txtPaswword.Size = new Size(67, 17);
            txtPaswword.TabIndex = 7;
            txtPaswword.Text = "Paswword";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 23);
            textBox1.TabIndex = 8;
            textBox1.Text = "Soonglynt";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 23);
            textBox3.TabIndex = 10;
            textBox3.Text = "Soonglynt";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 406);
            label7.Name = "label7";
            label7.Size = new Size(113, 17);
            label7.TabIndex = 11;
            label7.Text = "Sudah puya akun?";
            // 
            // txtLinkLabel
            // 
            txtLinkLabel.AutoSize = true;
            txtLinkLabel.Location = new Point(131, 408);
            txtLinkLabel.Name = "txtLinkLabel";
            txtLinkLabel.Size = new Size(37, 15);
            txtLinkLabel.TabIndex = 12;
            txtLinkLabel.TabStop = true;
            txtLinkLabel.Text = "Login";
            txtLinkLabel.LinkClicked += txtLinkLabel_LinkClicked;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(294, 296);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(102, 39);
            btnDaftar.TabIndex = 13;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(131, 180);
            dateTimePicker1.MaxDate = new DateTime(2005, 5, 3, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 23);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.Value = new DateTime(2005, 5, 3, 0, 0, 0, 0);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 23);
            textBox2.TabIndex = 16;
            textBox2.Text = "987654321";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(131, 250);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(265, 23);
            textBox4.TabIndex = 17;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnDaftar);
            Controls.Add(txtLinkLabel);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(txtPaswword);
            Controls.Add(txtNomorTlp);
            Controls.Add(txtTglLahir);
            Controls.Add(txtNama);
            Controls.Add(txtUsername);
            Controls.Add(Daftarkan);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FrmRegister";
            Text = "FrmRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label Daftarkan;
        private Label txtUsername;
        private Label txtNama;
        private Label txtTglLahir;
        private Label txtNomorTlp;
        private Label txtPaswword;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label7;
        private LinkLabel txtLinkLabel;
        private Button btnDaftar;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox4;
    }
}