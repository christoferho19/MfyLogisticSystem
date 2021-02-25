using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class DeleteShips : Form
    {
        public DeleteShips()
        {
            InitializeComponent();
        }

        private readonly string defaultidkpl = "kpl";


        private string idkpl = null;


        private void getseqid(int seqid)
        {
            if (seqid <= 9)
            {
                idkpl = defaultidkpl + "000" + seqid.ToString();
            }
            else if (seqid <= 99)
            {
                idkpl = defaultidkpl + "00" + seqid.ToString();
            }
            else if (seqid <= 999)
            {
                idkpl = defaultidkpl + "0" + seqid.ToString();
            }
            else if (seqid <= 9999)
            {
                idkpl = defaultidkpl + seqid.ToString();
            }
        }

        private int cntseqid(int cseqid, String kplid)
        {
            int kpid = 0;
            if (cseqid <= 9)
            {
                kpid = Convert.ToInt32(kplid.Replace("kpl000", ""));
            }
            else if (cseqid <= 99)
            {
                kpid = Convert.ToInt32(kplid.Replace("kpl00", ""));
            }
            else if (cseqid <= 999)
            {
                kpid = Convert.ToInt32(kplid.Replace("kpl0", ""));
            }
            else if (cseqid <= 9999)
            {
                kpid = Convert.ToInt32(kplid.Replace("kpl", ""));
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

            string query = "SELECT * FROM Mst_Kapal ";

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

        private void txbnama_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string constring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Perusahaan,Nama,Id_Kapal FROM Mst_Kapal where Nama like '" + txbnama.Text + "%'", conn);
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

                idkpl = Convert.ToString(selectedrowindex.Cells["Id_Kapal"].Value);

                //Check number of data
                try
                {
                    conn.Open();
                    string qseqkpl = "SELECT COUNT(Id_Kapal) FROM  Mst_Kapal";
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

                int seqnumber = cntseqid(cseqid, idkpl);

                getseqid(seqnumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Delete Table Mst_Customer,Mst_Pengirim,Mst_Penerima
            try
            {
                conn.Open();
                string qdeletekpl = "Delete From Mst_Kapal Where Id_Kapal = '" + idkpl + "'";
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

                string qselect = "SELECT * FROM Mst_Kapal ";

                conn.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(qselect, conn);
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
    }
}