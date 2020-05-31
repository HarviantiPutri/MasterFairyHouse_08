using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdDiskon.Text.Trim()))
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]))
                    {
                        using (SqlCommand command = new SqlCommand("sp_SearchByIdDiskon", connection))
                        {
                            connection.Open();
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id_diskon", txtIdDiskon.Text.Trim());

                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtJenisDiskon.Text = Convert.ToString(reader["jenis_diskon"]);
                                txtDeskripsi.Text = Convert.ToString(reader["deskripsi"]);


                                //txtKondisi.Text = Convert.ToString(reader["kondisi_bahan"]);
                                // RefreshDataset();
                                txtIdDiskon.Enabled = false;

                            }
                            else
                                MessageBox.Show("ID Diskon Tidak ditemukan");
                            connection.Close();
                        }
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtIdDiskon.Text = "";
            txtDeskripsi.Text = "";
            txtJenisDiskon.Text = "";
        }

        private void btnPerbarui_Click(object sender, EventArgs e)
        {

            //  string connectionstring = "integrated security = true; data source=LAPTOP-ECVGUQK7\\SQLEXPRESS01;initial catalog=FairyHouse";
            // SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);

            SqlCommand insert = new SqlCommand("sp_UpdateDiskon", connection);
            insert.CommandType = CommandType.StoredProcedure;

            if (txtIdDiskon.Text == "" || txtJenisDiskon.Text == "")
            {
                MessageBox.Show("Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            }
            else
            {
                insert.Parameters.AddWithValue("id_diskon", txtIdDiskon.Text);
                insert.Parameters.AddWithValue("jenis_diskon", txtJenisDiskon.Text);
                insert.Parameters.AddWithValue("deskripsi", txtDeskripsi.Text);
                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();

                    this.diskonTableAdapter.Fill(this.dsDiskon.Diskon);
                    MessageBox.Show("Data Diskon Berhasil Diperbarui", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdDiskon.Text = "";
                    txtJenisDiskon.Text = "";
                    txtDeskripsi.Text = "";
                    clear();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Menyimpan:" + ex.Message);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // string connectionstring = "integrated security = true; data source=LAPTOP-ECVGUQK7\\SQLEXPRESS01;initial catalog=FairyHouse";
            //SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand delete = new SqlCommand("sp_DeleteDiskon", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("id_diskon", txtIdDiskon.Text);

            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.diskonTableAdapter.Fill(this.dsDiskon.Diskon);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Menghapus Data :" + ex.Message);
            }
        }

   
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
