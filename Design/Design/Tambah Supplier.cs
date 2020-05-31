using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;

namespace Design
{
    public partial class TambahSupplier : Form
    {
        public TambahSupplier()
        {
            InitializeComponent();
            string query = "select top 1 id_supplier from Supplier order by id_supplier desc";

            txtIdSupplier.Text = autogenerateID("SUP-", query);
            txtIdSupplier.Enabled = false;
        }

        SqlCommand sqlCmd;
        SqlConnection sqlCon;
        // static string connectionString = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
        SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
        public string autogenerateID(string firstText, string query)
        {
            string result = "";
            int num = 0;
            try
            {
               // sqlCon = new SqlConnection(connectionString);
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //  string connectionstring = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
            // SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand insert = new SqlCommand("sp_InsertSupplier", connection);
            insert.CommandType = CommandType.StoredProcedure;


            bool validasiEmail = ValidasiEmail();
            if (txtNamaSupplier.Text == "" || txtTeleponSupplier.Text == "" || txtEmailSupplier.Text == "" || txtAlamatSupplier.Text == "")
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
                    insert.Parameters.AddWithValue("id_supplier", txtIdSupplier.Text);
                    insert.Parameters.AddWithValue("nama_supplier", txtNamaSupplier.Text);
                    insert.Parameters.AddWithValue("alamat_supplier", txtAlamatSupplier.Text);
                    insert.Parameters.AddWithValue("telepon_supplier", txtTeleponSupplier.Text);
                    insert.Parameters.AddWithValue("email_supplier", txtEmailSupplier.Text);
                    try
                    {
                        connection.Open();
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Data Supplier berhasil ditambahkan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdSupplier.Clear();
                        this.clear();
                        string query = "select top 1 id_supplier from Supplier order by id_supplier desc";
                        txtIdSupplier.Text = autogenerateID("SUP-", query);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal Menyimpan : " + ex.Message);
                    }
                }

            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        public void clear()
        {
            txtNamaSupplier.Clear();
            txtAlamatSupplier.Clear();
            txtTeleponSupplier.Clear();
            txtEmailSupplier.Clear();

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

        public bool ValidasiEmail()
        {
            string regexPattern = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
            Regex regex = new Regex(regexPattern);

            if (!regex.IsMatch(txtEmailSupplier.Text))
            {
                return (false);
            }
            else
            {
                return (true);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNamaSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAlamatSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtTeleponSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmailSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNamaSupplier_Leave(object sender, EventArgs e)
        {
            if (txtNamaSupplier.Text == "")
            {
                epWarning.SetError(txtNamaSupplier, "Harus diisi!");
                epWrong.SetError(txtNamaSupplier, "");
                epCorrect.SetError(txtNamaSupplier, "");
            }
            else
            {
                epWarning.SetError(txtNamaSupplier, "");
                epWrong.SetError(txtNamaSupplier, "");
                epCorrect.SetError(txtNamaSupplier, "Benar");
            }
        }

        private void txtAlamatSupplier_Leave(object sender, EventArgs e)
        {
            if (txtAlamatSupplier.Text == "")
            {
                epWarning.SetError(txtAlamatSupplier, "Harus diisi!");
                epWrong.SetError(txtAlamatSupplier, "");
                epCorrect.SetError(txtAlamatSupplier, "");
            }
            else
            {
                epWarning.SetError(txtAlamatSupplier, "");
                epWrong.SetError(txtAlamatSupplier, "");
                epCorrect.SetError(txtAlamatSupplier, "Benar");
            }
        }

        private void txtTeleponSupplier_Leave(object sender, EventArgs e)
        {
            if (txtTeleponSupplier.Text == "")
            {
                epWarning.SetError(txtTeleponSupplier, "Harus diisi!");
                epWrong.SetError(txtTeleponSupplier, "");
                epCorrect.SetError(txtTeleponSupplier, "");
            }
            else
            {
                epWarning.SetError(txtTeleponSupplier, "");
                epWrong.SetError(txtTeleponSupplier, "");
                epCorrect.SetError(txtTeleponSupplier, "Benar");
            }
        }

        private void txtEmailSupplier_Leave(object sender, EventArgs e)
        {
            bool validasiEmail = ValidasiEmail();
            if (txtEmailSupplier.Text == "" || validasiEmail == false)
            {
                epWarning.SetError(txtEmailSupplier, "Harus diisi!");
                epWrong.SetError(txtEmailSupplier, "");
                epCorrect.SetError(txtEmailSupplier, "");
            }
            else
            {
                epWarning.SetError(txtEmailSupplier, "");
                epWrong.SetError(txtEmailSupplier, "");
                epCorrect.SetError(txtEmailSupplier, "Benar");
            }
        }
    }
}
