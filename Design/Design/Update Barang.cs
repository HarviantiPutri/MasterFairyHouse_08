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
    public partial class UpdateBarang : Form
    {
        public UpdateBarang()
        {
            InitializeComponent();
        }

        string kondisi = "";

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdBarang.Text.Trim()))
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]))
                    {
                        using (SqlCommand command = new SqlCommand("sp_SearchByIdBarang", connection))
                        {
                            connection.Open();
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id_barang", txtIdBarang.Text.Trim());

                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtNamaBarang.Text = Convert.ToString(reader["nama_barang"]);
                                txtHargaBarang.Text = Convert.ToString(reader["harga_barang"]);
                                txtStokBarang.Text = Convert.ToString(reader["stok_barang"]);
                                cmbJenis.SelectedValue = Convert.ToString(reader["kode_jenis"]);
                                kondisi = Convert.ToString(reader["kondisi_barang"]);
                                if (kondisi == "Baik")
                                    rbBaik.Checked = true;
                                if (kondisi == "Rusak")
                                    rbRusak.Checked = true;
                                cmbSupplier.SelectedValue = Convert.ToString(reader["id_supplier"]);

                                txtIdBarang.Enabled = false;
                                txtNamaBarang.Enabled = true;
                                txtHargaBarang.Enabled = true;
                                txtStokBarang.Enabled = true;
                                cmbJenis.Enabled = true;
                                cmbSupplier.Enabled = true;
                                rbBaik.Enabled = true;
                                rbRusak.Enabled = true;
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

        public void clear()
        {
            txtNamaBarang.Text = "";
            txtHargaBarang.Text = "";
            txtStokBarang.Text = "";

            txtIdBarang.Enabled = true;
            txtNamaBarang.Enabled = false;
            txtHargaBarang.Enabled = false;
            txtStokBarang.Enabled = false;
            cmbJenis.Enabled = false;
            cmbSupplier.Enabled = false;
            rbBaik.Enabled = false;
            rbRusak.Enabled = false;
        }

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            // string connectionstring = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
            //SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand insert = new SqlCommand("sp_UpdateBarang", connection);
            insert.CommandType = CommandType.StoredProcedure;

            if (txtIdBarang.Text == "")
            {
                MessageBox.Show("Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // clear();
            }
            else
            {
                insert.Parameters.AddWithValue("id_barang", txtIdBarang.Text);
                insert.Parameters.AddWithValue("nama_barang", txtNamaBarang.Text);
                insert.Parameters.AddWithValue("stok_barang", txtStokBarang.Text);
                insert.Parameters.AddWithValue("harga_barang", txtHargaBarang.Text);
                insert.Parameters.AddWithValue("kondisi_barang", kondisi);
                insert.Parameters.AddWithValue("kode_jenis", cmbJenis.SelectedValue.ToString());
                insert.Parameters.AddWithValue("id_supplier", cmbSupplier.SelectedValue.ToString());
                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    this.barangTableAdapter.Fill(this.dsBarang.Barang);
                    MessageBox.Show("Data Barang Berhasil Diperbarui", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Menyimpan:" + ex.Message);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            //  string connectionstring = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
            // SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand delete = new SqlCommand("sp_DeleteBarang", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("id_barang", txtIdBarang.Text);

            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.barangTableAdapter.Fill(this.dsBarang.Barang);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Menghapus Data :" + ex.Message);
            }
        }

        private void bttnBatal_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void UpdateBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSupplier.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.dsSupplier.Supplier);
            // TODO: This line of code loads data into the 'dsJenisBarang.JenisBarang' table. You can move, or remove it, as needed.
            this.jenisBarangTableAdapter.Fill(this.dsJenisBarang.JenisBarang);
            // TODO: This line of code loads data into the 'dsBarang.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.dsBarang.Barang);

        }

        private void txtNamaBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHargaBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStokBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNamaBarang_Leave(object sender, EventArgs e)
        {
            if (txtNamaBarang.Text == "")
            {
                epWarning.SetError(txtNamaBarang, "Harus diisi");
                epWrong.SetError(txtNamaBarang, "");
                epCorrect.SetError(txtNamaBarang, "");
            }
            else
            {
                epWarning.SetError(txtNamaBarang, "");
                epWrong.SetError(txtNamaBarang, "");
                epCorrect.SetError(txtNamaBarang, "Benar");
            }
        }

        private void txtHargaBarang_Leave(object sender, EventArgs e)
        {
            if (txtHargaBarang.Text == "")
            {
                epWarning.SetError(txtHargaBarang, "Harus diisi");
                epWrong.SetError(txtHargaBarang, "");
                epCorrect.SetError(txtHargaBarang, "");
            }
            else
            {
                epWarning.SetError(txtHargaBarang, "");
                epWrong.SetError(txtHargaBarang, "");
                epCorrect.SetError(txtHargaBarang, "Benar");
            }
        }

        private void txtStokBarang_Leave(object sender, EventArgs e)
        {
            if (txtStokBarang.Text == "")
            {
                epWarning.SetError(txtStokBarang, "Harus diisi");
                epWrong.SetError(txtStokBarang, "");
                epCorrect.SetError(txtStokBarang, "");
            }
            else
            {
                epWarning.SetError(txtStokBarang, "");
                epWrong.SetError(txtStokBarang, "");
                epCorrect.SetError(txtStokBarang, "Benar");
            }
        }

        private void rbBaik_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBaik.Checked == true)
                kondisi = "Baik";
        }

        private void rbRusak_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRusak.Checked == true)
                kondisi = "Rusak";
        }
    }
}
