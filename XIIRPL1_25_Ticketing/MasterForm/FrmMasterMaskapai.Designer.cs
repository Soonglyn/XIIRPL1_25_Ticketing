namespace XIIRPL1_25_Ticketing.MasterForm
{
    partial class Master_Maskapai
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
            btnBatal = new Button();
            nudJumlahKru = new NumericUpDown();
            rtbDeskripsi = new RichTextBox();
            label8 = new Label();
            txtPerusahaan = new TextBox();
            txtNama = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvMaskapai = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            id = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)nudJumlahKru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaskapai).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(551, 480);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 34;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(713, 480);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 33;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // nudJumlahKru
            // 
            nudJumlahKru.Location = new Point(97, 380);
            nudJumlahKru.Name = "nudJumlahKru";
            nudJumlahKru.Size = new Size(248, 23);
            nudJumlahKru.TabIndex = 32;
            // 
            // rtbDeskripsi
            // 
            rtbDeskripsi.Location = new Point(480, 301);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.Size = new Size(308, 102);
            rtbDeskripsi.TabIndex = 31;
            rtbDeskripsi.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(402, 304);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 30;
            label8.Text = "Deskripsi";
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(97, 339);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(248, 23);
            txtPerusahaan.TabIndex = 26;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(97, 301);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(248, 23);
            txtNama.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 380);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 23;
            label5.Text = "Jumlah Kru";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 342);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 22;
            label4.Text = "Perusahaan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 304);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 21;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(296, 17);
            label2.TabIndex = 20;
            label2.Text = "Semua maskapai yang terdaftar akan mucul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 19;
            label1.Text = "Master Maskapai";
            // 
            // dgvMaskapai
            // 
            dgvMaskapai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaskapai.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dgvMaskapai.Location = new Point(12, 88);
            dgvMaskapai.Name = "dgvMaskapai";
            dgvMaskapai.RowTemplate.Height = 25;
            dgvMaskapai.Size = new Size(776, 194);
            dgvMaskapai.TabIndex = 18;
            dgvMaskapai.CellContentClick += dgvMaskapai_CellContentClick;
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
            // id
            // 
            id.Location = new Point(356, 380);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 35;
            id.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(632, 480);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 36;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // Master_Maskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 551);
            Controls.Add(btnEdit);
            Controls.Add(id);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(nudJumlahKru);
            Controls.Add(rtbDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtPerusahaan);
            Controls.Add(txtNama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMaskapai);
            Name = "Master_Maskapai";
            Text = "FrmMasterMaskapai";
            Load += Master_Maskapai_Load;
            ((System.ComponentModel.ISupportInitialize)nudJumlahKru).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaskapai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnBatal;
        private NumericUpDown nudJumlahKru;
        private RichTextBox rtbDeskripsi;
        private Label label8;
        private TextBox txtPerusahaan;
        private TextBox txtNama;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvMaskapai;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}