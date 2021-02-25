using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mfy_Logistic_System
{
    public partial class ViewInvoice : Form
    {
        public ViewInvoice()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Viewusers_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new System.Drawing.Font("Times", 10);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            string connstring = cmethod.GetConnString();
            SqlConnection conn = new SqlConnection(connstring);

            string query = "SELECT Invoice.Id_Invoice,Mst_Kapal.Perusahaan,Mst_Kapal.Nama,Mst_Pelayaran.No_Pelayaran,Mst_Container.Kode_Segel,Mst_Container.Nomor_Segel,Mst_Pengirim.Nama NamaPengirim,Mst_Penerima.Nama NamaPenerima FROM Invoice JOIN Mst_Container ON Invoice.Id_Container = Mst_Container.Id_Container JOIN Mst_Pelayaran ON Invoice.Id_Pelayaran = Mst_Pelayaran.Id_Pelayaran JOIN Mst_Kapal ON Mst_Pelayaran.Id_Kapal = Mst_Kapal.Id_Kapal JOIN Mst_Pengirim ON Invoice.Id_Pengirim = Mst_Pengirim.Id_Pengirim JOIN Mst_Penerima ON Invoice.Id_Penerima = Mst_Penerima.Id_Penerima";
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

    }
}
