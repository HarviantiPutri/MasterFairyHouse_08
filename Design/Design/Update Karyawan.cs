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
    public partial class UpdateKaryawan : Form
    {
        public UpdateKaryawan()
        {
            InitializeComponent();
        }

        string jeniskelamin = "";

        private void UpdateKaryawan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRole.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.dsRole.Role);
            // TODO: This line of code loads data into the 'dsKaryawan.Karyawan' table. You can move, or remove it, as needed.
            this.karyawanTableAdapter.Fill(this.dsKaryawan.Karyawan);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdKaryawan.Text.Trim()))
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]))
                    {
                        using (SqlCommand command = new SqlCommand("sp_SearchByIdKaryawan", connection))
                        {
                            connection.Open();
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id_karyawan", txtIdKaryawan.Text.Trim());

                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtNamaKaryawan.Text = Convert.ToString(reader["nama_karyawan"]);
                                jeniskelamin = Convert.ToString(reader["jenis_kelamin"]);
                                if (jeniskelamin == "Perempuan")
                                    rbPerempuan.Checked = true;
                                else if (jeniskelamin == "Laki-laki")
                                    rbLaki.Checked = true;
                                txtTempatLahirKaryawan.Text = Convert.ToString(reader["tempat_lahir_karyawan"]);
                                DatePicker.Value = Convert.ToDateTime(reader["tgl_lahir_karyawan"]);
                                txtTeleponKaryawan.Text = Convert.ToString(reader["telepon_karyawan"]);
                                txtAlamatKaryawan.Text = Convert.ToString(reader["alamat_karyawan"]);
                                txtEmailKaryawan.Text = Convert.ToString(reader["email_karyawan"]);
                                txtUsername.Text = Convert.ToString(reader["username"]);
                                txtPassword.Text = Convert.ToString(reader["password"]);
                                cmbRole.SelectedValue = Convert.ToString(reader["id_role"]);

                                txtIdKaryawan.Enabled = false;
                                txtNamaKaryawan.Enabled = true;
                                rbLaki.Enabled = true;
                                rbPerempuan.Enabled = true;
                                txtTempatLahirKaryawan.Enabled = true;
                                DatePicker.Enabled = true;
                                txtTeleponKaryawan.Enabled = true;
                                txtAlamatKaryawan.Enabled = true;
                                txtEmailKaryawan.Enabled = true;
                                txtUsername.Enabled = true;
                                txtPassword.Enabled = true;
                                cmbRole.Enabled = true;
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

        private void rbLaki_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLaki.Checked == true)
            {
                jeniskelamin = "Laki-Laki";
            }
        }

        private void rbPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPerempuan.Checked == true)
            {
                jeniskelamin = "Perempuan";
            }
        }

        public void clear()
        {
            txtIdKaryawan.Text = "";
            txtIdKaryawan.Text = "";
            txtNamaKaryawan.Text = "";
            rbLaki.Checked = false;
            rbPerempuan.Checked= false;
            txtTempatLahirKaryawan.Text = "";
            /*DatePicker.Enabled = true;*/
            txtTeleponKaryawan.Text = "";
            txtAlamatKaryawan.Text = "";
            txtEmailKaryawan.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            /*cmbRole.Enabled = true;*/

            txtIdKaryawan.Enabled = true;
            txtNamaKaryawan.Enabled = false;
            rbLaki.Enabled = false;
            rbPerempuan.Enabled = false;
            txtTempatLahirKaryawan.Enabled = false;
            DatePicker.Enabled = false;
            txtTeleponKaryawan.Enabled = false;
            txtAlamatKaryawan.Enabled = false;
            txtEmailKaryawan.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            cmbRole.Enabled = false;

            epWarning.SetError(txtNamaKaryawan, "");
            epWrong.SetError(txtNamaKaryawan, "");
            epCorrect.SetError(txtNamaKaryawan, "");

            epWarning.SetError(txtTempatLahirKaryawan, "");
            epWrong.SetError(txtTempatLahirKaryawan, "");
            epCorrect.SetError(txtTempatLahirKaryawan, "");

            epWarning.SetError(txtTeleponKaryawan, "");
            epWrong.SetError(txtTeleponKaryawan, "");
            epCorrect.SetError(txtTeleponKaryawan, "");

            epWarning.SetError(txtAlamatKaryawan, "");
            epWrong.SetError(txtAlamatKaryawan, "");
            epCorrect.SetError(txtAlamatKaryawan, "");

            epWarning.SetError(txtEmailKaryawan, "");
            epWrong.SetError(txtEmailKaryawan, "");
            epCorrect.SetError(txtEmailKaryawan, "");

            epWarning.SetError(txtUsername, "");
            epWrong.SetError(txtUsername, "");
            epCorrect.SetError(txtUsername, "");

            epWarning.SetError(txtPassword, "");
            epWrong.SetError(txtPassword, "");
            epCorrect.SetError(txtPassword, "");
        }

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            // string connectionstring = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
            //SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand insert = new SqlCommand("sp_UpdateKaryawan", connection);
            insert.CommandType = CommandType.StoredProcedure;

            bool validasiEmail = ValidasiEmail();
            if (txtIdKaryawan.Text == "")
            {
                MessageBox.Show("Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // clear();
            }
            else
            {
                if (validasiEmail == false)
                {
                    MessageBox.Show("Kesalahan penulisan email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    insert.Parameters.AddWithValue("id_karyawan", txtIdKaryawan.Text);
                    insert.Parameters.AddWithValue("nama_karyawan", txtNamaKaryawan.Text);
                    insert.Parameters.AddWithValue("jenis_kelamin", jeniskelamin);
                    insert.Parameters.AddWithValue("tempat_lahir_karyawan", txtTempatLahirKaryawan.Text);
                    insert.Parameters.AddWithValue("tgl_lahir_karyawan", DatePicker.Value);
                    insert.Parameters.AddWithValue("telepon_karyawan", txtTeleponKaryawan.Text);
                    insert.Parameters.AddWithValue("alamat_karyawan", txtAlamatKaryawan.Text);
                    insert.Parameters.AddWithValue("email_karyawan", txtEmailKaryawan.Text);
                    insert.Parameters.AddWithValue("username", txtUsername.Text);
                    insert.Parameters.AddWithValue("password", txtPassword.Text);
                    insert.Parameters.AddWithValue("id_role", cmbRole.SelectedValue.ToString());
                    try
                    {
                        connection.Open();
                        insert.ExecuteNonQuery();
                        this.karyawanTableAdapter.Fill(this.dsKaryawan.Karyawan);
                        MessageBox.Show("Data Karyawan Berhasil Diperbarui", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        public bool ValidasiEmail()
        {
            string regexPattern = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
            Regex regex = new Regex(regexPattern);

            if (!regex.IsMatch(txtEmailKaryawan.Text))
            {
                return (false);
            }
            else
            {
                return (true);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand delete = new SqlCommand("sp_DeleteKaryawan", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("id_karyawan", txtIdKaryawan.Text);

            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.karyawanTableAdapter.Fill(this.dsKaryawan.Karyawan);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Menghapus Data :" + ex.Message);
            }
        }

        private void txtIdKaryawan_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNamaKaryawan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTempatLahirKaryawan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTeleponKaryawan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNamaKaryawan_Leave(object sender, EventArgs e)
        {
            if (txtNamaKaryawan.Text == "")
            {
                epWarning.SetError(txtNamaKaryawan, "Harus diisi!");
                epWrong.SetError(txtNamaKaryawan, "");
                epCorrect.SetError(txtNamaKaryawan, "");
            }
            else
            {
                epWarning.SetError(txtNamaKaryawan, "");
                epWrong.SetError(txtNamaKaryawan, "");
                epCorrect.SetError(txtNamaKaryawan, "Benar");
            }
        }

        private void txtTempatLahirKaryawan_Leave(object sender, EventArgs e)
        {
            if (txtTempatLahirKaryawan.Text == "")
            {
                epWarning.SetError(txtTempatLahirKaryawan, "Harus diisi!");
                epWrong.SetError(txtTempatLahirKaryawan, "");
                epCorrect.SetError(txtTempatLahirKaryawan, "");
            }
            else
            {
                epWarning.SetError(txtTempatLahirKaryawan, "");
                epWrong.SetError(txtTempatLahirKaryawan, "");
                epCorrect.SetError(txtTempatLahirKaryawan, "Benar");
            }
        }

        private void txtTeleponKaryawan_Leave(object sender, EventArgs e)
        {
            if (txtTeleponKaryawan.Text == "")
            {
                epWarning.SetError(txtTeleponKaryawan, "Harus diisi!");
                epWrong.SetError(txtTeleponKaryawan, "");
                epCorrect.SetError(txtTeleponKaryawan, "");
            }
            else
            {
                epWarning.SetError(txtTeleponKaryawan, "");
                epWrong.SetError(txtTeleponKaryawan, "");
                epCorrect.SetError(txtTeleponKaryawan, "Benar");
            }
        }

        private void txtAlamatKaryawan_Leave(object sender, EventArgs e)
        {
            if (txtAlamatKaryawan.Text == "")
            {
                epWarning.SetError(txtAlamatKaryawan, "Harus diisi!");
                epWrong.SetError(txtAlamatKaryawan, "");
                epCorrect.SetError(txtAlamatKaryawan, "");
            }
            else
            {
                epWarning.SetError(txtAlamatKaryawan, "");
                epWrong.SetError(txtAlamatKaryawan, "");
                epCorrect.SetError(txtAlamatKaryawan, "Benar");
            }
        }

        private void txtEmailKaryawan_Leave(object sender, EventArgs e)
        {
            if (txtEmailKaryawan.Text == "")
            {
                epWarning.SetError(txtEmailKaryawan, "Harus diisi!");
                epWrong.SetError(txtEmailKaryawan, "");
                epCorrect.SetError(txtEmailKaryawan, "");
            }
            else
            {
                epWarning.SetError(txtEmailKaryawan, "");
                epWrong.SetError(txtEmailKaryawan, "");
                epCorrect.SetError(txtEmailKaryawan, "Benar");
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                epWarning.SetError(txtUsername, "Harus diisi!");
                epWrong.SetError(txtUsername, "");
                epCorrect.SetError(txtUsername, "");
            }
            else
            {
                epWarning.SetError(txtUsername, "");
                epWrong.SetError(txtUsername, "");
                epCorrect.SetError(txtUsername, "Benar");
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                epWarning.SetError(txtPassword, "Harus diisi!");
                epWrong.SetError(txtPassword, "");
                epCorrect.SetError(txtPassword, "");
            }
            else
            {
                epWarning.SetError(txtPassword, "");
                epWrong.SetError(txtPassword, "");
                epCorrect.SetError(txtPassword, "Benar");
            }
        }
    }
}
