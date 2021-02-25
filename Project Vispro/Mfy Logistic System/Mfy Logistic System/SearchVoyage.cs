using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class SearchVoyage : Form
    {
        public SearchVoyage()
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
                int voyno = Convert.ToInt32(selectedrowindex.Cells["No_Pelayaran"].Value);
                string voyid = Convert.ToString(selectedrowindex.Cells["Id_Pelayaran"].Value);
                string voyorg = Convert.ToString(selectedrowindex.Cells["Kota_Asal"].Value);
                string voyfnl = Convert.ToString(selectedrowindex.Cells["Kota_Tujuan"].Value);
                DateTime orgdt = Convert.ToDateTime(selectedrowindex.Cells["Tanggal_Berangkat"].Value);
                DateTime fnldt = Convert.ToDateTime(selectedrowindex.Cells["Tanggal_Tiba"].Value);
                string Sorgdt = Convert.ToString(orgdt);
                string Sfnldt = Convert.ToString(fnldt);

                

                try
                {
;
                    SqlCommand cmd = new SqlCommand("SELECT Id_Kapal FROM Mst_Kapal where Nama like '" + Convert.ToString(selectedrowindex.Cells["Nama"].Value) + "%'", conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        cmethod.selectedkplid = dr["Id_Kapal"].ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                cmethod.selectedvoyno = voyno;
                cmethod.selectedvoyid = voyid;
                cmethod.selectedorgcityvoy = voyorg;
                cmethod.selectedfnlcityvoy = voyfnl;
                cmethod.selectedorgdatevoy = Sorgdt;
                cmethod.selectedfnldatevoy = Sfnldt;
                cmethod.selectedkplname = shipname;

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
                SqlCommand cmd = new SqlCommand("SELECT Mst_Pelayaran.Id_Pelayaran, Mst_Kapal.Perusahaan, Mst_Kapal.Nama, Mst_Pelayaran.No_Pelayaran, Mst_Pelayaran.Kota_Asal, Mst_Pelayaran.Kota_Tujuan, Mst_Pelayaran.Tanggal_Berangkat, Mst_Pelayaran.Tanggal_Tiba FROM Mst_Pelayaran join Mst_Kapal ON Mst_Pelayaran.Id_Kapal = Mst_Kapal.Id_Kapal where No_Pelayaran like '" + txbnopelayaran.Text + "%'", conn);
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
            dataGridView1.Font = new System.Drawing.Font("Times", 10);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            string connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            string query = "SELECT Mst_Pelayaran.Id_Pelayaran, Mst_Kapal.Perusahaan,Mst_Kapal.Nama, Mst_Pelayaran.No_Pelayaran,Mst_Pelayaran.Kota_Asal,Mst_Pelayaran.Kota_Tujuan,Mst_Pelayaran.Tanggal_Berangkat,Mst_Pelayaran.Tanggal_Tiba FROM Mst_Pelayaran join Mst_Kapal ON Mst_Pelayaran.Id_Kapal = Mst_Kapal.Id_Kapal";

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