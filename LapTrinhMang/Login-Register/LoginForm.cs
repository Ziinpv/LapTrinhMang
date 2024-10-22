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
using System.IO;

namespace LapTrinhMang
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string constring = "Data Source=HOANGPHUC\\SQLEXPRESS;Initial Catalog=ChatClient;Integrated Security=True;TrustServerCertificate=True";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //LoginForm loginForm = new LoginForm();
            //loginForm.Show();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm= new RegisterForm();
            registerForm.Show();
        }

        private void btnLoginClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                MessageBox.Show(txtUserName, "Required UserName");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, string.Empty);
            }

            if (string.IsNullOrEmpty(txtPassWord.Text.Trim()))
            {
                MessageBox.Show(txtPassWord, "Required PassWord");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPassWord, string.Empty);
            }

            SqlConnection conn = new SqlConnection(constring);
            string q = "SELECT * FROM Login WHERE username = @username AND password = @password";
            SqlCommand cmd = new SqlCommand(q, conn);

            // Use parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassWord.Text);

            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                // User exists, proceed to login
                MessageBox.Show("Successful Login");
                // Tạo instance của Form2
                MainForm mainForm = new MainForm();
                mainForm.username= txtUserName.Text;
                // Hiển thị Form2
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // User doesn't exist, show error
                MessageBox.Show("Please check your UserName or PassWord");
            }

            dataReader.Close();
            conn.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
