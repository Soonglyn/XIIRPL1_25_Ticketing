namespace XIIRPL1_25_Ticketing.MasterForm
{
    partial class FrmMasterJadwalPenerbangan
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
            btnSimpan = new Button();
            button1 = new Button();
            nudHarga = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            txtKodePenerbangan = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvJadwalPenerbangan = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label9 = new Label();
            label10 = new Label();
            dtpTanggal = new DateTimePicker();
            txtDurasi = new TextBox();
            cbDari = new ComboBox();
            cbKe = new ComboBox();
            cbMaskapai = new ComboBox();
            id = new TextBox();
            txtWaktu = new DateTimePicker();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)nudHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvJadwalPenerbangan).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(551, 490);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 34;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(713, 489);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 33;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // nudHarga
            // 
            nudHarga.Location = new Point(507, 417);
            nudHarga.Name = "nudHarga";
            nudHarga.Size = new Size(281, 23);
            nudHarga.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(363, 303);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 30;
            label8.Text = "Tanggal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(363, 342);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 29;
            label7.Text = "Waktu Keberangkatan";
            // 
            // txtKodePenerbangan
            // 
            txtKodePenerbangan.Location = new Point(125, 301);
            txtKodePenerbangan.Name = "txtKodePenerbangan";
            txtKodePenerbangan.Size = new Size(220, 23);
            txtKodePenerbangan.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 420);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 24;
            label6.Text = "Maskapai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 380);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 23;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 342);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 22;
            label4.Text = "Dari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 304);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 21;
            label3.Text = "Kode Penerbangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(259, 17);
            label2.TabIndex = 20;
            label2.Text = "Semua jadwal penerbang akan mucul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(262, 25);
            label1.TabIndex = 19;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // dgvJadwalPenerbangan
            // 
            dgvJadwalPenerbangan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJadwalPenerbangan.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dgvJadwalPenerbangan.Location = new Point(12, 88);
            dgvJadwalPenerbangan.Name = "dgvJadwalPenerbangan";
            dgvJadwalPenerbangan.RowTemplate.Height = 25;
            dgvJadwalPenerbangan.Size = new Size(776, 194);
            dgvJadwalPenerbangan.TabIndex = 18;
            dgvJadwalPenerbangan.CellContentClick += dgvJadwalPenerbangan_CellContentClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(363, 380);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 35;
            label9.Text = "Durasi Penerbangan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(363, 420);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 36;
            label10.Text = "Harga Per Tiket";
            // 
            // dtpTanggal
            // 
            dtpTanggal.CustomFormat = "dd-mm-yyyy";
            dtpTanggal.Format = DateTimePickerFormat.Short;
            dtpTanggal.Location = new Point(507, 301);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(281, 23);
            dtpTanggal.TabIndex = 37;
            dtpTanggal.Value = new DateTime(2023, 10, 31, 12, 17, 0, 0);
            // 
            // txtDurasi
            // 
            txtDurasi.Location = new Point(507, 377);
            txtDurasi.Name = "txtDurasi";
            txtDurasi.Size = new Size(281, 23);
            txtDurasi.TabIndex = 38;
            // 
            // cbDari
            // 
            cbDari.FormattingEnabled = true;
            cbDari.Location = new Point(125, 342);
            cbDari.Name = "cbDari";
            cbDari.Size = new Size(220, 23);
            cbDari.TabIndex = 40;
            // 
            // cbKe
            // 
            cbKe.FormattingEnabled = true;
            cbKe.Location = new Point(125, 377);
            cbKe.Name = "cbKe";
            cbKe.Size = new Size(220, 23);
            cbKe.TabIndex = 41;
            // 
            // cbMaskapai
            // 
            cbMaskapai.FormattingEnabled = true;
            cbMaskapai.Location = new Point(125, 417);
            cbMaskapai.Name = "cbMaskapai";
            cbMaskapai.Size = new Size(220, 23);
            cbMaskapai.TabIndex = 42;
            // 
            // id
            // 
            id.Location = new Point(363, 490);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 53;
            id.Visible = false;
            // 
            // txtWaktu
            // 
            txtWaktu.CustomFormat = "hh:mm";
            txtWaktu.Format = DateTimePickerFormat.Time;
            txtWaktu.Location = new Point(507, 339);
            txtWaktu.Name = "txtWaktu";
            txtWaktu.Size = new Size(281, 23);
            txtWaktu.TabIndex = 54;
            txtWaktu.Value = new DateTime(2023, 10, 31, 13, 44, 0, 0);
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(632, 489);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 55;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 543);
            Controls.Add(btnEdit);
            Controls.Add(txtWaktu);
            Controls.Add(id);
            Controls.Add(cbMaskapai);
            Controls.Add(cbKe);
            Controls.Add(cbDari);
            Controls.Add(txtDurasi);
            Controls.Add(dtpTanggal);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(nudHarga);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtKodePenerbangan);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvJadwalPenerbangan);
            Name = "FrmMasterJadwalPenerbangan";
            Text = "FrmMasterJadwalPenerbangan";
            Load += FrmMasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)nudHarga).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvJadwalPenerbangan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button button1;
        private NumericUpDown nudHarga;
        private Label label8;
        private Label label7;
        private TextBox txtKodePenerbangan;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvJadwalPenerbangan;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpTanggal;
        private TextBox txtDurasi;
        private ComboBox cbDari;
        private ComboBox cbKe;
        private ComboBox cbMaskapai;
        private TextBox id;
        private DateTimePicker txtWaktu;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}