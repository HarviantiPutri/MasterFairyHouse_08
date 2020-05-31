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
    public partial class TambahKaryawan : Form
    {
        public TambahKaryawan()
        {
            InitializeComponent();

            string query = "select top 1 id_karyawan from Karyawan order by id_karyawan desc";
            txtIdKaryawan.Text = autogenerateID("KRY-", query);
            txtIdKaryawan.Enabled = false;
        }

        string jeniskelamin = "";

        SqlCommand sqlCmd;
        SqlConnection sqlCon;
        //static string connectionString = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
        SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
        public string autogenerateID(string firstText, string query)
        {
            string result = "";
            int num = 0;
            try
            {
                //sqlCon = new SqlConnection(connection);
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

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //string connectionstring = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
            //SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand insert = new SqlCommand("sp_InsertKaryawan", connection);
            insert.CommandType = CommandType.StoredProcedure;


            bool validasiEmail = ValidasiEmail();
            if (txtNamaKaryawan.Text == "" || jeniskelamin == "" || txtTempatLahirKaryawan.Text == "" || txtTeleponKaryawan.Text == "" || txtAlamatKaryawan.Text == "" || txtEmailKaryawan.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Lengkapi Data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Data Karyawan Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdKaryawan.Clear();
                        this.clear();
                        string query = "select top 1 id_karyawan from Karyawan order by id_karyawan desc";
                        txtIdKaryawan.Text = autogenerateID("KRY-", query);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal Menyimpan : " + ex.Message);
                        /*clear();*/
                    }
                }
            }
        }

        public void clear()
        {
            txtNamaKaryawan.Text = "";
            txtTempatLahirKaryawan.Text = "";
            txtTeleponKaryawan.Text = "";
            txtAlamatKaryawan.Text = "";
            txtEmailKaryawan.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";

            rbLaki.Checked = false;
            rbPerempuan.Checked = false;

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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.clear();
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

        private void txtEmailKaryawan_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void TambahKaryawan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRole.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.dsRole.Role);

        }
    }
}
 