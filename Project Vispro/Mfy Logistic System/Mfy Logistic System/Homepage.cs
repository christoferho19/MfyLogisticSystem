using System;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class Homepage : Form
    {
        private string username;

        public Homepage(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void Homepage_Load(object sender, System.EventArgs e)
        {
            timer1.Start();
            lbluser.Text = username;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginFrm login = new LoginFrm();
            this.Hide();
            login.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPassword changepass = new EditPassword();
            changepass.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelabel.Text = DateTime.Now.ToString();
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewusers fviewuser = new Viewusers();
            fviewuser.ShowDialog();
        }

        private void manageExistingCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomer mngcst = new ManageCustomer();
            mngcst.ShowDialog();
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomers fviewcst = new ViewCustomers();
            fviewcst.ShowDialog();
        }

        private void manageShipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageShips mngshp = new ManageShips();
            mngshp.ShowDialog();
        }

        private void viewShipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewShips fviewshp = new ViewShips();
            fviewshp.ShowDialog();
        }

        private void manageVoyagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageVoyages mngvoy = new ManageVoyages();
            mngvoy.ShowDialog();
        }

        private void viewVoyagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewVoyages fviewvoyages = new ViewVoyages();
            fviewvoyages.ShowDialog();
        }
    }
}