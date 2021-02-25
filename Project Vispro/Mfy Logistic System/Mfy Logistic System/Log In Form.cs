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

        private Boolean whilestate = false;

        private string PSuserid = null;
        private string PSpass = null;

        private static Boolean userlogin(string username, string password, Boolean whilestate)
        {
            if (username == "")
            {
                MessageBox.Show("Mohon isi username anda");
            }
            else if (password == "")
            {
                MessageBox.Show("Mohon isi password anda");
            }
            else
            {
                string connstring = cmethod.GetConnString();
                SqlConnection conn = new SqlConnection(connstring);

                string query = "SELECT * FROM Userdata ";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (username == dr["Username"].ToString() && password == dr["Password"].ToString())
                        {
                            if (dr["Level_Access"].ToString() == "1")
                            {
                                HomepageAdmin homeadmin = new HomepageAdmin(username);

                                whilestate = true;

                                homeadmin.Show();
                                break;
                            }
                            else if (dr["Level_Access"].ToString() == "2")
                            {
                                Homepage homeuser = new Homepage(username);

                                whilestate = true;

                                homeuser.Show();
                                break;
                            }
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
            return (whilestate);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PSuserid = txbusername.Text;
            PSpass = txbpassword.Text;

            whilestate = userlogin(PSuserid, PSpass, whilestate);
            if (whilestate == true)
            {
                this.Hide();
            }
            else if (whilestate == false)
            {
                MessageBox.Show("Username atau Password yang anda masukkan salah");
                txbusername.Clear();
                txbpassword.Clear();
            }
        }

        private void txbpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PSuserid = txbusername.Text;
                PSpass = txbpassword.Text;

                whilestate = userlogin(PSuserid, PSpass, whilestate);

                if (whilestate == true)
                {
                    this.Hide();
                }
                else if (whilestate == false)
                {
                    MessageBox.Show("Username atau Password yang anda masukkan salah");
                    txbusername.Clear();
                    txbpassword.Clear();
                }
            }
        }

        private void LoginFrm_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            whilestate = false;
            PSuserid = null;
            PSpass = null;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelabel.Text = DateTime.Now.ToString();
        }
    }
}