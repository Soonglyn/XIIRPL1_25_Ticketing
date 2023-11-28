using Npgsql;
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
    public partial class FrmMasterKodePromo : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterKodePromo()
        {
            InitializeComponent();
        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_ticket_xii_rpl_1_25.tbl_kode_promo", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "db_ticket_xii_rpl_1_25.tbl_kode_promo");
            dgvKodePromo.DataSource = ds.Tables[0].DefaultView;
        }
        public void nomor_urut()
        {
            int hitung, nomor;
            Koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_25.tbl_kode_promo where id in(select max(id) FROM  db_ticket_xii_rpl_1_25.tbl_kode_promo) order by id desc";
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
        private void FrmMasterKodePromo_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl_1_25.tbl_kode_promo (id,kode,berlaku_sampai,persentase_diskon,maksimum_diskon,deskripsi) " +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtKodePromo.Text + "'," +
                    "'" + dtpBerlaku.Text + "'," +
                    "'" + nudPersen.Text + "'," +
                    "'" + nudMaksi.Text + "'," +
                    "'" + rtbDeskripsi.Text + "')";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Kode Promo");
                Koneksi.conn.Close();
                view_data();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Koneksi.conn.Close();
            }
        }

        private void dgvKodePromo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKodePromo.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dgvKodePromo.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    Koneksi.conn.Open();
                    String sql = "DELETE FROM db_ticket_xii_rpl_1_25.tbl_kode_promo WHERE id=@id";
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
            if (dgvKodePromo.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                id.Text = Convert.ToString(dgvKodePromo.Rows[e.RowIndex].Cells["id"].Value);
                txtKodePromo.Text = Convert.ToString(dgvKodePromo.Rows[e.RowIndex].Cells["kode"].Value);
                dtpBerlaku.Text = Convert.ToString(dgvKodePromo.Rows[e.RowIndex].Cells["berlaku_sampai"].Value);
                nudPersen.Text = Convert.ToString(dgvKodePromo.Rows[e.RowIndex].Cells["persentase_diskon"].Value);
                nudMaksi.Text = Convert.ToString(dgvKodePromo.Rows[e.RowIndex].Cells["maksimum_diskon"].Value);
                rtbDeskripsi.Text = Convert.ToString(dgvKodePromo.Rows[e.RowIndex].Cells["deskripsi"].Value);
                btnSimpan.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "UPDATE db_ticket_xii_rpl_1_25.tbl_kode_promo SET " +
                    "kode = '" + txtKodePromo.Text + "', " +
                    "berlaku_sampai = '" + dtpBerlaku.Text + "', " +
                    "persentase_diskon = '" + nudPersen.Text + "', " +
                    "maksimum_diskon = '" + nudMaksi.Text + "', " +
                    "deskripsi = '" + rtbDeskripsi.Text + "'" +
                    "WHERE id = '" + id.Text + "'";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Ubah Data Kode Promo");
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
