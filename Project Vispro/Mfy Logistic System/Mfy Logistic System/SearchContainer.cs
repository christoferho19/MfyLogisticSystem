using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class SearchContainer : Form
    {
        public SearchContainer()
        {
            InitializeComponent();
        }

        private static void sendvalue(DataGridView dgv)
        {
            int selectedrow = dgv.SelectedCells[0].RowIndex;
            string constring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(constring);
            DataGridViewRow selectedrowindex = dgv.Rows[selectedrow];
            try
            {
                string shipname = Convert.ToString(selectedrowindex.Cells["Perusahaan"].Value) + " " + Convert.ToString(selectedrowindex.Cells["Nama"].Value);
                string voyid = Convert.ToString(selectedrowindex.Cells["Id_Pelayaran"].Value);
                string contid = Convert.ToString(selectedrowindex.Cells["Id_Container"].Value);
                string kodecont = Convert.ToString(selectedrowindex.Cells["Kode_Segel"].Value);
                string nocont = Convert.ToString(selectedrowindex.Cells["Nomor_Segel"].Value);
                string jnsbrng = Convert.ToString(selectedrowindex.Cells["Jenis_Barang"].Value);

                //try
                //{
                //    ;
                //    SqlCommand cmd = new SqlCommand("SELECT Mst_Container.Id_Container,Mst_Container.Kode_Segel,Mst_Container.Nomor_Segel,Mst_Kapal.Perusahaan,Mst_Kapal.Nama,Mst_Pelayaran.No_Pelayaran,Mst_Container.Jenis_Barang, Mst_Pelayaran.Id_Pelayaran FROM Mst_Container JOIN Mst_Pelayaran ON Mst_Container.Id_Pelayaran = Mst_Pelayaran.Id_Pelayaran JOIN Mst_Kapal ON Mst_Pelayaran.Id_Kapal = Mst_Kapal.Id_Kapal where Kode_Segel like '" + Convert.ToString(selectedrowindex.Cells["Kode_Segel"].Value) + "%'", conn);
                //    conn.Open();
                //    SqlDataReader dr = cmd.ExecuteReader();

                //    while (dr.Read())
                //    {
                //        cmethod.selectedcontid = dr["Id_Container"].ToString();
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                //finally
                //{
                //    conn.Close();
                //}

                cmethod.selectedkplname = shipname;
                cmethod.selectedvoyid = voyid;
                cmethod.selectedcontcode = kodecont;
                cmethod.selectedcontno = nocont;
                cmethod.selectedcontitem = jnsbrng;
                cmethod.selectedcontid = contid;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txbusername_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string constring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Mst_Container.Id_Container,Mst_Container.Kode_Segel,Mst_Container.Nomor_Segel,Mst_Kapal.Perusahaan,Mst_Kapal.Nama,Mst_Pelayaran.No_Pelayaran,Mst_Container.Jenis_Barang, Mst_Pelayaran.Id_Pelayaran FROM Mst_Container JOIN Mst_Pelayaran ON Mst_Container.Id_Pelayaran = Mst_Pelayaran.Id_Pelayaran JOIN Mst_Kapal ON Mst_Pelayaran.Id_Kapal = Mst_Kapal.Id_Kapal where Mst_Container.Kode_Segel like '" + txbkodecont.Text + "%'", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);
                reader.Close();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Searchusers_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new System.Drawing.Font("Times", 12);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            string connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            string query = "SELECT Mst_Container.Id_Container,Mst_Container.Kode_Segel,Mst_Container.Nomor_Segel,Mst_Kapal.Perusahaan,Mst_Kapal.Nama,Mst_Pelayaran.No_Pelayaran,Mst_Container.Jenis_Barang, Mst_Pelayaran.Id_Pelayaran FROM Mst_Container JOIN Mst_Pelayaran ON Mst_Container.Id_Pelayaran = Mst_Pelayaran.Id_Pelayaran JOIN Mst_Kapal ON Mst_Pelayaran.Id_Kapal = Mst_Kapal.Id_Kapal";

            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            sendvalue(dataGridView1);
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txbusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendvalue(dataGridView1);
                this.Hide();
            }
        }
    }
}