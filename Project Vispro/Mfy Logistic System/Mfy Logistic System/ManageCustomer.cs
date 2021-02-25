using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
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
                seqid = seqid + 1;
                idcst = Defaultidcst + "000" + seqid.ToString();
                idkrm = Defaultidkrm + "000" + seqid.ToString();
                idtrm = Defaultidtrm + "000" + seqid.ToString();
            }
            else if (seqid <= 99)
            {
                seqid = seqid + 1;
                idcst = Defaultidcst + "00" + seqid.ToString();
                idkrm = Defaultidkrm + "00" + seqid.ToString();
                idtrm = Defaultidtrm + "00" + seqid.ToString();
            }
            else if (seqid <= 999)
            {
                seqid = seqid + 1;
                idcst = Defaultidcst + "0" + seqid.ToString();
                idkrm = Defaultidkrm + "0" + seqid.ToString();
                idtrm = Defaultidtrm + "0" + seqid.ToString();
            }
            else if (seqid <= 9999)
            {
                seqid = seqid + 1;
                idcst = Defaultidcst + seqid.ToString();
                idkrm = Defaultidkrm + seqid.ToString();
                idtrm = Defaultidtrm + seqid.ToString();
            }
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
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
                string qseqcst = "SELECT COUNT(Id_Customer) FROM  Mst_Customer";
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

            //Insert Table Customer,Penerima & Pengirim
            try
            {
                conn.Open();
                string qinsertcst = "INSERT INTO Mst_Customer (Id_Customer,Nama,Alamat,Kota,No_Telp_1,No_Telp_2) values (@a,@b,@c,@d,@e,@f)";
                SqlCommand cmdcst = new SqlCommand(qinsertcst, conn);

                cmdcst.Parameters.AddWithValue("@a", idcst);
                cmdcst.Parameters.AddWithValue("@b", txbnama.Text);
                cmdcst.Parameters.AddWithValue("@c", txbalamat.Text);
                cmdcst.Parameters.AddWithValue("@d", txbkota.Text);
                cmdcst.Parameters.AddWithValue("@e", txbnotelp1.Text);
                if (txbnotelp2.Text == "")
                {
                    cmdcst.Parameters.AddWithValue("@f", "-");
                }
                else if (txbnotelp2.Text != "")
                {
                    cmdcst.Parameters.AddWithValue("@f", txbnotelp2.Text);
                }

                int a = cmdcst.ExecuteNonQuery();

                string qinserttrm = "INSERT INTO Mst_Penerima (Id_Penerima,Id_Customer,Nama) values (@a,@b,@c)";
                SqlCommand cmdtrm = new SqlCommand(qinserttrm, conn);

                cmdtrm.Parameters.AddWithValue("@a", idtrm);
                cmdtrm.Parameters.AddWithValue("@b", idcst);
                cmdtrm.Parameters.AddWithValue("@c", txbnama.Text);

                int b = cmdtrm.ExecuteNonQuery();

                string qinsertkrm = "INSERT INTO Mst_Pengirim (Id_Pengirim,Id_Customer,Nama) values (@a,@b,@c)";
                SqlCommand cmdkrm = new SqlCommand(qinsertkrm, conn);

                cmdkrm.Parameters.AddWithValue("@a", idkrm);
                cmdkrm.Parameters.AddWithValue("@b", idcst);
                cmdkrm.Parameters.AddWithValue("@c", txbnama.Text);

                int c = cmdkrm.ExecuteNonQuery();

                if (a > 0 && b > 0 && c > 0)
                {
                    MessageBox.Show("Customer Berhasil ditambakan");
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

            txbalamat.Clear();
            txbnama.Clear();
            txbkota.Clear();
            txbnotelp1.Clear();
            txbnotelp2.Clear();
            txbnama.Focus();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            txbalamat.Text = null;
            txbnama.Text = null;
            txbkota.Text = null;
            txbnotelp1.Text = null;
            txbnotelp2.Text = null;
            SearchCustomer fsearchcustomer = new SearchCustomer();
            fsearchcustomer.ShowDialog();
        }

        private void NewCustomer_Activated(object sender, EventArgs e)
        {
            txbnama.Text = cmethod.selectedcstname;
            txbnama.Focus();
            cmethod.selectedcstname = null;
        }

        private void txbnama_Enter(object sender, EventArgs e)
        {
            if (txbnama.Text == "")
            {
                txbalamat.Text = null;
                txbnama.Text = null;
                txbkota.Text = null;
                txbnotelp1.Text = null;
                txbnotelp2.Text = null;
            }
        }

        private void txbnama_Leave(object sender, EventArgs e)
        {
            if (txbnama.Text != "")
            {
                string constring = cmethod.GetConnString();
                SqlConnection conn = new SqlConnection(constring);

                string query = "SELECT * FROM Mst_Customer where nama like '" + txbnama.Text + "%'";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        txbnama.Text = dr["Nama"].ToString();
                        txbalamat.Text = dr["Alamat"].ToString();
                        txbkota.Text = dr["Kota"].ToString();
                        txbnotelp1.Text = dr["No_Telp_1"].ToString();
                        txbnotelp2.Text = dr["No_Telp_2"].ToString();
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
            }
        }

        private void txbnotelp1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int seqid = 0;
                string connstring = cmethod.GetConnString();
                SqlConnection conn = new SqlConnection(connstring);

                //AutoIncrement id
                try
                {
                    conn.Open();
                    string qseqcst = "SELECT COUNT(Id_Customer) FROM  Mst_Customer";
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

                //Insert Table Customer,Penerima & Pengirim
                try
                {
                    conn.Open();
                    string qinsertcst = "INSERT INTO Mst_Customer (Id_Customer,Nama,Alamat,Kota,No_Telp_1,No_Telp_2) values (@a,@b,@c,@d,@e,@f)";
                    SqlCommand cmdcst = new SqlCommand(qinsertcst, conn);

                    cmdcst.Parameters.AddWithValue("@a", idcst);
                    cmdcst.Parameters.AddWithValue("@b", txbnama.Text);
                    cmdcst.Parameters.AddWithValue("@c", txbalamat.Text);
                    cmdcst.Parameters.AddWithValue("@d", txbkota.Text);
                    cmdcst.Parameters.AddWithValue("@e", txbnotelp1.Text);
                    if (txbnotelp2.Text == "")
                    {
                        cmdcst.Parameters.AddWithValue("@f", "-");
                    }
                    else if (txbnotelp2.Text != "")
                    {
                        cmdcst.Parameters.AddWithValue("@f", txbnotelp2.Text);
                    }

                    int a = cmdcst.ExecuteNonQuery();

                    string qinserttrm = "INSERT INTO Mst_Penerima (Id_Penerima,Id_Customer) values (@a,@b)";
                    SqlCommand cmdtrm = new SqlCommand(qinserttrm, conn);

                    cmdtrm.Parameters.AddWithValue("@a", idtrm);
                    cmdtrm.Parameters.AddWithValue("@b", idcst);

                    int b = cmdtrm.ExecuteNonQuery();

                    string qinsertkrm = "INSERT INTO Mst_Pengirim (Id_Pengirim,Id_Customer) values (@a,@b)";
                    SqlCommand cmdkrm = new SqlCommand(qinsertkrm, conn);

                    cmdkrm.Parameters.AddWithValue("@a", idkrm);
                    cmdkrm.Parameters.AddWithValue("@b", idcst);

                    int c = cmdkrm.ExecuteNonQuery();

                    if (a > 0 && b > 0 && c > 0)
                    {
                        MessageBox.Show("Customer Berhasil ditambakan");
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

                txbalamat.Clear();
                txbnama.Clear();
                txbkota.Clear();
                txbnotelp1.Clear();
                txbnotelp2.Clear();
                txbnama.Focus();
            }
        }

        private void txbnotelp2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int seqid = 0;
                string connstring = cmethod.GetConnString();
                SqlConnection conn = new SqlConnection(connstring);

                //AutoIncrement id
                try
                {
                    conn.Open();
                    string qseqcst = "SELECT COUNT(Id_Customer) FROM  Mst_Customer";
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

                //Insert Table Customer,Penerima & Pengirim
                try
                {
                    conn.Open();
                    string qinsertcst = "INSERT INTO Mst_Customer (Id_Customer,Nama,Alamat,Kota,No_Telp_1,No_Telp_2) values (@a,@b,@c,@d,@e,@f)";
                    SqlCommand cmdcst = new SqlCommand(qinsertcst, conn);

                    cmdcst.Parameters.AddWithValue("@a", idcst);
                    cmdcst.Parameters.AddWithValue("@b", txbnama.Text);
                    cmdcst.Parameters.AddWithValue("@c", txbalamat.Text);
                    cmdcst.Parameters.AddWithValue("@d", txbkota.Text);
                    cmdcst.Parameters.AddWithValue("@e", txbnotelp1.Text);
                    if (txbnotelp2.Text == "")
                    {
                        cmdcst.Parameters.AddWithValue("@f", "-");
                    }
                    else if (txbnotelp2.Text != "")
                    {
                        cmdcst.Parameters.AddWithValue("@f", txbnotelp2.Text);
                    }

                    int a = cmdcst.ExecuteNonQuery();

                    string qinserttrm = "INSERT INTO Mst_Penerima (Id_Penerima,Id_Customer) values (@a,@b)";
                    SqlCommand cmdtrm = new SqlCommand(qinserttrm, conn);

                    cmdtrm.Parameters.AddWithValue("@a", idtrm);
                    cmdtrm.Parameters.AddWithValue("@b", idcst);

                    int b = cmdtrm.ExecuteNonQuery();

                    string qinsertkrm = "INSERT INTO Mst_Pengirim (Id_Pengirim,Id_Customer) values (@a,@b)";
                    SqlCommand cmdkrm = new SqlCommand(qinsertkrm, conn);

                    cmdkrm.Parameters.AddWithValue("@a", idkrm);
                    cmdkrm.Parameters.AddWithValue("@b", idcst);

                    int c = cmdkrm.ExecuteNonQuery();

                    if (a > 0 && b > 0 && c > 0)
                    {
                        MessageBox.Show("Customer Berhasil ditambakan");
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

                txbalamat.Clear();
                txbnama.Clear();
                txbkota.Clear();
                txbnotelp1.Clear();
                txbnotelp2.Clear();
                txbnama.Focus();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            string qupdatecst = "UPDATE Mst_Customer set Nama ='" + txbnama.Text + "',Alamat ='" + txbalamat.Text + "',Kota ='" + txbkota.Text + "',No_Telp_1 ='" + txbnotelp1.Text + "',No_Telp_2 ='" + txbnotelp2.Text + "' Where Nama='" + txbnama.Text + "'";
            string qupdatekrm = "UPDATE Mst_Pengirim set Nama ='" + txbnama.Text + "' Where Nama='" + txbnama.Text + "'";
            string qupdatetrm = "UPDATE Mst_Penerima set Nama ='" + txbnama.Text + "' Where Nama='" + txbnama.Text + "'";
            try
            {
                conn.Open();
                SqlCommand cmdcst = new SqlCommand(qupdatecst, conn);
                SqlCommand cmdkrm = new SqlCommand(qupdatekrm, conn);
                SqlCommand cmdtrm = new SqlCommand(qupdatetrm, conn);

                int a = cmdcst.ExecuteNonQuery();
                int b = cmdkrm.ExecuteNonQuery();
                int c = cmdtrm.ExecuteNonQuery();

                if (a > 0 && b > 0 && c > 0)
                {
                    MessageBox.Show("Data Customer Berhasil diubah");
                }
            }
            catch
            {
                MessageBox.Show("Data Customer Gagal diubah");
            }
            finally
            {
                conn.Close();
            }

            txbalamat.Clear();
            txbnama.Clear();
            txbkota.Clear();
            txbnotelp1.Clear();
            txbnotelp2.Clear();
            txbnama.Focus();
        }
    }
}