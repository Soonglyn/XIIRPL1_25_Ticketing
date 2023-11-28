using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIIRPL1_25_Ticketing.MasterForm
{
    public partial class FrmMasterJadwalPenerbangan : Form
    {
        ComboBoxFunction cb = new ComboBoxFunction();
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterJadwalPenerbangan()
        {
            InitializeComponent();
        }
        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_ticket_xii_rpl_1_25.tbl_jadwal_penerbangan", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "db_ticket_xii_rpl_1_25.tbl_jadwal_penerbangan");
            dgvJadwalPenerbangan.DataSource = ds.Tables[0].DefaultView;
        }
        public void nomor_urut()
        {
            int hitung, nomor;
            Koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_25.tbl_jadwal_penerbangan where id in(select max(id) FROM  db_ticket_xii_rpl_1_25.tbl_jadwal_penerbangan) order by id desc";
            NpgsqlCommand
            cmd = new NpgsqlCommand(sql, Koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                nomor = Convert.ToInt32(dr[0]);
                hitung = nomor + 1;
            }
            else
            {
                hitung = 1;
            }
            dr.Close();
            id.Text = Convert.ToString(hitung);
            Koneksi.conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl_1_25.tbl_jadwal_penerbangan (id,kode_penerbangan,bandara_keberangkatan_id,bandara_tujuan_id,maskapai_id,tanggal_keberangkatan,durasi_penerbangan,harga_tiket,waktu_keberangkatan) " +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtKodePenerbangan.Text + "'," +
                    "'" + cbDari.SelectedValue + "'," +
                    "'" + cbKe.SelectedValue + "'," +
                    "'" + cbMaskapai.SelectedValue + "'," +
                    "'" + dtpTanggal.Text + "'," +
                    "'" + txtDurasi.Text + "'," +
                    "'" + nudHarga.Text + "'," +
                    "'" + txtWaktu.Value + "')";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Jadwal Penerbangan");
                Koneksi.conn.Close();
                view_data();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Koneksi.conn.Close();
            }
        }
        private void FrmMasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();
            txtWaktu = new DateTimePicker();
            txtWaktu.Format = DateTimePickerFormat.Time;
            txtWaktu.ShowUpDown = true;

            string query = "SELECT * FROM db_ticket_xii_rpl_1_25.tbl_bandara";
            //ComboBoxFunction.Set_ComboBox(query, "nama", cbDari);
            cbDari.DataSource = cb.getData(query);
            cbDari.DisplayMember = "nama";
            cbDari.ValueMember = "id";

            string query2 = "SELECT * FROM db_ticket_xii_rpl_1_25.tbl_bandara";
            //ComboBoxFunction.Set_ComboBox(query2, "nama", cbKe);
            cbKe.DataSource = cb.getData(query2);
            cbKe.DisplayMember = "nama";
            cbKe.ValueMember = "id";

            string query3 = "SELECT * FROM db_ticket_xii_rpl_1_25.tbl_maskapai";
            //ComboBoxFunction.Set_ComboBox(query3, "nama", cbMaskapai);
            cbMaskapai.DataSource = cb.getData(query3);
            cbMaskapai.DisplayMember = "nama";
            cbMaskapai.ValueMember = "id";
        }

        private void dgvJadwalPenerbangan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvJadwalPenerbangan.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    Koneksi.conn.Open();
                    String sql = "DELETE FROM db_ticket_xii_rpl_1_25.tbl_jadwal_penerbangan WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, Koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Berhasil dihapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil dihapus");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Koneksi.conn.Close();
                }
            }
            if (dgvJadwalPenerbangan.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                id.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["id"].Value);
                txtKodePenerbangan.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["kode_penerbangan"].Value);
                cbDari.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["bandara_keberangkatan_id"].Value);
                cbKe.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["bandara_tujuan_id"].Value);
                cbMaskapai.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["maskapai_id"].Value);
                dtpTanggal.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["tanggal_keberangkatan"].Value);
                txtDurasi.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["durasi_penerbangan"].Value);
                nudHarga.Text = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["harga_tiket"].Value);
                //txtWaktu.Value = Convert.ToString(dgvJadwalPenerbangan.Rows[e.RowIndex].Cells["waktu_keberangkatan"].Value);
                btnSimpan.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "UPDATE db_ticket_xii_rpl_1_25.tbl_jadwal_penerbangan SET " +
                    "kode_penerbangan = '" + txtKodePenerbangan.Text + "', " +
                    "bandara_keberangkatan_id = '" + cbDari.Text + "', " +
                    "bandara_tujuan_id = '" + cbKe.Text + "', " +
                    "maskapai_id = '" + cbMaskapai.Text + "', " +
                    "tanggal_keberangkatan = '" + dtpTanggal.Text + "', " +
                    "durasi_penerbangan = '" + txtDurasi.Text + "'," +
                    "harga_tiket = '" + nudHarga.Text + "'," +
                    "waktu_keberangkatan = '" + txtWaktu.Value + "'" +
                    "WHERE id = '" + id.Text + "'";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Ubah Data Jadwal Penerbangan");
                view_data();
                Koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
