using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class DeleteVoyage : Form
    {
        public DeleteVoyage()
        {
            InitializeComponent();
        }

        private readonly string defaultidvoy = "ply";


        private string idvoy = null;


        private void getseqid(int seqid)
        {
            if (seqid <= 9)
            {
                idvoy = defaultidvoy + "000" + seqid.ToString();
            }
            else if (seqid <= 99)
            {
                idvoy = defaultidvoy + "00" + seqid.ToString();
            }
            else if (seqid <= 999)
            {
                idvoy = defaultidvoy + "0" + seqid.ToString();
            }
            else if (seqid <= 9999)
            {
                idvoy = defaultidvoy + seqid.ToString();
            }
        }

        private int cntseqid(int cseqid, String kplid)
        {
            int kpid = 0;
            if (cseqid <= 9)
            {
                kpid = Convert.ToInt32(kplid.Replace("ply000", ""));
            }
            else if (cseqid <= 99)
            {
                kpid = Convert.ToInt32(kplid.Replace("ply00", ""));
            }
            else if (cseqid <= 999)
            {
                kpid = Convert.ToInt32(kplid.Replace("ply0", ""));
            }
            else if (cseqid <= 9999)
            {
                kpid = Convert.ToInt32(kplid.Replace("ply", ""));
            }

            return (kpid);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Viewusers_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new System.Drawing.Font("Times", 12);
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
                dataGridView1.Sort(dataGridView1.Columns["Id_Pelayaran"], System.ComponentModel.ListSortDirection.Ascending);
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

        private void txbnama_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string constring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string query = "SELECT Mst_Pelayaran.Id_Pelayaran, Mst_Kapal.Perusahaan,Mst_Kapal.Nama, Mst_Pelayaran.No_Pelayaran,Mst_Pelayaran.Kota_Asal,Mst_Pelayaran.Kota_Tujuan,Mst_Pelayaran.Tanggal_Berangkat,Mst_Pelayaran.Tanggal_Tiba FROM Mst_Pelayaran join Mst_Kapal ON Mst_Pelayaran.Id_Kapal = Mst_Kapal.Id_Kapal";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);
                reader.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.Sort(dataGridView1.Columns["Id_Pelayaran"], System.ComponentModel.ListSortDirection.Ascending);
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            int cseqid = 0;
            String connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            //Get Sequence Id
            try
            {
                int selectedrow = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedrowindex = dataGridView1.Rows[selectedrow];

                idvoy = Convert.ToString(selectedrowindex.Cells["Id_Pelayaran"].Value);

                //Check number of data
                try
                {
                    conn.Open();
                    string qseqkpl = "SELECT COUNT(Id_Pelayaran) FROM  Mst_Pelayaran";
                    DataTable dt = new DataTable();
                    SqlCommand cnt = new SqlCommand(qseqkpl, conn);
                    SqlDataReader dr = cnt.ExecuteReader();
                    dt.Load(dr);
                    cseqid = Convert.ToInt32(dt.Rows[0][0]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                int seqnumber = cntseqid(cseqid, idvoy);

                getseqid(seqnumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Delete Table Mst_Pelayaran
            try
            {
                conn.Open();
                string qdeletekpl = "Delete From Mst_Pelayaran Where Id_Pelayaran = '" + idvoy + "'";
                SqlCommand cmdkrm = new SqlCommand(qdeletekpl, conn);

                int a = cmdkrm.ExecuteNonQuery();


                if (a > 0 )
                {
                    MessageBox.Show("Data Kapal Berhasil dihapus");
                }
            }
            catch
            {
                MessageBox.Show("Data Kapal Gagal dihapus");
            }
            finally
            {
                conn.Close();
            }

            //Re-Load Datagridview
            try
            {
                dataGridView1.Font = new System.Drawing.Font("Times", 12);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                

                string qselect = "SELECT Mst_Pelayaran.Id_Pelayaran, Mst_Kapal.Perusahaan,Mst_Kapal.Nama, Mst_Pelayaran.No_Pelayaran,Mst_Pelayaran.Kota_Asal,Mst_Pelayaran.Kota_Tujuan,Mst_Pelayaran.Tanggal_Berangkat,Mst_Pelayaran.Tanggal_Tiba FROM Mst_Pelayaran join Mst_Kapal ON Mst_Pelayaran.Id_Kapal = Mst_Kapal.Id_Kapal"; ;

                conn.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(qselect, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dataGridView1.Sort(dataGridView1.Columns["Id_Pelayaran"], System.ComponentModel.ListSortDirection.Ascending);
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
    }
}