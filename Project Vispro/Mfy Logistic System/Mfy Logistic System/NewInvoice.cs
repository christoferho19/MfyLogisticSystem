using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Mfy_Logistic_System
{
    public partial class NewInvoice : Form
    {

        private readonly string Defaultidinvc = "inv";

        private string idinv = null;

        private void getseqid(int seqid)
        {
            if (seqid <= 9)
            {
                seqid = seqid + 1;
                idinv = Defaultidinvc + "000" + seqid.ToString();
            }
            else if (seqid <= 99)
            {
                seqid = seqid + 1;
                idinv = Defaultidinvc + "00" + seqid.ToString();
            }
            else if (seqid <= 999)
            {
                seqid = seqid + 1;
                idinv = Defaultidinvc + "0" + seqid.ToString();
            }
            else if (seqid <= 9999)
            {
                seqid = seqid + 1;
                idinv = Defaultidinvc + seqid.ToString();
            }
        }
        public NewInvoice()
        {
            InitializeComponent();
        }

        private void NewInvoice_Activated(object sender, EventArgs e)
        {
            txbpelayaran.Text = cmethod.selectedkplcompany + cmethod.selectedkplname + " Voy " + Convert.ToString(cmethod.selectedvoyno);
            txbcontainer.Text = cmethod.selectedcontcode + " " + cmethod.selectedcontno;
            txbpengirim.Text = cmethod.selectedsndname;
            txbpenerima.Text = cmethod.selectedrcvname;
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
                string qseqcst = "SELECT COUNT(Id_Invoice) FROM  Mst_Invoice";
                DataTable dt = new DataTable();
                SqlCommand inv = new SqlCommand(qseqcst, conn);
                SqlDataReader dr = inv.ExecuteReader();
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

            //Insert Table Invoice
            try
            {
                conn.Open();
                string qinsertinv = "INSERT INTO Mst_Invoice (Id_Invoice,Total_Pembayaran,Status_Pembayaran,Tanggal_Cetak,Tanggal_Lunas) values (@a,@b,@c,@d,@e)";
                SqlCommand cmdinv = new SqlCommand(qinsertinv, conn);

                cmdinv.Parameters.AddWithValue("@a", idinv);
                cmdinv.Parameters.AddWithValue("@b", txbtotalbayar.Text);
                cmdinv.Parameters.AddWithValue("@c", txbstatusbayar.Text);
                cmdinv.Parameters.AddWithValue("@d", DateTime.Today);
                if(txbstatusbayar.Text == "Lunas")
                {
                    cmdinv.Parameters.AddWithValue("@e", DateTime.Today);
                }
                else
                {
                    cmdinv.Parameters.AddWithValue("@e", null);
                }

                int a = cmdinv.ExecuteNonQuery();

                string qinsertfinv = "INSERT INTO Invoice (Id_Invoice,Id_Pelayaran,Id_Container,Id_Pengirim,Id_Penerima) values (@a,@b,@c,@d,@e)";
                SqlCommand cmdfinv = new SqlCommand(qinsertfinv, conn);

                cmdfinv.Parameters.AddWithValue("@a", idinv);
                cmdfinv.Parameters.AddWithValue("@b", cmethod.selectedvoyid);
                cmdfinv.Parameters.AddWithValue("@c", cmethod.selectedcontid);
                cmdfinv.Parameters.AddWithValue("@d", cmethod.selectedsndid);
                cmdfinv.Parameters.AddWithValue("@e", cmethod.selectedrcvid);

                int b = cmdfinv.ExecuteNonQuery();

                if (a > 0 && b > 0)
                {
                    MessageBox.Show("Data Invoice Berhasil ditambakan");
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

            txbpelayaran.Clear();
            txbcontainer.Clear();
            txbpenerima.Clear();
            txbpengirim.Clear();
            txbstatusbayar.Clear();
            txbtotalbayar.Clear();

            cmethod.selectedkplcompany = null;
            cmethod.selectedkplname = null;
            cmethod.selectedvoyno = 0;
            cmethod.selectedcontcode = null;
            cmethod.selectedcontno = null;
            cmethod.selectedsndname = null;
            cmethod.selectedrcvname = null;
        }

        private void btnsearchcont_Click_1(object sender, EventArgs e)
        {
            SearchContainer fsearchcont = new SearchContainer();
            fsearchcont.ShowDialog();
        }

        private void btnsearchpengirim_Click_1(object sender, EventArgs e)
        {
            SearchSender fsearchsndr = new SearchSender();
            fsearchsndr.ShowDialog();
        }

        private void btnsearchpenerima_Click_1(object sender, EventArgs e)
        {
            SearchReceiver fsearchrcvr = new SearchReceiver();
            fsearchrcvr.ShowDialog();
        }

        private void btnsearchvoy_Click(object sender, EventArgs e)
        {
            SearchVoyage fsearchvoy = new SearchVoyage();
            fsearchvoy.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Invoice crInvoice = new Invoice();
        //string formula = null;

        //formula = "{Mst_Pelayaran.No_Pelayaran} = '" + cmethod.selectedcontno + "'and {Mst_Container.Kode_Segel} = '" + cmethod.selectedcontcode + "'and {Mst_Container.Nomor_Segel} = '" + cmethod.selectedcontno + "' and {Mst_Pengirim.Id_Pengirim} = '" + cmethod.selectedsndid + "'and {Mst_Penerima.Id_Penerima} = '" + cmethod.selectedrcvid + "'";
    }
}