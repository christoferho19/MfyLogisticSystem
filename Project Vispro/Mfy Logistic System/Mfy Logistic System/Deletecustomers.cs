using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class Deletecustomers : Form
    {
        public Deletecustomers()
        {
            InitializeComponent();
        }

        private readonly string Defaultidcst = "cst";
        private readonly string Defaultidtrm = "trm";
        private readonly string Defaultidkrm = "krm";

        private string idcst = null;
        private string idtrm = null;
        private string idkrm = null;

        private void getseqid(int seqid)
        {
            if (seqid <= 9)
            {
                idcst = Defaultidcst + "000" + seqid.ToString();
                idkrm = Defaultidkrm + "000" + seqid.ToString();
                idtrm = Defaultidtrm + "000" + seqid.ToString();
            }
            else if (seqid <= 99)
            {
                idcst = Defaultidcst + "00" + seqid.ToString();
                idkrm = Defaultidkrm + "00" + seqid.ToString();
                idtrm = Defaultidtrm + "00" + seqid.ToString();
            }
            else if (seqid <= 999)
            {
                idcst = Defaultidcst + "0" + seqid.ToString();
                idkrm = Defaultidkrm + "0" + seqid.ToString();
                idtrm = Defaultidtrm + "0" + seqid.ToString();
            }
            else if (seqid <= 9999)
            {
                idcst = Defaultidcst + seqid.ToString();
                idkrm = Defaultidkrm + seqid.ToString();
                idtrm = Defaultidtrm + seqid.ToString();
            }
        }

        private int cntseqid(int cseqid, String cstid)
        {
            int csid = 0;
            if (cseqid <= 9)
            {
                csid = Convert.ToInt32(cstid.Replace("cst000", ""));
            }
            else if (cseqid <= 99)
            {
                csid = Convert.ToInt32(cstid.Replace("cst00", ""));
            }
            else if (cseqid <= 999)
            {
                csid = Convert.ToInt32(cstid.Replace("cst0", ""));
            }
            else if (cseqid <= 9999)
            {
                csid = Convert.ToInt32(cstid.Replace("cst", ""));
            }

            return (csid);
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

            string query = "SELECT * FROM Mst_Customer ";

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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Mst_Customer where Nama like '" + txbnama.Text + "%'", conn);
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

                idcst = Convert.ToString(selectedrowindex.Cells["Id_Customer"].Value);

                //Check number of data
                try
                {
                    conn.Open();
                    string qseqcst = "SELECT COUNT(Id_Customer) FROM  Mst_Customer";
                    DataTable dt = new DataTable();
                    SqlCommand cnt = new SqlCommand(qseqcst, conn);
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

                int seqnumber = cntseqid(cseqid, idcst);

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
                string qdeletekrm = "Delete From Mst_Pengirim Where Id_Pengirim = '" + idkrm + "'";
                SqlCommand cmdkrm = new SqlCommand(qdeletekrm, conn);

                int a = cmdkrm.ExecuteNonQuery();

                string qdeletetrm = "Delete From Mst_Penerima Where Id_Penerima ='" + idtrm + "'";
                SqlCommand cmdtrm = new SqlCommand(qdeletetrm, conn);

                int b = cmdtrm.ExecuteNonQuery();

                string qdeletecst = "Delete From Mst_Customer Where Id_Customer = '" + idcst + "'";
                SqlCommand cmdcst = new SqlCommand(qdeletecst, conn);

                int c = cmdcst.ExecuteNonQuery();

                if (a > 0 && b > 0 && c > 0)
                {
                    MessageBox.Show("Data Berhasil dihapus");
                }
            }
            catch
            {
                MessageBox.Show("Data Gagal dihapus");
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

                string qselect = "SELECT * FROM Mst_Customer ";

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