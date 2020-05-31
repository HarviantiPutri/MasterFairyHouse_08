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

namespace MasterMember
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string query = "select top 1 id_member from Member order by id_member desc";
            txtIdMember.Text = autogenerateID("MBR-", query);
        }

        SqlCommand sqlCmd;
        SqlConnection sqlCon;
        // static string connectionString = "integrated security = true; data source=LAPTOP-ECVGUQK7\\SQLEXPRESS01;initial catalog=FairyHouse";
        SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
        public string autogenerateID(string firstText, string query)
        {
            string result = "";
            int num = 0;
            try
            {
               // sqlCon = new SqlConnection(connection);
                sqlCon.Open();
                sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    string last = reader[0].ToString();
                    num = Convert.ToInt32(last.Remove(0, firstText.Length)) + 1;
                }
                else
                {
                    num = 1;
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            result = firstText + num.ToString().PadLeft(3, '0');
            return result;
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

            epWarning.SetError(txtNamaMember, "");
            epWrong.SetError(txtNamaMember, "");
            epCorrect.SetError(txtNamaMember, "");

            epWarning.SetError(txtTelepon, "");
            epWrong.SetError(txtTelepon, "");
            epCorrect.SetError(txtTelepon, "");

            epWarning.SetError(txtTempatLahir, "");
            epWrong.SetError(txtTempatLahir, "");
            epCorrect.SetError(txtTempatLahir, "");

            epWarning.SetError(txtAlamat, "");
            epWrong.SetError(txtAlamat, "");
            epCorrect.SetError(txtAlamat, "");

            epWarning.SetError(txtEmail, "");
            epWrong.SetError(txtEmail, "");
            epCorrect.SetError(txtEmail, "");

            epWarning.SetError(txtHargaMember, "");
            epWrong.SetError(txtHargaMember, "");
            epCorrect.SetError(txtHargaMember, "");

        }
        public bool ValidasiEmail()
        {
            string regexPattern = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
            Regex regex = new Regex(regexPattern);

            if (!regex.IsMatch(txtEmail.Text))
            {
                return (false);
            }
            else
            {
                return (true);
            }
        }

            private void Form1_Load(object sender, EventArgs e)
        {
            txtIdMember.Enabled = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //string connectionstring = "integrated security = true; data source=LAPTOP-ECVGUQK7\\SQLEXPRESS01;initial catalog=FairyHouse";
            //SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand insert = new SqlCommand("sp_InsertMember", connection);
            insert.CommandType = CommandType.StoredProcedure;

            bool validasiEmail = ValidasiEmail();
            if (txtIdMember.Text == "" || txtNamaMember.Text == "" ||txtTelepon.Text == "" || txtTempatLahir.Text == "" || txtEmail.Text == "" || txtHargaMember.Text == "")
            {
                MessageBox.Show("Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Data Member Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    string query = "select top 1 id_member from Member order by id_member desc";
                    txtIdMember.Text = autogenerateID("MBR-", query);

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Gagal Menyimpan:" + ex.Message);
                    clear();
                }
            }
        }

        private void txtNamaMember_Leave(object sender, EventArgs e)
        {
            if(txtNamaMember.Text == "")
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
            if(txtTelepon.Text == "")
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
            if(txtAlamat.Text == "")
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
           if(txtEmail.Text == "")
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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
