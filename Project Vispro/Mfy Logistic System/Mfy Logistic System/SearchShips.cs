﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mfy_Logistic_System
{
    public partial class SearchShips : Form
    {
        public SearchShips()
        {
            InitializeComponent();
        }

        private static void sendvalue(DataGridView dgv)
        {
            int selectedrow = dgv.SelectedCells[0].RowIndex;

            DataGridViewRow selectedrowindex = dgv.Rows[selectedrow];

            string namakpl = Convert.ToString(selectedrowindex.Cells["Nama"].Value);
            string idkpl = Convert.ToString(selectedrowindex.Cells["Id_kapal"].Value);
            string cmpkpl = Convert.ToString(selectedrowindex.Cells["Perusahaan"].Value);

            cmethod.selectedkplname = namakpl;
            cmethod.selectedkplid = idkpl;
            cmethod.selectedkplcompany = cmpkpl;

            cmethod.checkupdatekpl = 1;
        }

        private void txbusername_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string constring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Mst_Kapal where Nama like '" + txbnama.Text + "%'", conn);
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
            dataGridView1.Font = new System.Drawing.Font("Times", 12);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            string connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            string query = "SELECT Nama,Perusahaan,Id_Kapal FROM Mst_Kapal";

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