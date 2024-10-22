using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhMang
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }


        string constring = "Data Source=HOANGPHUC\\SQLEXPRESS;Initial Catalog=ChatClient;Integrated Security=True;TrustServerCertificate=True";

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //RegisterForm registerForm = new RegisterForm();
            //registerForm.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnRegisterClient_Click(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(txtConfirm.Text.Trim()))
            {
                MessageBox.Show(txtConfirm, "Required Confirm");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirm, string.Empty);
            }

            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show(txtName, "Required Confirm");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, string.Empty);
            }

            if (txtPassWord.Text != txtConfirm.Text)
            { MessageBox.Show("Please type in correct PassWord"); }

            else
            {

                SqlConnection conn = new SqlConnection(constring);
                string q = "insert into Login(username,password,confirm,name)values(@username,@password,@confirm,@name)";
                SqlCommand cmd = new SqlCommand(q, conn);
                MemoryStream me = new MemoryStream();
                cmd.Parameters.AddWithValue("username", txtUserName.Text);
                cmd.Parameters.AddWithValue("password", txtPassWord.Text);
                cmd.Parameters.AddWithValue("confirm", txtConfirm.Text);
                cmd.Parameters.AddWithValue("name", txtName.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Succesfull Register");
                txtConfirm.Clear();
                txtPassWord.Clear();
                txtUserName.Clear();
                txtName.Clear();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
