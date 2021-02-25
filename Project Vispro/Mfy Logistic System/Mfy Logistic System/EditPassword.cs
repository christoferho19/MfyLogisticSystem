using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class EditPassword : Form
    {
        public EditPassword()
        {
            InitializeComponent();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            String connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            string query = "UPDATE Userdata set Password ='" + txbnewpass.Text + "' Where Password='" + txbcurrentpass.Text + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Password Berhasil diubah");
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Password Gagal diubah");
            }
            finally
            {
                conn.Close();
            }

            txbcurrentpass.Clear();
            txbnewpass.Clear();
            txbrenewpass.Clear();
        }

        private void txbrenewpass_TextChanged(object sender, EventArgs e)
        {
            if (txbnewpass.Text != txbrenewpass.Text)
            {
                lblstatuspassword.Text = "Password yang anda masukkan tidak sama";
                btnchange.Enabled = false;
            }
            else if (txbnewpass.Text == txbrenewpass.Text)
            {
                lblstatuspassword.Text = "";
                btnchange.Enabled = true;
            }
        }

        private void EditPassword_Load(object sender, EventArgs e)
        {
            lblstatuspassword.Text = "";
        }

        private void txbrenewpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lblstatuspassword.Text == "")
                {
                    String connstring = cmethod.GetConnString();
                    SqlConnection conn = new SqlConnection(connstring);

                    string query = "UPDATE Userdata set Password ='" + txbnewpass.Text + "' Where Password='" + txbcurrentpass.Text + "'";
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);

                        int a = cmd.ExecuteNonQuery();

                        if (a > 0)
                        {
                            MessageBox.Show("Password Berhasil diubah");
                            this.Hide();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Password Gagal diubah");
                    }
                    finally
                    {
                        conn.Close();
                    }

                    txbcurrentpass.Clear();
                    txbnewpass.Clear();
                    txbrenewpass.Clear();
                }
                else if (lblstatuspassword.Text == "Password yang anda masukkan tidak sama")
                {
                    MessageBox.Show("Password yang anda masukkan belum cocok");
                }
            }
        }

        private void closepic_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}