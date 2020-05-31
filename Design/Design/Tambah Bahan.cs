using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bahan_dan_Jenis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string query = "select top 1 id_bahan from Bahan order by id_bahan desc";
            txtIdBahan.Text = autogenerateID("BHN-", query);
        }

        SqlCommand sqlCmd;
        SqlConnection sqlCon;
        //static string connectionString = "integrated security=true; datasource=.; initial catalog=FairyHouse";
        SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
        public string autogenerateID(string firstText, string query)
        {
            string result = "";
            int num = 0;
            try
            {
               // sqlCon = new SqlConnection(sqlCon);
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

        string kondisi = "";
       

        private void clear()
        {
            txtHargaBahan.Text = "";
            rbBaik.Checked = false;
            rbRusak.Checked = false;
            txtNamaBahan.Text = "";
            txtStokBahan.Text = "";
            txtWarnaBahan.Text = "";

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
        

           /* epWarning.SetError(txtKondisiBahan, "");
            epWrong.SetError(txtKondisiBahan, "");
            epCorrect.SetError(txtKondisiBahan, "");*/

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //string connectionstring = "integrated security=true; datasource=.; initial catalog=FairyHouse";
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand insert = new SqlCommand("sp_InsertBahan", connection);
            insert.CommandType = CommandType.StoredProcedure;
           
            if(txtHargaBahan.Text == "" ||
           rbRusak.Checked == false||
            txtNamaBahan.Text == "" ||
            txtStokBahan.Text == "" ||
            txtWarnaBahan.Text == "" ||
            rbBaik.Checked == false)

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
                    clear();
                    string query = "select top 1 id_bahan from Bahan order by id_bahan desc";
                    txtIdBahan.Text = autogenerateID("BHN-", query);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Menyimpan:" + ex.Message);
                    clear();
                }

            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fairyHouseDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.fairyHouseDataSet.Supplier);
            // TODO: This line of code loads data into the 'dsSupplier.Supplier' table. You can move, or remove it, as needed.

            txtIdBahan.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
