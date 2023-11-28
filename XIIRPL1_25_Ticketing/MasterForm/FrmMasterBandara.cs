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
    public partial class FrmMasterBandara : Form
    {
        ComboBoxFunction cb = new ComboBoxFunction();
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterBandara()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl_1_25.tbl_bandara (id,nama,kodeiata,kota,negaraid,jumlahterminal,alamat) " +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtNama.Text + "'," +
                    "'" + txtKodeIATA.Text + "'," +
                    "'" + txtKota.Text + "'," +
                    "'" + cbNegara.SelectedValue + "'," +
                    "'" + nudJumlahterminal.Text + "'," +
                    "'" + rtbAlamat.Text + "')";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Bandara");
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
            string sql = "SELECT db_ticket_xii_rpl_1_25.tbl_bandara.id, " +
                         "db_ticket_xii_rpl_1_25.tbl_bandara.nama, " +
                         "db_ticket_xii_rpl_1_25.tbl_bandara.kode_iata, " +
                         "db_ticket_xii_rpl_1_25.tbl_bandara.kota, " +
                         "db_ticket_xii_rpl_1_25.tbl_negara.nama, " +
                         "db_ticket_xii_rpl_1_25.tbl_bandara.jumlah_terminal " +
                         "FROM db_ticket_xii_rpl_1_25.tbl_bandara INNER JOIN " +
                         "db_ticket_xii_rpl_1_25.tbl_bandara ON db_ticket_xii_rpl_1_25.tbl_bandara.negara_id = db_ticket_xii_rpl_1_25.tbl_negara.id ";
            //NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, Koneksi.conn);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //dgvBandara.DataSource = dt;
            //dgvBandara.Columns[2].HeaderText = "ID";
            //dgvBandara.Columns[3].HeaderText = "Nama Bandara";
            //dgvBandara.Columns[4].HeaderText = "Kode IATA";
            //dgvBandara.Columns[5].HeaderText = "Kota";
            //dgvBandara.Columns[6].HeaderText = "Negara";
            //dgvBandara.Columns[7].HeaderText = "Jumlah Terminal";

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_ticket_xii_rpl_1_25.tbl_bandara", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "db_ticket_xii_rpl_1_25.tbl_bandara");
            dgvBandara.DataSource = ds.Tables[0].DefaultView;
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            Koneksi.conn.Open();
            string sql = "SELECT id FROM db_ticket_xii_rpl_1_25.tbl_bandara where id in(select max(id) FROM  db_ticket_xii_rpl_1_25.tbl_bandara) order by id desc";
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
        private void FrmMasterBandara_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();

            string query = "SELECT * FROM db_ticket_xii_rpl_1_25.tbl_negara";
            //ComboBoxFunction.Set_ComboBox(query, "nama", cbNegara);
            cbNegara.DataSource = cb.getData(query);
            cbNegara.DisplayMember = "nama";
            cbNegara.ValueMember = "id";
        }

        private void dgvBandara_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBandara.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dgvBandara.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    Koneksi.conn.Open();
                    String sql = "DELETE FROM db_ticket_xii_rpl_1_25.tbl_bandara WHERE id=@id";
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
            if (dgvBandara.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                id.Text = Convert.ToString(dgvBandara.Rows[e.RowIndex].Cells["id"].Value);
                txtNama.Text = Convert.ToString(dgvBandara.Rows[e.RowIndex].Cells["nama"].Value);
                txtKodeIATA.Text = Convert.ToString(dgvBandara.Rows[e.RowIndex].Cells["kodeiata"].Value);
                txtKota.Text = Convert.ToString(dgvBandara.Rows[e.RowIndex].Cells["kota"].Value);
                cbNegara.Text = Convert.ToString(dgvBandara.Rows[e.RowIndex].Cells["negaraid"].Value);
                nudJumlahterminal.Text = Convert.ToString(dgvBandara.Rows[e.RowIndex].Cells["jumlahterminal"].Value);
                rtbAlamat.Text = Convert.ToString(dgvBandara.Rows[e.RowIndex].Cells["alamat"].Value);
                btnSimpan.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "UPDATE db_ticket_xii_rpl_1_25.tbl_bandara SET " +
                    "nama = '" + txtNama.Text + "', " +
                    "kodeiata = '" + txtKodeIATA.Text + "', " +
                    "kota = '" + txtKota.Text + "', " +
                    "negaraid = '" + cbNegara.Text + "', " +
                    "jumlahterminal = '" + nudJumlahterminal.Text + "', " +
                    "alamat = '" + rtbAlamat.Text + "'" +
                    "WHERE id = '" + id.Text + "'";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Ubah Data Bandara");
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
