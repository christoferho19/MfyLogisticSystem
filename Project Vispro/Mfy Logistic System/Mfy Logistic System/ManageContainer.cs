using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class ManageContainer : Form
    {
        public ManageContainer()
        {
            InitializeComponent();
        }

        private readonly string Defaultidcont = "cnt";

        private string idcnt = null;

        private void getseqid(int seqid)
        {
            if (seqid <= 9)
            {
                seqid = seqid + 1;
                idcnt = Defaultidcont + "000" + seqid.ToString();
            }
            else if (seqid <= 99)
            {
                seqid = seqid + 1;
                idcnt = Defaultidcont + "00" + seqid.ToString();
            }
            else if (seqid <= 999)
            {
                seqid = seqid + 1;
                idcnt = Defaultidcont + "0" + seqid.ToString();
            }
            else if (seqid <= 9999)
            {
                seqid = seqid + 1;
                idcnt = Defaultidcont + seqid.ToString();
            }
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
                string qseqcst = "SELECT COUNT(Id_Container) FROM  Mst_Container";
                DataTable dt = new DataTable();
                SqlCommand cnt = new SqlCommand(qseqcst, conn);
                SqlDataReader dr = cnt.ExecuteReader();
                dt.Load(dr);
                seqid = Convert.ToInt32(dt.Rows[0][0]);
                getseqid(seqid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            //Insert Table Pelayaran
            try
            {
                conn.Open();
                string qinsertvoy = "INSERT INTO Mst_Container (Id_Pelayaran,Id_Container,Kode_Segel,Nomor_Segel,Jenis_Barang) values (@a,@b,@c,@d,@e)";
                SqlCommand cmdvoy = new SqlCommand(qinsertvoy, conn);

                cmdvoy.Parameters.AddWithValue("@a", cmethod.selectedvoyid);
                cmdvoy.Parameters.AddWithValue("@b", idcnt);
                cmdvoy.Parameters.AddWithValue("@c", txbkodesegel.Text);
                cmdvoy.Parameters.AddWithValue("@d", txbnomorsegel.Text);
                cmdvoy.Parameters.AddWithValue("@e", txbjenisbarang.Text);

                int a = cmdvoy.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Data Container Berhasil ditambakan");
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

            txbnomorsegel.Clear();
            txbkodesegel.Clear();
            txbpelayaran.Clear();
            txbjenisbarang.Clear();
            txbkodesegel.Focus();
            cmethod.selectedvoyid = null;
            cmethod.checksearchcont = 0;
            cmethod.checksearchship = 0;
            cmethod.checkupdatekpl = 0;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            txbnomorsegel.Text = null;
            txbpelayaran.Text = null;
            txbkodesegel.Text = null;
            txbjenisbarang.Text = null;
            SearchVoyage fsearchVoyage = new SearchVoyage();
            fsearchVoyage.ShowDialog();
            cmethod.checkupdatekpl = 1;
        }

        private void NewCustomer_Activated(object sender, EventArgs e)
        {
            if (cmethod.checkupdatekpl == 1)
            {
                btnupdate.Enabled = true;
            }
            if (cmethod.checksearchcont == 1)
            {
                txbpelayaran.Text = cmethod.selectedkplname;
                txbkodesegel.Text = cmethod.selectedcontcode;
                txbnomorsegel.Text = cmethod.selectedcontno;
                txbjenisbarang.Text = cmethod.selectedcontitem;

            }
            if (cmethod.checksearchship == 1)
            {
                txbpelayaran.Text = cmethod.selectedkplcompany + " " + cmethod.selectedkplname;
            }

            txbkodesegel.Focus();
            cmethod.selectedkplname = null;
            cmethod.selectedkplcompany = null;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            string query = "UPDATE Mst_Container set Id_Pelayaran ='" + cmethod.selectedvoyid + "',Kode_Segel ='" + txbkodesegel.Text + "',Nomor_Segel ='" + txbnomorsegel.Text + "',Jenis_Barang ='" + txbjenisbarang.Text + "' Where Id_Container ='" + cmethod.selectedcontid + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Data Container Berhasil diubah");
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

            txbnomorsegel.Clear();
            txbpelayaran.Clear();
            txbkodesegel.Clear();
            txbjenisbarang.Clear();
            txbkodesegel.Focus();
            cmethod.checksearchcont = 0;
            cmethod.checkupdatekpl = 0;
            cmethod.checksearchship = 0;
        }

        private void btnsearchkapal_Click(object sender, EventArgs e)
        {
            SearchVoyage fsearchvoy = new SearchVoyage();
            cmethod.checksearchship = 1;
            fsearchvoy.ShowDialog();
        }

        private void ManageVoyages_Load(object sender, EventArgs e)
        {
            cmethod.checksearchcont = 0;
            cmethod.checkupdatekpl = 0;
            cmethod.checksearchship = 0;
            btnupdate.Enabled = false;
        }

        private void btnsearchply_Click(object sender, EventArgs e)
        {
            SearchContainer fsearchcont = new SearchContainer();
            fsearchcont.ShowDialog();
            cmethod.checksearchcont = 1;
            cmethod.checkupdatekpl = 1;
        }
    }
}