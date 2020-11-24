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

namespace UserSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lkLogin.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sql = new SqlConnection(con);
            string query = "INSERT INTO [dbo].[UserSystem] VALUES (@fName,@fPassword,@fPsdCheck,@fGender,@fEmail,@fLocation)";
            sql.Open();
            SqlCommand cmd = new SqlCommand(query,sql);
            string gender = rbMale.Checked ? "M" : "F";
            cmd.Parameters.AddWithValue("@fName",txtName.Text);
            cmd.Parameters.AddWithValue("@fPassword", txtPassword.Text);
            cmd.Parameters.AddWithValue("@fPsdCheck", txtPsdCheck.Text);
            cmd.Parameters.AddWithValue("@fEmail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@fGender", gender);
            cmd.Parameters.AddWithValue("@fLocation", comboBox1.Text);
            cmd.ExecuteNonQuery();
            txtShow.Text = "會員 "+txtName.Text+"註冊成功";
            lkLogin.Visible = true;
            sql.Close();
        }

        private void txtPsdCheck_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPsdCheck.Text)
            { 
                MessageBox.Show("密碼不一致");
                txtPsdCheck.Focus();
                return;
            }
        }
    }
}
