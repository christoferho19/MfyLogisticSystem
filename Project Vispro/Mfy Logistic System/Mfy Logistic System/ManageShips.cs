using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class ManageShips : Form
    {
        public ManageShips()
        {
            InitializeComponent();
        }

        private readonly string Defaultidkpl = "kpl";

        private string idkpl = null;

        private void getseqidadd(int seqid)
        {
            if (seqid <= 9)
            {
                seqid = seqid + 1;
                idkpl = Defaultidkpl + "000" + seqid.ToString();
            }
            else if (seqid <= 99)
            {
                seqid = seqid + 1;
                idkpl = Defaultidkpl + "00" + seqid.ToString();
            }
            else if (seqid <= 999)
            {
                seqid = seqid + 1;
                idkpl = Defaultidkpl + "0" + seqid.ToString();
            }
            else if (seqid <= 9999)
            {
                seqid = seqid + 1;
                idkpl = Defaultidkpl + seqid.ToString();
            }
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            cmethod.checkupdatekpl = 0;
            txbperusahaan.Focus();
            btnupdate.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int seqid = 0;
            string connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            //AutoIncrement id
            try
            {
                conn.Open();
                string qseqcst = "SELECT COUNT(Id_Kapal) FROM  Mst_Kapal";
                DataTable dt = new DataTable();
                SqlCommand cnt = new SqlCommand(qseqcst, conn);
                SqlDataReader dr = cnt.ExecuteReader();
                dt.Load(dr);
                seqid = Convert.ToInt32(dt.Rows[0][0]);
                getseqidadd(seqid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            //Insert Table Customer,Penerima & Pengirim
            try
            {
                conn.Open();
                string qinsertcst = "INSERT INTO Mst_Kapal (Id_Kapal,Nama,Perusahaan) values (@a,@b,@c)";
                SqlCommand cmdkpl = new SqlCommand(qinsertcst, conn);

                cmdkpl.Parameters.AddWithValue("@a", idkpl);
                cmdkpl.Parameters.AddWithValue("@b", txbnama.Text);
                cmdkpl.Parameters.AddWithValue("@c", txbperusahaan.Text);

                int a = cmdkpl.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Kapal Berhasil ditambakan");
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

            txbperusahaan.Clear();
            txbnama.Clear();
            txbperusahaan.Focus();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NewCustomer_Activated(object sender, EventArgs e)
        {
            txbnama.Text = cmethod.selectedkplname;
            txbperusahaan.Text = cmethod.selectedkplcompany;
            txbperusahaan.Focus();
            if (cmethod.checkupdatekpl == 0)
            {
                btnupdate.Enabled = false;
            }
            else if (cmethod.checkupdatekpl == 1)
            {
                btnupdate.Enabled = true;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            idkpl = cmethod.selectedkplid;

            //Update Table Mst_Customer,Mst_Pengirim,Mst_Penerima
            try
            {
                conn.Open();
                string qupkpl = "UPDATE Mst_Kapal set Nama ='" + txbnama.Text + "',Perusahaan ='" + txbperusahaan.Text + "' Where Id_Kapal ='" + idkpl + "'";
                SqlCommand cmdup = new SqlCommand(qupkpl, conn);

                int a = cmdup.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Data Kapal Berhasil diubah");
                }
            }
            catch
            {
                MessageBox.Show("Data Kapal Gagal diubah");
            }
            finally
            {
                conn.Close();
            }

            txbperusahaan.Clear();
            txbnama.Clear();
            txbnama.Focus();
            cmethod.checkupdatekpl = 0;
            btnupdate.Enabled = false;

            cmethod.selectedkplid = null;
            cmethod.selectedkplcompany = null;
            cmethod.selectedkplname = null;
        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            txbperusahaan.Text = null;
            txbnama.Text = null;
            SearchShips fsearchships = new SearchShips();
            fsearchships.ShowDialog();
        }
    }
}