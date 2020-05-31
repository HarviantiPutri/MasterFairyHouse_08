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
    public partial class TambahRole : Form
    {
        public TambahRole()
        {
            InitializeComponent();

            string query = "select top 1 id_role from Role order by id_role desc";
            txtIdRole.Text = autogenerateID("R-", query);
            txtIdRole.Enabled = false;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        public void clear()
        {
            txtNamaRole.Text = "";
            txtDeskripsi.Text = "";

            epWarning.SetError(txtNamaRole, "");
            epWrong.SetError(txtNamaRole, "");
            epCorrect.SetError(txtNamaRole, "");

            epWarning.SetError(txtDeskripsi, "");
            epWrong.SetError(txtDeskripsi, "");
            epCorrect.SetError(txtDeskripsi, "");
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //string connectionstring = "integrated security=true; data source=LAPTOP-I4DV6AK6\\SQLEXPRESS; initial catalog=FairyHouse";
            //SqlConnection connection = new SqlConnection(connectionstring);
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand insert = new SqlCommand("sp_InsertRole", connection);
            insert.CommandType = CommandType.StoredProcedure;

            if (txtNamaRole.Text == "")
            {
                MessageBox.Show("Lengkapi Data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Data Role berhasil ditambahkan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdRole.Clear();
                    this.clear();
                    string query = "select top 1 id_role from Role order by id_role desc";
                    txtIdRole.Text = autogenerateID("R-", query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Menyimpan : " + ex.Message);
                    clear();
                }
            }
        }

        private void txtNamaRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
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

        private void TambahRole_Load(object sender, EventArgs e)
        {

        }
    }
}
