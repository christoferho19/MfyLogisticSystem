using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class ManageVoyages : Form
    {
        public ManageVoyages()
        {
            InitializeComponent();
        }

        private readonly string Defaultidvoy = "ply";

        private string idvoy = null;

        private void getseqid(int seqid)
        {
            if (seqid <= 9)
            {
                seqid = seqid + 1;
                idvoy = Defaultidvoy + "000" + seqid.ToString();
            }
            else if (seqid <= 99)
            {
                seqid = seqid + 1;
                idvoy = Defaultidvoy + "00" + seqid.ToString();
            }
            else if (seqid <= 999)
            {
                seqid = seqid + 1;
                idvoy = Defaultidvoy + "0" + seqid.ToString();
            }
            else if (seqid <= 9999)
            {
                seqid = seqid + 1;
                idvoy = Defaultidvoy + seqid.ToString();
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
                string qseqcst = "SELECT COUNT(Id_Pelayaran) FROM  Mst_Pelayaran";
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
                string qinsertvoy = "INSERT INTO Mst_Pelayaran (Id_Pelayaran,Id_Kapal,No_Pelayaran,Kota_Asal,Kota_Tujuan,Tanggal_Berangkat,Tanggal_Tiba) values (@a,@b,@c,@d,@e,@f,@g)";
                SqlCommand cmdvoy = new SqlCommand(qinsertvoy, conn);

                cmdvoy.Parameters.AddWithValue("@a", idvoy);
                cmdvoy.Parameters.AddWithValue("@b", cmethod.selectedkplid);
                cmdvoy.Parameters.AddWithValue("@c", txbno.Text);
                cmdvoy.Parameters.AddWithValue("@d", txbkotaasal.Text);
                cmdvoy.Parameters.AddWithValue("@e", txbkotatujuan.Text);
                cmdvoy.Parameters.AddWithValue("@f", datepckrberangkat.Value);
                cmdvoy.Parameters.AddWithValue("@g", datepckrtiba.Value);

                int a = cmdvoy.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Data Pelayaran Berhasil ditambakan");
                }
            }
            catch
            {
                MessageBox.Show("Data Pelayaran Gagal ditambakan");
            }
            finally
            {
                conn.Close();
            }

            txbkotaasal.Clear();
            txbno.Clear();
            txbkapal.Clear();
            txbkotatujuan.Clear();
            datepckrberangkat.Value = DateTime.Now;
            datepckrberangkat.Value = DateTime.Now;
            txbno.Focus();
            cmethod.selectedkplid = null;
            cmethod.checksearchvoy = 0;
            cmethod.checksearchship = 0;
            cmethod.checkupdatekpl = 0;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            txbkotaasal.Text = null;
            txbkapal.Text = null;
            txbno.Text = null;
            txbkotatujuan.Text = null;
            datepckrberangkat.Value = DateTime.Now;
            datepckrberangkat.Value = DateTime.Now;
            SearchVoyage fsearchVoyage = new SearchVoyage();
            fsearchVoyage.ShowDialog();
            cmethod.checksearchvoy = 1;
            cmethod.checkupdatekpl = 1;
        }

        private void NewCustomer_Activated(object sender, EventArgs e)
        {
            if (cmethod.checkupdatekpl == 1)
            {
                btnupdate.Enabled = true;
            }
            if (cmethod.checksearchvoy == 1)
            {
                txbkapal.Text = cmethod.selectedkplname;
                txbno.Text = cmethod.selectedvoyno.ToString();
                txbkotaasal.Text = cmethod.selectedorgcityvoy;
                txbkotatujuan.Text = cmethod.selectedfnlcityvoy;
                datepckrberangkat.Value = Convert.ToDateTime(cmethod.selectedorgdatevoy);
                datepckrtiba.Value = Convert.ToDateTime(cmethod.selectedfnldatevoy);
            }
            if (cmethod.checksearchship == 1)
            {
                txbkapal.Text = cmethod.selectedkplcompany + " " + cmethod.selectedkplname;
            }

            txbno.Focus();

            cmethod.selectedcstname = null;
            cmethod.selectedkplname = null;
            cmethod.selectedkplcompany = null;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            string query = "UPDATE Mst_Pelayaran set No_Pelayaran ='" + txbno.Text + "',Id_Kapal ='" + cmethod.selectedkplid + "',Kota_Asal ='" + txbkotaasal.Text + "',Kota_Tujuan ='" + txbkotatujuan.Text + "',Tanggal_Berangkat ='" + datepckrberangkat.Value + "',Tanggal_Tiba ='" + datepckrtiba.Value + "' Where Id_Pelayaran ='" + cmethod.selectedvoyid + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Data Pelayaran Berhasil diubah");
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

            txbkotaasal.Clear();
            txbkapal.Clear();
            txbno.Clear();
            txbkotatujuan.Clear();
            datepckrberangkat.Value = DateTime.Now;
            datepckrberangkat.Value = DateTime.Now;
            txbno.Focus();
            cmethod.checksearchvoy = 0;
            cmethod.checkupdatekpl = 0;
            cmethod.checksearchship = 0;
        }

        private void btnsearchkapal_Click(object sender, EventArgs e)
        {
            SearchShips fsearchkpl = new SearchShips();
            cmethod.checksearchship = 1;
            fsearchkpl.ShowDialog();
        }

        private void ManageVoyages_Load(object sender, EventArgs e)
        {
            cmethod.checksearchvoy = 0;
            cmethod.checkupdatekpl = 0;
            cmethod.checksearchship = 0;
            btnupdate.Enabled = false;
        }
    }
}