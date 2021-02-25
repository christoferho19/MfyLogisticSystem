using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            lblstatuspassword.Text = "";

            cmbAccessLevel.Items.Add("1");
            cmbAccessLevel.Items.Add("2");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            string connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            string query = "SELECT * FROM Userdata ";

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

        private void btnadd_Click(object sender, EventArgs e)
        {
            string connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            string query1 = "INSERT INTO Userdata (Username,Password,Level_Access) values (@a,@b,@c)";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query1, conn);
                cmd.Parameters.AddWithValue("@a", txbusername.Text);
                cmd.Parameters.AddWithValue("@b", txbrepassword.Text);
                cmd.Parameters.AddWithValue("@c", Convert.ToInt32(cmbAccessLevel.SelectedItem));

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("User Berhasil ditambakan");
                }
            }
            catch
            {
                MessageBox.Show("User Gagal ditambahkan");
            }
            finally
            {
                conn.Close();
            }
            txbpassword.Clear();
            txbusername.Clear();
            txbrepassword.Clear();
            cmbAccessLevel.SelectedIndex = 0;

            string query2 = "SELECT * FROM Userdata ";

            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query2, conn);
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

            btnadd.Enabled = false;
        }

        private void cmbAccessLevel_SelectedValueChanged(object sender, EventArgs e)
        {
            Boolean checktxb = false;
            if (txbusername.Text != "")
            {
                if (txbpassword.Text != "")
                {
                    if (txbrepassword.Text != "")
                    {
                        checktxb = true;
                    }
                }
            }

            if (checktxb == true)
            {
                btnadd.Enabled = true;
            }
        }

        private void txbrepassword_TextChanged(object sender, EventArgs e)
        {
            if (txbpassword.Text != txbrepassword.Text)
            {
                lblstatuspassword.Text = "Password yang anda masukkan tidak sama";
            }
            else if (txbrepassword.Text == txbrepassword.Text)
            {
                lblstatuspassword.Text = "";
            }
        }
    }
}