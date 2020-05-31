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
    public partial class TambahBarang : Form
    {
        public TambahBarang()
        {
            InitializeComponent();

            string query = "select top 1 id_barang from Barang order by id_barang desc";
            txtIdBarang.Text = autogenerateID("BRG-", query);
            txtIdBarang.Enabled = false;
        }

        string kondisi = "";

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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //string connectionstring = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
            //SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand insert = new SqlCommand("sp_InsertBarang", connection);
            insert.CommandType = CommandType.StoredProcedure;

            if (txtNamaBarang.Text == "" || txtHargaBarang.Text == "" || txtStokBarang.Text == "" || cmbJenis.Text == "" || kondisi == "" || cmbSupplier.Text == "")
            {
                MessageBox.Show("Lengkapi Data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Data Barang Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdBarang.Clear();
                    this.clear();
                    string query = "select top 1 id_barang from Barang order by id_barang desc";
                    txtIdBarang.Text = autogenerateID("BRG-", query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Menyimpan : " + ex.Message);
                    /*clear();*/
                }
            }
        }

        public void clear()
        {
            txtNamaBarang.Text = "";
            txtHargaBarang.Text = "";
            txtStokBarang.Text = "";

            epWarning.SetError(txtNamaBarang, "");
            epWrong.SetError(txtNamaBarang, "");
            epCorrect.SetError(txtNamaBarang, "");

            epWarning.SetError(txtHargaBarang, "");
            epWrong.SetError(txtHargaBarang, "");
            epCorrect.SetError(txtHargaBarang, "");

            epWarning.SetError(txtStokBarang, "");
            epWrong.SetError(txtStokBarang, "");
            epCorrect.SetError(txtStokBarang, "");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void cmbJenis_Leave(object sender, EventArgs e)
        {

        }

        private void cmbKondisi_Leave(object sender, EventArgs e)
        {

        }

        private void TambahBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSupplier.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.dsSupplier.Supplier);
            // TODO: This line of code loads data into the 'dsJenisBarang.JenisBarang' table. You can move, or remove it, as needed.
            this.jenisBarangTableAdapter.Fill(this.dsJenisBarang.JenisBarang);

        }

        private void rbRusak_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRusak.Checked == true)
                kondisi = "Rusak";
        }

        private void rbBaik_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBaik.Checked == true)
                kondisi = "Baik";
        }
    }
}
