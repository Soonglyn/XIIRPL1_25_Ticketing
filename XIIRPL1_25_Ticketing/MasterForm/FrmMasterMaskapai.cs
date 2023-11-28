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
    public partial class Master_Maskapai : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public Master_Maskapai()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl_1_25.tbl_maskapai (id,nama,perusahaan,jumlahkru,deskripsi) " +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtNama.Text + "'," +
                    "'" + txtPerusahaan.Text + "'," +
                    "'" + nudJumlahKru.Text + "'," +
                    "'" + rtbDeskripsi.Text + "')";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Maskapai");
                view_data();
                Koneksi.conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_ticket_xii_rpl_1_25.tbl_maskapai", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "db_ticket_xii_rpl_1_25.tbl_maskapai");
            dgvMaskapai.DataSource = ds.Tables[0].DefaultView;
        }
        public void nomor_urut()
        {
            int hitung, nomor;
            Koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_25.tbl_maskapai where id in(select max(id) FROM  db_ticket_xii_rpl_1_25.tbl_maskapai) order by id desc";
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

        private void dgvMaskapai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaskapai.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dgvMaskapai.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    Koneksi.conn.Open();
                    String sql = "DELETE FROM db_ticket_xii_rpl_1_25.tbl_maskapai WHERE id=@id";
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
            if (dgvMaskapai.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                id.Text = Convert.ToString(dgvMaskapai.Rows[e.RowIndex].Cells["id"].Value);
                txtNama.Text = Convert.ToString(dgvMaskapai.Rows[e.RowIndex].Cells["nama"].Value);
                txtPerusahaan.Text = Convert.ToString(dgvMaskapai.Rows[e.RowIndex].Cells["perusahaan"].Value);
                nudJumlahKru.Text = Convert.ToString(dgvMaskapai.Rows[e.RowIndex].Cells["jumlahkru"].Value);
                rtbDeskripsi.Text = Convert.ToString(dgvMaskapai.Rows[e.RowIndex].Cells["deskripsi"].Value);
                btnSimpan.Enabled = false;
            }
        }

        private void Master_Maskapai_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "UPDATE db_ticket_xii_rpl_1_25.tbl_maskapai SET " +
                    "nama = '" + txtNama.Text + "', " +
                    "perusahaan = '" + txtPerusahaan.Text + "', " +
                    "jumlahkru = '" + nudJumlahKru.Text + "', " +
                    "deskripsi = '" + rtbDeskripsi.Text + "'" +
                    "WHERE id = '" + id.Text + "'";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Ubah Data Maskapai");
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
