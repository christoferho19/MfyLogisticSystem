using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbusername.Text == "")
            {
                MessageBox.Show("Mohon isi username anda");
            }
            else if (txbpassword.Text == "")
            {
                MessageBox.Show("Mohon isi password anda");
            }
            else
            {
                string connstring = @"Data Source=MICHELLE;Initial Catalog=ProjectMfy;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connstring);

                string query = "SELECT * FROM Userdata ";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (txbusername.Text == dr["Username"].ToString() && txbpassword.Text == dr["Password"].ToString())
                        {
                            if (dr["Level_Access"].ToString() == "1")
                            {
                                HomepageAdmin homeadmin = new HomepageAdmin(txbusername.Text);
                                this.Hide();
                                homeadmin.Show();
                                break;
                            }
                            else if (dr["Level_Access"].ToString() == "2")
                            {
                                Homepage homeuser = new Homepage(txbusername.Text);
                                this.Hide();
                                homeuser.Show();
                                break;
                            }
                        }
                        else if (txbusername.Text != dr["Username"].ToString())
                        {
                            MessageBox.Show("Username atau Password yang anda masukkan salah");
                            txbusername.Clear();
                            txbpassword.Clear();
                            break;
                        }
                        else if (txbpassword.Text != dr["Password"].ToString())
                        {
                            MessageBox.Show("Username atau Password yang anda masukkan salah");
                            txbusername.Clear();
                            txbpassword.Clear();
                            break;
                        }
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

        private void txbusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txbusername.Text == "")
                {
                    MessageBox.Show("Mohon isi username anda");
                }
                else if (txbpassword.Text == "")
                {
                    MessageBox.Show("Mohon isi password anda");
                }
                else
                {
                    string connstring = @"Data Source=MICHELLE;Initial Catalog=ProjectMfy;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connstring);

                    string query = "SELECT * FROM Userdata ";
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            if (txbusername.Text == dr["Username"].ToString() && txbpassword.Text == dr["Password"].ToString())
                            {
                                if (dr["Level_Access"].ToString() == "1")
                                {
                                    HomepageAdmin homeadmin = new HomepageAdmin(txbusername.Text);
                                    this.Hide();
                                    homeadmin.Show();
                                    break;
                                }
                                else if (dr["Level_Access"].ToString() == "2")
                                {
                                    Homepage homeuser = new Homepage(txbusername.Text);
                                    this.Hide();
                                    homeuser.Show();
                                    break;
                                }
                            }
                            else if (txbusername.Text != dr["Username"].ToString())
                            {
                                MessageBox.Show("Username atau Password yang anda masukkan salah");
                                txbusername.Clear();
                                txbpassword.Clear();
                                break;
                            }
                            else if (txbpassword.Text != dr["Password"].ToString())
                            {
                                MessageBox.Show("Username atau Password yang anda masukkan salah");
                                txbusername.Clear();
                                txbpassword.Clear();
                                break;
                            }
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
        }

        private void txbpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txbusername.Text == "")
                {
                    MessageBox.Show("Mohon isi username anda");
                }
                else if (txbpassword.Text == "")
                {
                    MessageBox.Show("Mohon isi password anda");
                }
                else
                {
                    string connstring = @"Data Source=MICHELLE;Initial Catalog=ProjectMfy;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connstring);

                    string query = "SELECT * FROM Userdata ";
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            if (txbusername.Text == dr["Username"].ToString() && txbpassword.Text == dr["Password"].ToString())
                            {
                                if (dr["Level_Access"].ToString() == "1")
                                {
                                    HomepageAdmin homeadmin = new HomepageAdmin(txbusername.Text);
                                    this.Hide();
                                    homeadmin.Show();
                                    break;
                                }
                                else if (dr["Level_Access"].ToString() == "2")
                                {
                                    Homepage homeuser = new Homepage(txbusername.Text);
                                    this.Hide();
                                    homeuser.Show();
                                    break;
                                }
                            }
                            else if (txbusername.Text != dr["Username"].ToString())
                            {
                                MessageBox.Show("Username atau Password yang anda masukkan salah");
                                txbusername.Clear();
                                txbpassword.Clear();
                                break;
                            }
                            else if (txbpassword.Text != dr["Password"].ToString())
                            {
                                MessageBox.Show("Username atau Password yang anda masukkan salah");
                                txbusername.Clear();
                                txbpassword.Clear();
                                break;
                            }
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
        }

        private void LoginFrm_Load_1(object sender, EventArgs e)
        {
            datelabel.Text = DateTime.Now.ToString();
        }
    }
}