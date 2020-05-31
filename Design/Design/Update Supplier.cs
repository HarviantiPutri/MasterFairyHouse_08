using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class UpdateSupplier : Form
    {
        public UpdateSupplier()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdSupplier.Text.Trim()))
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]))
                    {
                        using (SqlCommand command = new SqlCommand("sp_SearchByIdSupplier", connection))
                        {
                            connection.Open();
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id_supplier", txtIdSupplier.Text.Trim());

                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtNamaSupplier.Text = Convert.ToString(reader["nama_supplier"]);
                                txtAlamatSupplier.Text = Convert.ToString(reader["alamat_supplier"]);
                                txtEmailSupplier.Text = Convert.ToString(reader["email_supplier"]);
                                txtTeleponSupplier.Text = Convert.ToString(reader["telepon_supplier"]);

                                txtIdSupplier.Enabled = false;
                                txtNamaSupplier.Enabled = true;
                                txtEmailSupplier.Enabled = true;
                                txtTeleponSupplier.Enabled = true;
                                txtAlamatSupplier.Enabled = true;
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
            txtAlamatSupplier.Text = "";
            txtNamaSupplier.Text = "";
            txtEmailSupplier.Text = "";
            txtTeleponSupplier.Text = "";

            txtIdSupplier.Enabled = true;
            txtNamaSupplier.Enabled = false;
            txtEmailSupplier.Enabled = false;
            txtTeleponSupplier.Enabled = false;
            txtAlamatSupplier.Enabled = false;

            epWarning.SetError(txtNamaSupplier, "");
            epWrong.SetError(txtNamaSupplier, "");
            epCorrect.SetError(txtNamaSupplier, "");

            epWarning.SetError(txtTeleponSupplier, "");
            epWrong.SetError(txtTeleponSupplier, "");
            epCorrect.SetError(txtTeleponSupplier, "");

            epWarning.SetError(txtEmailSupplier, "");
            epWrong.SetError(txtEmailSupplier, "");
            epCorrect.SetError(txtEmailSupplier, "");

            epWarning.SetError(txtAlamatSupplier, "");
            epWrong.SetError(txtAlamatSupplier, "");
            epCorrect.SetError(txtAlamatSupplier, "");
        }

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            //  string connectionstring = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
            // SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand insert = new SqlCommand("sp_UpdateSupplier", connection);
            insert.CommandType = CommandType.StoredProcedure;

            if (txtIdSupplier.Text == "")
            {
                MessageBox.Show("Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // clear();
            }
            else
            {
                insert.Parameters.AddWithValue("id_supplier", txtIdSupplier.Text);
                insert.Parameters.AddWithValue("nama_supplier", txtNamaSupplier.Text);
                insert.Parameters.AddWithValue("alamat_supplier", txtAlamatSupplier.Text);
                insert.Parameters.AddWithValue("telepon_supplier", txtTeleponSupplier.Text);
                insert.Parameters.AddWithValue("email_supplier", txtEmailSupplier.Text);
                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    this.supplierTableAdapter.Fill(this.dsSupplier.Supplier);
                    MessageBox.Show("Data Supplier Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // string connectionstring = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
            //SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand delete = new SqlCommand("sp_DeleteSupplier", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("id_supplier", txtIdSupplier.Text);

            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.supplierTableAdapter.Fill(this.dsSupplier.Supplier);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Menghapus Data :" + ex.Message);
            }
        }

        private void UpdateSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSupplier.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.dsSupplier.Supplier);

        }
    }
}
