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

namespace MasterMember
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMember1.Member' table. You can move, or remove it, as needed.
            



        }
        string jeniskelamin;

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdMember.Text.Trim()))
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]))
                    {
                        using (SqlCommand command = new SqlCommand("sp_SearchByIdMember", connection))
                        {
                            connection.Open();
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id_member", txtIdMember.Text.Trim());

                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtNamaMember.Text = Convert.ToString(reader["nama_member"]);
                                txtTelepon.Text = Convert.ToString(reader["telepon_member"]);
                                txtAlamat.Text = Convert.ToString(reader["alamat_member"]);
                                txtEmail.Text = Convert.ToString(reader["email_member"]);
                                txtTempatLahir.Text = Convert.ToString(reader["tempat_lahir_member"]);
                                dateTimePicker1.Text = Convert.ToString(reader["tgl_lahir_member"]);
                                txtHargaMember.Text = Convert.ToString(reader["harga_member"]);
                                txtIdMember.Enabled = false;
                               

                            }
                            else
                                MessageBox.Show("ID Member Tidak ditemukan");
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
        private void clear()
        {
            txtIdMember.Text = "";
            txtNamaMember.Text = "";
            txtTelepon.Text = "";
            txtTempatLahir.Text = "";
            txtEmail.Text = "";
            txtHargaMember.Text = "";
            txtAlamat.Text = "";
        }

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            //  string connectionstring = "integrated security = true; data source=LAPTOP-ECVGUQK7\\SQLEXPRESS01;initial catalog=FairyHouse";
            //SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);

            SqlCommand insert = new SqlCommand("sp_UpdateMember", connection);
            insert.CommandType = CommandType.StoredProcedure;

            if (txtIdMember.Text == "" || txtNamaMember.Text == "" || txtTelepon.Text == "" || txtTempatLahir.Text == "" || txtEmail.Text == "" || txtHargaMember.Text == "")
            {
                MessageBox.Show("Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            }
            else
            {
                insert.Parameters.AddWithValue("id_member", txtIdMember.Text);
                insert.Parameters.AddWithValue("nama_member", txtNamaMember.Text);
                insert.Parameters.AddWithValue("telepon_member", txtTelepon.Text);
                insert.Parameters.AddWithValue("tempat_lahir_member", txtTempatLahir.Text);
                insert.Parameters.AddWithValue("email_member", txtEmail.Text);
                insert.Parameters.AddWithValue("harga_member", txtHargaMember.Text);
                insert.Parameters.AddWithValue("alamat_member", txtAlamat.Text);
                insert.Parameters.AddWithValue("tgl_lahir_member", dateTimePicker1.Value);

                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                   
                    MessageBox.Show("Data Member Berhasil Diperbarui", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdMember.Enabled = true;
                    this.memberTableAdapter1.Fill(this.dsMember1.Member);
                    clear();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Menyimpan:" + ex.Message);
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            //  string connectionstring = "integrated security = true; data source=LAPTOP-ECVGUQK7\\SQLEXPRESS01;initial catalog=FairyHouse";
            //  SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand delete = new SqlCommand("sp_DeleteMember", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("id_member", txtIdMember.Text);

            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.memberTableAdapter1.Fill(this.dsMember1.Member);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Menghapus Data :" + ex.Message);
            }
        }

        private void txtIdMember_Leave(object sender, EventArgs e)
        {

        }

        private void txtNamaMember_Leave(object sender, EventArgs e)
        {
            if (txtNamaMember.Text == "")
            {
                epWarning.SetError(txtNamaMember, "Nama Member harus diisi");
                epWrong.SetError(txtNamaMember, "");
                epCorrect.SetError(txtNamaMember, "");
            }
            else
            {
                epWarning.SetError(txtNamaMember, "");
                epWrong.SetError(txtNamaMember, "");
                epCorrect.SetError(txtNamaMember, "Benar");

            }

        }

        private void txtTelepon_Leave(object sender, EventArgs e)
        {
            if (txtTelepon.Text == "")
            {
                epWarning.SetError(txtTelepon, "Telepon Member harus diisi");
                epWrong.SetError(txtTelepon, "");
                epCorrect.SetError(txtTelepon, "");

            }
            else
            {
                epWarning.SetError(txtTelepon, "");
                epWrong.SetError(txtTelepon, "");
                epCorrect.SetError(txtTelepon, "Benar");

            }


        }

        private void txtTempatLahir_Leave(object sender, EventArgs e)
        {

            if (txtTempatLahir.Text == "")
            {
                epWarning.SetError(txtTempatLahir, "Tempat Lahir Member harus diisi");
                epWrong.SetError(txtTempatLahir, "");
                epCorrect.SetError(txtTempatLahir, "");

            }
            else
            {
                epWarning.SetError(txtTempatLahir, "");
                epWrong.SetError(txtTempatLahir, "");
                epCorrect.SetError(txtTempatLahir, "Benar");

            }

        }

        private void txtAlamat_Leave(object sender, EventArgs e)
        {
            if (txtAlamat.Text == "")
            {
                epWarning.SetError(txtAlamat, "Alamat Member harus diisi");
                epWrong.SetError(txtAlamat, "");
                epCorrect.SetError(txtAlamat, "");

            }
            else
            {
                epWarning.SetError(txtAlamat, "");
                epWrong.SetError(txtAlamat, "");
                epCorrect.SetError(txtAlamat, "Benar");

            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Email Member harus diisi");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");

            }
            else
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "Benar");

            }

        }

        private void txtHargaMember_Leave(object sender, EventArgs e)
        {
            if (txtHargaMember.Text == "")
            {
                epWarning.SetError(txtHargaMember, "Harga Member harus diisi");
                epWrong.SetError(txtHargaMember, "");
                epCorrect.SetError(txtHargaMember, "");

            }
            else
            {
                epWarning.SetError(txtHargaMember, "");
                epWrong.SetError(txtHargaMember, "");
                epCorrect.SetError(txtHargaMember, "Benar");

            }

        }

        private void txtNamaMember_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtTempatLahir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtHargaMember_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
