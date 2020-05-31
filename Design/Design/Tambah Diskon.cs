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

namespace Master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string query = "select top 1 id_diskon from Diskon order by id_diskon desc";
            txtIdDiskon.Text = autogenerateID("DSKN-", query);

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
              //  sqlCon = new SqlConnection(connection);
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
            txtIdDiskon.Text = "";
            txtDeskripsi.Text = "";
            txtJenisDiskon.Text = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //string connectionstring = "integrated security = true; data source=LAPTOP-ECVGUQK7\\SQLEXPRESS01;initial catalog=FairyHouse";
            //SqlConnection connection = new SqlConnection(connectionstring);

            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["Constring"]);
            SqlCommand insert = new SqlCommand("sp_InsertDiskon", connection);
            insert.CommandType = CommandType.StoredProcedure;

            if (txtIdDiskon.Text == "" || txtDeskripsi.Text == "")
            {
                MessageBox.Show("Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                insert.Parameters.AddWithValue("id_diskon", txtIdDiskon.Text);
                insert.Parameters.AddWithValue("jenis_diskon", txtJenisDiskon.Text); 
                insert.Parameters.AddWithValue("deskripsi", txtDeskripsi.Text);

                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data Diskon Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    string query = "select top 1 id_diskon from Diskon order by id_diskon desc";
                    txtIdDiskon.Text = autogenerateID("DSKN-", query);
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
            txtIdDiskon.Enabled = false;
        }

       

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

