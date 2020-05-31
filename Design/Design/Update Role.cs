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
    public partial class UpdateRole : Form
    {
        public UpdateRole()
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
                if (!string.IsNullOrEmpty(txtIdRole.Text.Trim()))
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]))
                    {
                        using (SqlCommand command = new SqlCommand("sp_SearchByIdRole", connection))
                        {
                            connection.Open();
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id_role", txtIdRole.Text.Trim());

                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtNamaRole.Text = Convert.ToString(reader["nama_role"]);
                                txtDeskripsi.Text = Convert.ToString(reader["deskripsi_role"]);

                                txtIdRole.Enabled = false;
                                txtNamaRole.Enabled = true;
                                txtDeskripsi.Enabled = true;
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
            txtIdRole.Text = "";
            txtNamaRole.Text = "";
            txtDeskripsi.Text = "";

            txtIdRole.Enabled = true;
            txtNamaRole.Enabled = false;
            txtDeskripsi.Enabled = false;

            epWarning.SetError(txtNamaRole, "");
            epWrong.SetError(txtNamaRole, "");
            epCorrect.SetError(txtNamaRole, "");

            epWarning.SetError(txtDeskripsi, "");
            epWrong.SetError(txtDeskripsi, "");
            epCorrect.SetError(txtDeskripsi, "");
        }

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            //string connectionstring = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
            //SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand insert = new SqlCommand("sp_UpdateRole", connection);
            insert.CommandType = CommandType.StoredProcedure;

            if (txtIdRole.Text == "")
            {
                MessageBox.Show("Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // clear();
            }
            else
            {
                insert.Parameters.AddWithValue("id_role", txtIdRole.Text);
                insert.Parameters.AddWithValue("nama_role", txtNamaRole.Text);
                insert.Parameters.AddWithValue("deskripsi_role", txtDeskripsi.Text);
                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    this.roleTableAdapter.Fill(this.dsRole1.Role);
                    MessageBox.Show("Data Role Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtNamaRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNamaRole_Leave(object sender, EventArgs e)
        {
            if (txtNamaRole.Text == "")
            {
                epWarning.SetError(txtNamaRole, "Harus diisi");
                epWrong.SetError(txtNamaRole, "");
                epCorrect.SetError(txtNamaRole, "");
            }
            else
            {
                epWarning.SetError(txtNamaRole, "");
                epWrong.SetError(txtNamaRole, "");
                epCorrect.SetError(txtNamaRole, "Benar");
            }
        }

        private void txtDeskripsi_Leave(object sender, EventArgs e)
        {
            if (txtDeskripsi.Text == "")
            {
                epWarning.SetError(txtDeskripsi, "Harus diisi");
                epWrong.SetError(txtDeskripsi, "");
                epCorrect.SetError(txtDeskripsi, "");
            }
            else
            {
                epWarning.SetError(txtDeskripsi, "");
                epWrong.SetError(txtDeskripsi, "");
                epCorrect.SetError(txtDeskripsi, "Benar");
            }
        }

        private void UpdateRole_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRole1.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.dsRole1.Role);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            //  string connectionstring = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
            // SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand delete = new SqlCommand("sp_DeleteRole", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("id_role", txtIdRole.Text);

            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.roleTableAdapter.Fill(this.dsRole1.Role);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Menghapus Data :" + ex.Message);
            }
        }
    }
}
