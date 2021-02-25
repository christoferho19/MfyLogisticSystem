using System;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class HomepageAdmin : Form
    {
        private string username;

        public HomepageAdmin(String user)
        {
            InitializeComponent();
            username = user;
        }

        private void HomepageAdmin_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            lbluser.Text = username;
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser adduser = new NewUser();
            adduser.ShowDialog();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginFrm login = new LoginFrm();
            this.Hide();
            login.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPassword changepass = new EditPassword();
            changepass.ShowDialog();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsers fmanageusers = new ManageUsers();
            fmanageusers.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelabel.Text = DateTime.Now.ToString();
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

        private void deleteCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deletecustomers fdelcst = new Deletecustomers();
            fdelcst.ShowDialog();
        }

        private void manageShipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageShips mngshp = new ManageShips();
            mngshp.ShowDialog();
        }

        private void addNewShipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteShips fdelkpl = new DeleteShips();
            fdelkpl.ShowDialog();
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

        private void addNewVoyageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteVoyage fdelvoy = new DeleteVoyage();
            fdelvoy.ShowDialog();
        }

        private void viewContainersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ViewContainer fviewcont = new ViewContainer();
            fviewcont.ShowDialog();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintListCustomer fprintcst = new PrintListCustomer();
            fprintcst.ShowDialog();
        }

        private void manageContainersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageContainer fmanagecnt = new ManageContainer();
            fmanagecnt.ShowDialog();
        }

        private void manageInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInvoice fnewinvoice = new NewInvoice();
            fnewinvoice.ShowDialog();
        }

        private void viewInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewInvoice fviewInvc = new ViewInvoice();
            fviewInvc.ShowDialog();
        }

        private void previewInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreviewInvoice fpinvoice = new PreviewInvoice();
            fpinvoice.ShowDialog();
        }
    }
}