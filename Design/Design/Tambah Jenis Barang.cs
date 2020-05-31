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
    public partial class TambahJenisBarang : Form
    {
        public TambahJenisBarang()
        {
            InitializeComponent();

            string query = "select top 1 kode_jenis from JenisBarang order by kode_jenis desc";
            txtIdJenis.Text = autogenerateID("JNS-", query);
        }

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

        private void clear()
        {
            txtNama.Text = "";
            epWarning.SetError(txtNama, "");
            epWrong.SetError(txtNama, "");
            epCorrect.SetError(txtNama, "");
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // string connectionstring = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
            //SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand insert = new SqlCommand("sp_InsertJenisBarang", connection);
            insert.CommandType = CommandType.StoredProcedure;

            if (txtNama.Text == "")
            {
                MessageBox.Show("Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            }

            else
            {
                insert.Parameters.AddWithValue("kode_jenis", txtIdJenis.Text);
                insert.Parameters.AddWithValue("nama_jenis", txtNama.Text);
                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data Jenis Barang Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    string query = "select top 1 kode_jenis from JenisBarang order by kode_jenis desc";
                    txtIdJenis.Text = autogenerateID("JNS-", query);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Menyimpan:" + ex.Message);
                    clear();
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
    }
}
