namespace XIIRPL1_25_Ticketing.MasterForm
{
    partial class FrmMasterBandara
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
            dgvBandara = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNama = new TextBox();
            txtKodeIATA = new TextBox();
            txtKota = new TextBox();
            label7 = new Label();
            label8 = new Label();
            rtbAlamat = new RichTextBox();
            nudJumlahterminal = new NumericUpDown();
            btnBatal = new Button();
            btnSimpan = new Button();
            cbNegara = new ComboBox();
            id = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBandara).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudJumlahterminal).BeginInit();
            SuspendLayout();
            // 
            // dgvBandara
            // 
            dgvBandara.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBandara.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dgvBandara.Location = new Point(12, 86);
            dgvBandara.Name = "dgvBandara";
            dgvBandara.RowTemplate.Height = 25;
            dgvBandara.Size = new Size(776, 194);
            dgvBandara.TabIndex = 0;
            dgvBandara.CellContentClick += dgvBandara_CellContentClick;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 1;
            label1.Text = "Master Bandara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(290, 17);
            label2.TabIndex = 2;
            label2.Text = "Semua bandara yang terdaftar akan mucul disini";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 302);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 340);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Kode IATA";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 378);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 5;
            label5.Text = "Kota";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 418);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 6;
            label6.Text = "Negara";
            label6.Click += label6_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(97, 299);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(248, 23);
            txtNama.TabIndex = 8;
            // 
            // txtKodeIATA
            // 
            txtKodeIATA.Location = new Point(97, 337);
            txtKodeIATA.Name = "txtKodeIATA";
            txtKodeIATA.Size = new Size(248, 23);
            txtKodeIATA.TabIndex = 9;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(97, 375);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(248, 23);
            txtKota.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(363, 340);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 12;
            label7.Text = "Alamat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(363, 301);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 13;
            label8.Text = "Jumlah Terminal";
            // 
            // rtbAlamat
            // 
            rtbAlamat.Location = new Point(480, 337);
            rtbAlamat.Name = "rtbAlamat";
            rtbAlamat.Size = new Size(308, 101);
            rtbAlamat.TabIndex = 14;
            rtbAlamat.Text = "";
            // 
            // nudJumlahterminal
            // 
            nudJumlahterminal.Location = new Point(480, 299);
            nudJumlahterminal.Name = "nudJumlahterminal";
            nudJumlahterminal.Size = new Size(308, 23);
            nudJumlahterminal.TabIndex = 15;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(713, 473);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 16;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(551, 473);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 17;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // cbNegara
            // 
            cbNegara.FormattingEnabled = true;
            cbNegara.Location = new Point(97, 415);
            cbNegara.Name = "cbNegara";
            cbNegara.Size = new Size(248, 23);
            cbNegara.TabIndex = 18;
            // 
            // id
            // 
            id.Location = new Point(363, 415);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 19;
            id.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(632, 473);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(btnEdit);
            Controls.Add(id);
            Controls.Add(cbNegara);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(nudJumlahterminal);
            Controls.Add(rtbAlamat);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtKota);
            Controls.Add(txtKodeIATA);
            Controls.Add(txtNama);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvBandara);
            Name = "FrmMasterBandara";
            Text = "FrmMasterBandara";
            Load += FrmMasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBandara).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudJumlahterminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBandara;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNama;
        private TextBox txtKodeIATA;
        private TextBox txtKota;
        private Label label7;
        private Label label8;
        private RichTextBox rtbAlamat;
        private NumericUpDown nudJumlahterminal;
        private Button btnBatal;
        private Button btnSimpan;
        private ComboBox cbNegara;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}