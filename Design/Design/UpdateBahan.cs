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

namespace Bahan_dan_Jenis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string kondisi = "";
        private void clear()
        {
            txtHargaBahan.Text = "";
            rbRusak.Checked = false;
            rbBaik.Checked = false;
            txtNamaBahan.Text = "";
            txtStokBahan.Text = "";
            txtWarnaBahan.Text = "";
            cmbSupplier.SelectedItem = "-Pilih ID Supplier-";

            epWarning.SetError(txtNamaBahan, "");
            epWrong.SetError(txtNamaBahan, "");
            epCorrect.SetError(txtNamaBahan, "");

            epWarning.SetError(txtHargaBahan, "");
            epWrong.SetError(txtHargaBahan, "");
            epCorrect.SetError(txtHargaBahan, "");

            epWarning.SetError(txtWarnaBahan, "");
            epWrong.SetError(txtWarnaBahan, "");
            epCorrect.SetError(txtWarnaBahan, "");

            epWarning.SetError(txtStokBahan, "");
            epWrong.SetError(txtStokBahan, "");
            epCorrect.SetError(txtStokBahan, "");



        }


        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            //string connectionstring = "integrated security = true; data source=LAPTOP-ECVGUQK7\\SQLEXPRESS01;initial catalog=FairyHouse";
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
           
            SqlCommand insert = new SqlCommand("sp_UpdateBahan", connection);
            insert.CommandType = CommandType.StoredProcedure;

            if (txtHargaBahan.Text == "" ||
          rbBaik.Checked == false ||
            txtNamaBahan.Text == "" ||
            txtStokBahan.Text == "" ||
            txtWarnaBahan.Text == "" ||
            rbRusak.Checked == false)

            {
                MessageBox.Show("Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();

            }

            else
            {
                insert.Parameters.AddWithValue("id_bahan", txtIdBahan.Text);
                insert.Parameters.AddWithValue("nama_bahan", txtNamaBahan.Text);
                insert.Parameters.AddWithValue("warna_bahan", txtWarnaBahan.Text);
                insert.Parameters.AddWithValue("stok_bahan", txtStokBahan.Text);
                insert.Parameters.AddWithValue("harga_bahan", txtHargaBahan.Text);
               
                insert.Parameters.AddWithValue("kondisi_bahan", kondisi);
                insert.Parameters.AddWithValue("id_supplier", cmbSupplier.SelectedValue.ToString());

                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data Bahan Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.bahanTableAdapter.Fill(this.dsBahan.Bahan);
                    txtIdBahan.Enabled = true;
                    clear();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Menyimpan:" + ex.Message);
                    clear();
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdBahan.Text.Trim()))
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]))
                    {
                        using (SqlCommand command = new SqlCommand("sp_SearchByIdBahan", connection))
                        {
                            connection.Open();
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id_bahan", txtIdBahan.Text.Trim());

                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();

                                txtNamaBahan.Text = Convert.ToString(reader["nama_bahan"]);
                                txtStokBahan.Text = Convert.ToString(reader["stok_bahan"]);
                                txtWarnaBahan.Text = Convert.ToString(reader["warna_bahan"]);
                                kondisi = Convert.ToString(reader["kondisi_bahan"]);

                                if (kondisi == "Baik")
                                    rbBaik.Checked = true;
                                else if (kondisi == "Rusak")
                                    rbRusak.Checked = true;

                                txtHargaBahan.Text = Convert.ToString(reader["harga_bahan"]);
                                this.bahanTableAdapter.Fill(this.dsBahan.Bahan);


                                txtIdBahan.Enabled = false;


                            }
                            else
                                MessageBox.Show("ID Bahan Tidak ditemukan");
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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // string connectionstring = "integrated security = true; data source=LAPTOP-ECVGUQK7\\SQLEXPRESS01;initial catalog=FairyHouse";
            //SqlConnection connection = new SqlConnection(connectionstring);

            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand delete = new SqlCommand("sp_DeleteBahan", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("id_bahan", txtIdBahan.Text);

            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
              

                clear();
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

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBahan.Bahan' table. You can move, or remove it, as needed.
            //this.bahanTableAdapter.Fill(this.dsBahan.Bahan);
            


        }

        private void txtNamaBahan_Leave(object sender, EventArgs e)
        {
            if (txtNamaBahan.Text == "")
            {
                epWarning.SetError(txtNamaBahan, "Nama bahan harus diisi");
                epWrong.SetError(txtNamaBahan, "");
                epCorrect.SetError(txtNamaBahan, "");
            }
            else
            {
                epWarning.SetError(txtNamaBahan, "");
                epWrong.SetError(txtNamaBahan, "");
                epCorrect.SetError(txtNamaBahan, "Benar");

            }

        }

        private void txtHargaBahan_Leave(object sender, EventArgs e)
        {
            if (txtHargaBahan.Text == "")
            {
                epWarning.SetError(txtHargaBahan, "Harga Bahan harus diisi");
                epWrong.SetError(txtHargaBahan, "");
                epCorrect.SetError(txtHargaBahan, "");
            }
            else
            {
                epWarning.SetError(txtHargaBahan, "");
                epWrong.SetError(txtHargaBahan, "");
                epCorrect.SetError(txtHargaBahan, "Benar");

            }

        }

        private void txtWarnaBahan_Leave(object sender, EventArgs e)
        {
            if (txtWarnaBahan.Text == "")
            {
                epWarning.SetError(txtWarnaBahan, "Warna Bahan harus diisi");
                epWrong.SetError(txtWarnaBahan, "");
                epCorrect.SetError(txtWarnaBahan, "");
            }
            else
            {
                epWarning.SetError(txtWarnaBahan, "");
                epWrong.SetError(txtWarnaBahan, "");
                epCorrect.SetError(txtWarnaBahan, "Benar");

            }


        }

        private void txtStokBahan_Leave(object sender, EventArgs e)
        {
            if (txtStokBahan.Text == "")
            {
                epWarning.SetError(txtStokBahan, "stok Bahan harus diisi");
                epWrong.SetError(txtStokBahan, "");
                epCorrect.SetError(txtStokBahan, "");
            }
            else
            {
                epWarning.SetError(txtStokBahan, "");
                epWrong.SetError(txtStokBahan, "");
                epCorrect.SetError(txtStokBahan, "Benar");

            }

        }

        private void txtKondisiBahan_Leave(object sender, EventArgs e)
        {
           

        }

        private void txtNamaBahan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtHargaBahan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtWarnaBahan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtStokBahan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtKondisiBahan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
