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

namespace Design
{
    public partial class UpdateJenisBarang : Form
    {
        public UpdateJenisBarang()
        {
            InitializeComponent();
        }

        private void clear()
        {
            txtIdJenis.Text = "";
            txtNama.Text = "";

            txtNama.Enabled = false;
            txtIdJenis.Enabled = true;

            epWarning.SetError(txtNama, "");
            epWrong.SetError(txtNama, "");
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdJenis.Text.Trim()))
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]))
                    {
                        using (SqlCommand command = new SqlCommand("sp_SearchByIdJenisBarang", connection))
                        {
                            connection.Open();
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@kode_jenis", txtIdJenis.Text.Trim());

                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtNama.Text = Convert.ToString(reader["nama_jenis"]);
                                txtIdJenis.Enabled = false;
                            }
                            else
                                MessageBox.Show("ID Tidak ditemukan");
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

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            //string connectionstring = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
            //SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand insert = new SqlCommand("sp_UpdateJenisBarang", connection);
            insert.CommandType = CommandType.StoredProcedure;

            if (txtIdJenis.Text == "")
            {
                MessageBox.Show("Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // clear();
            }
            else
            {
                insert.Parameters.AddWithValue("kode_jenis", txtIdJenis.Text);
                insert.Parameters.AddWithValue("nama_jenis", txtNama.Text);
                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    this.jenisBarangTableAdapter.Fill(this.dsJenisBarang.JenisBarang);
                    MessageBox.Show("Data Jenis Barang Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clear();
                    //clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Menyimpan:" + ex.Message);
                    // clear();
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // string connectionstring = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
            //SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);

            SqlCommand delete = new SqlCommand("sp_DeletejenisBarang", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("kode_jenis", txtIdJenis.Text);

            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
                MessageBox.Show("Data Jenis Barang Berhasil di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.jenisBarangTableAdapter.Fill(this.dsJenisBarang.JenisBarang);
                txtIdJenis.Text = "";
                txtNama.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Menghapus Data :" + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNama_Leave(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                epWarning.SetError(txtNama, "Nama bahan harus diisi");
                epWrong.SetError(txtNama, "");
                epCorrect.SetError(txtNama, "");
            }
            else
            {
                epWarning.SetError(txtNama, "");
                epWrong.SetError(txtNama, "");
                epCorrect.SetError(txtNama, "Benar");
            }
        }

        private void UpdateJenisBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsJenisBarang.JenisBarang' table. You can move, or remove it, as needed.
            this.jenisBarangTableAdapter.Fill(this.dsJenisBarang.JenisBarang);

        }
    }
}
