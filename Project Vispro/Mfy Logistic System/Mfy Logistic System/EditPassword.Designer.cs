namespace Mfy_Logistic_System
{
    partial class EditPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbcurrentpass = new System.Windows.Forms.TextBox();
            this.txbnewpass = new System.Windows.Forms.TextBox();
            this.txbrenewpass = new System.Windows.Forms.TextBox();
            this.lblstatuspassword = new System.Windows.Forms.Label();
            this.btnchange = new System.Windows.Forms.Button();
            this.closepic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Re-type New Password";
            // 
            // txbcurrentpass
            // 
            this.txbcurrentpass.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcurrentpass.Location = new System.Drawing.Point(368, 48);
            this.txbcurrentpass.Name = "txbcurrentpass";
            this.txbcurrentpass.PasswordChar = '*';
            this.txbcurrentpass.Size = new System.Drawing.Size(184, 33);
            this.txbcurrentpass.TabIndex = 9;
            // 
            // txbnewpass
            // 
            this.txbnewpass.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnewpass.Location = new System.Drawing.Point(368, 112);
            this.txbnewpass.Name = "txbnewpass";
            this.txbnewpass.PasswordChar = '*';
            this.txbnewpass.Size = new System.Drawing.Size(184, 33);
            this.txbnewpass.TabIndex = 10;
            // 
            // txbrenewpass
            // 
            this.txbrenewpass.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbrenewpass.Location = new System.Drawing.Point(368, 176);
            this.txbrenewpass.Name = "txbrenewpass";
            this.txbrenewpass.PasswordChar = '*';
            this.txbrenewpass.Size = new System.Drawing.Size(184, 33);
            this.txbrenewpass.TabIndex = 11;
            this.txbrenewpass.TextChanged += new System.EventHandler(this.txbrenewpass_TextChanged);
            this.txbrenewpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbrenewpass_KeyDown);
            // 
            // lblstatuspassword
            // 
            this.lblstatuspassword.AutoSize = true;
            this.lblstatuspassword.BackColor = System.Drawing.Color.Transparent;
            this.lblstatuspassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatuspassword.ForeColor = System.Drawing.Color.Red;
            this.lblstatuspassword.Location = new System.Drawing.Point(56, 248);
            this.lblstatuspassword.Name = "lblstatuspassword";
            this.lblstatuspassword.Size = new System.Drawing.Size(145, 20);
            this.lblstatuspassword.TabIndex = 17;
            this.lblstatuspassword.Text = "status re-password";
            // 
            // btnchange
            // 
            this.btnchange.Enabled = false;
            this.btnchange.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchange.Location = new System.Drawing.Point(448, 248);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(104, 40);
            this.btnchange.TabIndex = 20;
            this.btnchange.Text = "Change";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // closepic
            // 
            this.closepic.BackColor = System.Drawing.Color.Transparent;
            this.closepic.Image = global::Mfy_Logistic_System.Properties.Resources.close_logo_black;
            this.closepic.Location = new System.Drawing.Point(568, 8);
            this.closepic.Name = "closepic";
            this.closepic.Size = new System.Drawing.Size(50, 50);
            this.closepic.TabIndex = 21;
            this.closepic.TabStop = false;
            this.closepic.Click += new System.EventHandler(this.closepic_Click);
            // 
            // EditPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mfy_Logistic_System.Properties.Resources.Background_NewUser;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.closepic);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.lblstatuspassword);
            this.Controls.Add(this.txbrenewpass);
            this.Controls.Add(this.txbnewpass);
            this.Controls.Add(this.txbcurrentpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.EditPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbcurrentpass;
        private System.Windows.Forms.TextBox txbnewpass;
        private System.Windows.Forms.TextBox txbrenewpass;
        private System.Windows.Forms.Label lblstatuspassword;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.PictureBox closepic;
    }
}