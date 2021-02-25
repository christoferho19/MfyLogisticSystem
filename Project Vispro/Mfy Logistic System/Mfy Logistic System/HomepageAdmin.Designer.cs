namespace Mfy_Logistic_System
{
    partial class HomepageAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageExistingCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageShipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewShipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewShipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voyageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVoyagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewVoyageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVoyagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageContainersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewContainersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shipToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.voyageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.containerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datelabel = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.previewInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightPink;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userControlToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.shipToolStripMenuItem,
            this.voyageToolStripMenuItem,
            this.containerToolStripMenuItem,
            this.printListToolStripMenuItem,
            this.invoiceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(134, 720);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userControlToolStripMenuItem
            // 
            this.userControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.manageUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.userControlToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.userControlToolStripMenuItem.Name = "userControlToolStripMenuItem";
            this.userControlToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.userControlToolStripMenuItem.Text = "User Control";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.addUserToolStripMenuItem.Text = "New user";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.manageUserToolStripMenuItem.Text = "Manage users";
            this.manageUserToolStripMenuItem.Click += new System.EventHandler(this.manageUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.changePasswordToolStripMenuItem.Text = "Change password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageExistingCustomersToolStripMenuItem,
            this.deleteCustomersToolStripMenuItem,
            this.viewCustomersToolStripMenuItem});
            this.customerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // manageExistingCustomersToolStripMenuItem
            // 
            this.manageExistingCustomersToolStripMenuItem.Name = "manageExistingCustomersToolStripMenuItem";
            this.manageExistingCustomersToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.manageExistingCustomersToolStripMenuItem.Text = "Manage customers";
            this.manageExistingCustomersToolStripMenuItem.Click += new System.EventHandler(this.manageExistingCustomersToolStripMenuItem_Click);
            // 
            // deleteCustomersToolStripMenuItem
            // 
            this.deleteCustomersToolStripMenuItem.Name = "deleteCustomersToolStripMenuItem";
            this.deleteCustomersToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.deleteCustomersToolStripMenuItem.Text = "Delete customers";
            this.deleteCustomersToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomersToolStripMenuItem_Click);
            // 
            // viewCustomersToolStripMenuItem
            // 
            this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.viewCustomersToolStripMenuItem.Text = "View customers";
            this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersToolStripMenuItem_Click);
            // 
            // shipToolStripMenuItem
            // 
            this.shipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageShipsToolStripMenuItem,
            this.addNewShipToolStripMenuItem,
            this.viewShipsToolStripMenuItem});
            this.shipToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.shipToolStripMenuItem.Name = "shipToolStripMenuItem";
            this.shipToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.shipToolStripMenuItem.Text = "Ship";
            // 
            // manageShipsToolStripMenuItem
            // 
            this.manageShipsToolStripMenuItem.Name = "manageShipsToolStripMenuItem";
            this.manageShipsToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.manageShipsToolStripMenuItem.Text = "Manage ships";
            this.manageShipsToolStripMenuItem.Click += new System.EventHandler(this.manageShipsToolStripMenuItem_Click);
            // 
            // addNewShipToolStripMenuItem
            // 
            this.addNewShipToolStripMenuItem.Name = "addNewShipToolStripMenuItem";
            this.addNewShipToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.addNewShipToolStripMenuItem.Text = "Delete ships";
            this.addNewShipToolStripMenuItem.Click += new System.EventHandler(this.addNewShipToolStripMenuItem_Click);
            // 
            // viewShipsToolStripMenuItem
            // 
            this.viewShipsToolStripMenuItem.Name = "viewShipsToolStripMenuItem";
            this.viewShipsToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.viewShipsToolStripMenuItem.Text = "View ships";
            this.viewShipsToolStripMenuItem.Click += new System.EventHandler(this.viewShipsToolStripMenuItem_Click);
            // 
            // voyageToolStripMenuItem
            // 
            this.voyageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVoyagesToolStripMenuItem,
            this.addNewVoyageToolStripMenuItem,
            this.viewVoyagesToolStripMenuItem});
            this.voyageToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.voyageToolStripMenuItem.Name = "voyageToolStripMenuItem";
            this.voyageToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.voyageToolStripMenuItem.Text = "Voyage";
            // 
            // manageVoyagesToolStripMenuItem
            // 
            this.manageVoyagesToolStripMenuItem.Name = "manageVoyagesToolStripMenuItem";
            this.manageVoyagesToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.manageVoyagesToolStripMenuItem.Text = "Manage voyages";
            this.manageVoyagesToolStripMenuItem.Click += new System.EventHandler(this.manageVoyagesToolStripMenuItem_Click);
            // 
            // addNewVoyageToolStripMenuItem
            // 
            this.addNewVoyageToolStripMenuItem.Name = "addNewVoyageToolStripMenuItem";
            this.addNewVoyageToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.addNewVoyageToolStripMenuItem.Text = "Delete voyages";
            this.addNewVoyageToolStripMenuItem.Click += new System.EventHandler(this.addNewVoyageToolStripMenuItem_Click);
            // 
            // viewVoyagesToolStripMenuItem
            // 
            this.viewVoyagesToolStripMenuItem.Name = "viewVoyagesToolStripMenuItem";
            this.viewVoyagesToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.viewVoyagesToolStripMenuItem.Text = "View voyages";
            this.viewVoyagesToolStripMenuItem.Click += new System.EventHandler(this.viewVoyagesToolStripMenuItem_Click);
            // 
            // containerToolStripMenuItem
            // 
            this.containerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageContainersToolStripMenuItem,
            this.viewContainersToolStripMenuItem});
            this.containerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.containerToolStripMenuItem.Name = "containerToolStripMenuItem";
            this.containerToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.containerToolStripMenuItem.Text = "Container";
            // 
            // manageContainersToolStripMenuItem
            // 
            this.manageContainersToolStripMenuItem.Name = "manageContainersToolStripMenuItem";
            this.manageContainersToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.manageContainersToolStripMenuItem.Text = "Manage containers";
            this.manageContainersToolStripMenuItem.Click += new System.EventHandler(this.manageContainersToolStripMenuItem_Click);
            // 
            // viewContainersToolStripMenuItem
            // 
            this.viewContainersToolStripMenuItem.Name = "viewContainersToolStripMenuItem";
            this.viewContainersToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.viewContainersToolStripMenuItem.Text = "View containers";
            this.viewContainersToolStripMenuItem.Click += new System.EventHandler(this.viewContainersToolStripMenuItem_Click);
            // 
            // printListToolStripMenuItem
            // 
            this.printListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem1,
            this.shipToolStripMenuItem1,
            this.voyageToolStripMenuItem1,
            this.containerToolStripMenuItem1});
            this.printListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.printListToolStripMenuItem.Name = "printListToolStripMenuItem";
            this.printListToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.printListToolStripMenuItem.Text = "Print List";
            // 
            // customerToolStripMenuItem1
            // 
            this.customerToolStripMenuItem1.Name = "customerToolStripMenuItem1";
            this.customerToolStripMenuItem1.Size = new System.Drawing.Size(172, 26);
            this.customerToolStripMenuItem1.Text = "Customer";
            this.customerToolStripMenuItem1.Click += new System.EventHandler(this.customerToolStripMenuItem1_Click);
            // 
            // shipToolStripMenuItem1
            // 
            this.shipToolStripMenuItem1.Name = "shipToolStripMenuItem1";
            this.shipToolStripMenuItem1.Size = new System.Drawing.Size(172, 26);
            this.shipToolStripMenuItem1.Text = "Ship";
            // 
            // voyageToolStripMenuItem1
            // 
            this.voyageToolStripMenuItem1.Name = "voyageToolStripMenuItem1";
            this.voyageToolStripMenuItem1.Size = new System.Drawing.Size(172, 26);
            this.voyageToolStripMenuItem1.Text = "Voyage";
            // 
            // containerToolStripMenuItem1
            // 
            this.containerToolStripMenuItem1.Name = "containerToolStripMenuItem1";
            this.containerToolStripMenuItem1.Size = new System.Drawing.Size(172, 26);
            this.containerToolStripMenuItem1.Text = "Container";
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageInvoicesToolStripMenuItem,
            this.newInvoiceToolStripMenuItem,
            this.viewInvoicesToolStripMenuItem,
            this.previewInvoicesToolStripMenuItem});
            this.invoiceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            // 
            // manageInvoicesToolStripMenuItem
            // 
            this.manageInvoicesToolStripMenuItem.Name = "manageInvoicesToolStripMenuItem";
            this.manageInvoicesToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.manageInvoicesToolStripMenuItem.Text = "Manage invoices";
            this.manageInvoicesToolStripMenuItem.Click += new System.EventHandler(this.manageInvoicesToolStripMenuItem_Click);
            // 
            // newInvoiceToolStripMenuItem
            // 
            this.newInvoiceToolStripMenuItem.Name = "newInvoiceToolStripMenuItem";
            this.newInvoiceToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.newInvoiceToolStripMenuItem.Text = "Delete invoices";
            // 
            // viewInvoicesToolStripMenuItem
            // 
            this.viewInvoicesToolStripMenuItem.Name = "viewInvoicesToolStripMenuItem";
            this.viewInvoicesToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.viewInvoicesToolStripMenuItem.Text = "View invoices";
            this.viewInvoicesToolStripMenuItem.Click += new System.EventHandler(this.viewInvoicesToolStripMenuItem_Click);
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.BackColor = System.Drawing.Color.Transparent;
            this.datelabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.datelabel.Location = new System.Drawing.Point(1016, 32);
            this.datelabel.Name = "datelabel";
            this.datelabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datelabel.Size = new System.Drawing.Size(61, 24);
            this.datelabel.TabIndex = 8;
            this.datelabel.Text = "Date";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.Red;
            this.lbluser.Location = new System.Drawing.Point(1016, 80);
            this.lbluser.Name = "lbluser";
            this.lbluser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbluser.Size = new System.Drawing.Size(51, 24);
            this.lbluser.TabIndex = 9;
            this.lbluser.Text = "User";
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(24, 648);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(104, 40);
            this.btnlogout.TabIndex = 10;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // previewInvoicesToolStripMenuItem
            // 
            this.previewInvoicesToolStripMenuItem.Name = "previewInvoicesToolStripMenuItem";
            this.previewInvoicesToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.previewInvoicesToolStripMenuItem.Text = "Preview Invoices";
            this.previewInvoicesToolStripMenuItem.Click += new System.EventHandler(this.previewInvoicesToolStripMenuItem_Click);
            // 
            // HomepageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mfy_Logistic_System.Properties.Resources.Background_Home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomepageAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomepageAdmin";
            this.Load += new System.EventHandler(this.HomepageAdmin_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.ToolStripMenuItem userControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voyageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem containerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageExistingCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewShipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageShipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewShipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewVoyageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVoyagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVoyagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageContainersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewContainersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shipToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem voyageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem containerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem previewInvoicesToolStripMenuItem;
    }
}