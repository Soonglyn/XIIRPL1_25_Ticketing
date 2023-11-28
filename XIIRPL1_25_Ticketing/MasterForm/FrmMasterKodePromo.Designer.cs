namespace XIIRPL1_25_Ticketing.MasterForm
{
    partial class FrmMasterKodePromo
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
            btnEdit = new Button();
            nudPersen = new NumericUpDown();
            rtbDeskripsi = new RichTextBox();
            label8 = new Label();
            txtKodePromo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvKodePromo = new DataGridView();
            label6 = new Label();
            nudMaksi = new NumericUpDown();
            dtpBerlaku = new DateTimePicker();
            label7 = new Label();
            id = new TextBox();
            button2 = new Button();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)nudPersen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKodePromo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaksi).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(551, 485);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 47;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(632, 485);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 46;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // nudPersen
            // 
            nudPersen.Location = new Point(125, 385);
            nudPersen.Name = "nudPersen";
            nudPersen.Size = new Size(250, 23);
            nudPersen.TabIndex = 45;
            // 
            // rtbDeskripsi
            // 
            rtbDeskripsi.Location = new Point(480, 306);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.Size = new Size(308, 102);
            rtbDeskripsi.TabIndex = 44;
            rtbDeskripsi.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(402, 309);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 43;
            label8.Text = "Deskripsi";
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(125, 306);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(250, 23);
            txtKodePromo.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 385);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 40;
            label5.Text = "Persentase Diskon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 347);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 39;
            label4.Text = "Berlaku Sampai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 309);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 38;
            label3.Text = "Kode Promo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(296, 17);
            label2.TabIndex = 37;
            label2.Text = "Semua maskapai yang terdaftar akan mucul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, -21);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 36;
            label1.Text = "Master Maskapai";
            // 
            // dgvKodePromo
            // 
            dgvKodePromo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKodePromo.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dgvKodePromo.Location = new Point(12, 93);
            dgvKodePromo.Name = "dgvKodePromo";
            dgvKodePromo.RowTemplate.Height = 25;
            dgvKodePromo.Size = new Size(776, 194);
            dgvKodePromo.TabIndex = 35;
            dgvKodePromo.CellContentClick += dgvKodePromo_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 424);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 48;
            label6.Text = "Maksimum Diskon";
            // 
            // nudMaksi
            // 
            nudMaksi.Location = new Point(125, 422);
            nudMaksi.Name = "nudMaksi";
            nudMaksi.Size = new Size(250, 23);
            nudMaksi.TabIndex = 49;
            // 
            // dtpBerlaku
            // 
            dtpBerlaku.CustomFormat = "dd-mm-yyyy";
            dtpBerlaku.Location = new Point(125, 347);
            dtpBerlaku.Name = "dtpBerlaku";
            dtpBerlaku.Size = new Size(250, 23);
            dtpBerlaku.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(190, 25);
            label7.TabIndex = 51;
            label7.Text = "Master Kode Promo";
            // 
            // id
            // 
            id.Location = new Point(391, 421);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 52;
            id.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(713, 485);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 53;
            button2.Text = "Batal";
            button2.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // FrmMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 559);
            Controls.Add(button2);
            Controls.Add(id);
            Controls.Add(label7);
            Controls.Add(dtpBerlaku);
            Controls.Add(nudMaksi);
            Controls.Add(label6);
            Controls.Add(btnSimpan);
            Controls.Add(btnEdit);
            Controls.Add(nudPersen);
            Controls.Add(rtbDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtKodePromo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvKodePromo);
            Name = "FrmMasterKodePromo";
            Text = "FrmMasterKodePromo";
            Load += FrmMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)nudPersen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKodePromo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaksi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnEdit;
        private NumericUpDown nudPersen;
        private RichTextBox rtbDeskripsi;
        private Label label8;
        private TextBox txtKodePromo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvKodePromo;
        private Label label6;
        private NumericUpDown nudMaksi;
        private DateTimePicker dtpBerlaku;
        private Label label7;
        private TextBox id;
        private Button button2;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}