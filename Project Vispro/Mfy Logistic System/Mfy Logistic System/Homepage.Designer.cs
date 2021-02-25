namespace Mfy_Logistic_System
{
    partial class Homepage
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
            this.btnlogout = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageExistingCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageShipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewShipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voyageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVoyagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVoyagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageContainersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewContainersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(16, 640);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(104, 40);
            this.btnlogout.TabIndex = 14;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.Red;
            this.lbluser.Location = new System.Drawing.Point(1032, 80);
            this.lbluser.Name = "lbluser";
            this.lbluser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbluser.Size = new System.Drawing.Size(51, 24);
            this.lbluser.TabIndex = 13;
            this.lbluser.Text = "User";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.BackColor = System.Drawing.Color.Transparent;
            this.datelabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.datelabel.Location = new System.Drawing.Point(1032, 32);
            this.datelabel.Name = "datelabel";
            this.datelabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datelabel.Size = new System.Drawing.Size(61, 24);
            this.datelabel.TabIndex = 12;
            this.datelabel.Text = "Date";
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
            this.invoiceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(134, 720);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userControlToolStripMenuItem
            // 
            this.userControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.viewUserToolStripMenuItem});
            this.userControlToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.userControlToolStripMenuItem.Name = "userControlToolStripMenuItem";
            this.userControlToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.userControlToolStripMenuItem.Text = "User Control";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.addUserToolStripMenuItem.Text = "Change Password";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // viewUserToolStripMenuItem
            // 
            this.viewUserToolStripMenuItem.Name = "viewUserToolStripMenuItem";
            this.viewUserToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.viewUserToolStripMenuItem.Text = "View Users";
            this.viewUserToolStripMenuItem.Click += new System.EventHandler(this.viewUserToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageExistingCustomersToolStripMenuItem,
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
            this.addNewContainerToolStripMenuItem,
            this.manageContainersToolStripMenuItem,
            this.viewContainersToolStripMenuItem});
            this.containerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.containerToolStripMenuItem.Name = "containerToolStripMenuItem";
            this.containerToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.containerToolStripMenuItem.Text = "Container";
            // 
            // addNewContainerToolStripMenuItem
            // 
            this.addNewContainerToolStripMenuItem.Name = "addNewContainerToolStripMenuItem";
            this.addNewContainerToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.addNewContainerToolStripMenuItem.Text = "New container";
            // 
            // manageContainersToolStripMenuItem
            // 
            this.manageContainersToolStripMenuItem.Name = "manageContainersToolStripMenuItem";
            this.manageContainersToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.manageContainersToolStripMenuItem.Text = "Manage containers";
            // 
            // viewContainersToolStripMenuItem
            // 
            this.viewContainersToolStripMenuItem.Name = "viewContainersToolStripMenuItem";
            this.viewContainersToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.viewContainersToolStripMenuItem.Text = "View containers";
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newInvoiceToolStripMenuItem,
            this.manageInvoicesToolStripMenuItem,
            this.viewInvoicesToolStripMenuItem});
            this.invoiceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            // 
            // newInvoiceToolStripMenuItem
            // 
            this.newInvoiceToolStripMenuItem.Name = "newInvoiceToolStripMenuItem";
            this.newInvoiceToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.newInvoiceToolStripMenuItem.Text = "New invoice";
            // 
            // manageInvoicesToolStripMenuItem
            // 
            this.manageInvoicesToolStripMenuItem.Name = "manageInvoicesToolStripMenuItem";
            this.manageInvoicesToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.manageInvoicesToolStripMenuItem.Text = "Manage Invoices";
            // 
            // viewInvoicesToolStripMenuItem
            // 
            this.viewInvoicesToolStripMenuItem.Name = "viewInvoicesToolStripMenuItem";
            this.viewInvoicesToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.viewInvoicesToolStripMenuItem.Text = "View Invoices";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mfy_Logistic_System.Properties.Resources.Background_Home;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageExistingCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageShipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewShipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voyageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVoyagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVoyagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem containerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageContainersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewContainersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInvoicesToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem viewUserToolStripMenuItem;
    }
}