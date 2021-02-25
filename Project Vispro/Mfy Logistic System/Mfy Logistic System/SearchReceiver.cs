﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class SearchReceiver : Form
    {
        public SearchReceiver()
        {
            InitializeComponent();
        }

        private static void sendvalue(DataGridView dgv)
        {
            int selectedrow = dgv.SelectedCells[0].RowIndex;

            DataGridViewRow selectedrowindex = dgv.Rows[selectedrow];

            string namarcvr = Convert.ToString(selectedrowindex.Cells["Nama"].Value);

            string idrcvr = Convert.ToString(selectedrowindex.Cells["Id_Penerima"].Value);


            cmethod.selectedrcvid = idrcvr;
            cmethod.selectedrcvname = namarcvr;

        }

        private void txbusername_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string constring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Mst_Penerima.Id_Penerima, Mst_Customer.Id_Customer, Mst_Customer.Nama,Mst_Customer.Alamat,Mst_Customer.Kota,Mst_Customer.No_Telp_1,Mst_Customer.No_Telp_2 FROM Mst_Customer JOIN Mst_Penerima ON Mst_Customer.Id_Customer = Mst_Penerima.Id_Customer where Nama like '" + txbnama.Text + "%'", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);
                reader.Close();
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

        private void Searchusers_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new System.Drawing.Font("Times", 10);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            string connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            string query = "SELECT Mst_Penerima.Id_Penerima, Mst_Customer.Id_Customer, Mst_Customer.Nama,Mst_Customer.Alamat,Mst_Customer.Kota,Mst_Customer.No_Telp_1,Mst_Customer.No_Telp_2 FROM Mst_Customer JOIN Mst_Penerima ON Mst_Customer.Id_Customer = Mst_Penerima.Id_Customer";

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

        private void btnok_Click(object sender, EventArgs e)
        {
            sendvalue(dataGridView1);
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txbusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendvalue(dataGridView1);
                this.Hide();
            }
        }
    }
}