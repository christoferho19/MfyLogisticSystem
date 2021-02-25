using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Mfy_Logistic_System
{
    public partial class ManageUsers : Form
    {
        private string PSuserid = null;

        public ManageUsers()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            txbusername.Text = null;
            txbpassword.Text = null;
            cmbAccessLevel.SelectedItem = null;
            Searchusers fsearchusers = new Searchusers();
            fsearchusers.ShowDialog();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            cmbAccessLevel.Items.Add("1");
            cmbAccessLevel.Items.Add("2");
        }

        private void ManageUsers_Activated(object sender, EventArgs e)
        {
            txbusername.Text = cmethod.selecteduser;
            txbusername.Focus();
            cmethod.selecteduser = null;
        }

        private void cmbAccessLevel_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txbusername.Text != "")
            {
                if (txbpassword.Text != "")
                {
                    btnupdate.Enabled = true;
                    btndelete.Enabled = true;
                }
            }

           
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            string query = "UPDATE Userdata set Username ='" + txbusername.Text + "',Password ='" + txbpassword.Text + "',Level_Access ='" + cmbAccessLevel.Text + "' Where Username='" + txbusername.Text + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Data Berhasil diubah");
                }
            }
            catch
            {
                MessageBox.Show("Data Gagal diubah");
            }
            finally
            {
                conn.Close();
            }

            txbusername.Clear();
            txbpassword.Clear();
            cmbAccessLevel.SelectedItem = null;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            String connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            string query = "Delete From Userdata Where Username='" + txbusername.Text + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
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

            txbusername.Clear();
            txbpassword.Clear();
            cmbAccessLevel.SelectedItem = null;
        }

        private void txbusername_Leave(object sender, EventArgs e)
        {
            if(txbusername.Text != "")
            {
                string constring = cmethod.GetConnString();
                SqlConnection conn = new SqlConnection(constring);

                string query = "SELECT * FROM Userdata where Username like '" + txbusername.Text + "%'";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        txbpassword.Text = dr["Password"].ToString();
                        cmbAccessLevel.Text = dr["Level_Access"].ToString();
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

        private void txbusername_Enter(object sender, EventArgs e)
        {
            if(txbusername.Text == "")
            {
                txbusername.Text = null;
                txbpassword.Text = null;
                cmbAccessLevel.SelectedItem = null;
            }
            
        }
    }
}