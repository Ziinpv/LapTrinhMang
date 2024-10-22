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
    public partial class MainForm : Form
    {

        public string  username {get;set; }
        public MainForm()
        {
            InitializeComponent();
        }

        string constring = "Data Source=HOANGPHUC\\SQLEXPRESS;Initial Catalog=ChatClient;Integrated Security=True;TrustServerCertificate=True";

        private void MainForm_Load(object sender, EventArgs e)
        {
            Username.Text = username;
            

            // Tạo kết nối SQL
            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Sử dụng truy vấn tham số để tránh SQL Injection
                    string q = "SELECT * FROM Login WHERE username = @username";

                    // Tạo đối tượng SqlCommand và gán tham số
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@username", Username.Text);

                    // Thực thi truy vấn và đọc dữ liệu
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            // Đọc dòng dữ liệu đầu tiên
                            if (dataReader.Read())
                            {
                                // Giả sử cột 0 là tên đăng nhập, bạn cần chỉ rõ tên cột hoặc chỉ số của nó
                                Username.Text = dataReader["username"].ToString();
                               
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy username.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();   
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //// Kiểm tra trạng thái hiển thị của pnlProfile
            //if (pnlHome.Visible)
            //{
            //    // Nếu pnlProfile đang hiển thị, ẩn nó
            //        pnlHome.Visible = false;
            //}
            //else
            //{
            //    // Nếu pnlProfile đang ẩn, hiển thị nó
            //    pnlHome.Visible = true;
            //}
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái hiển thị của pnlProfile
            if (tbcChangeProfile.Visible)
            {
                // Nếu pnlProfile đang hiển thị, ẩn nó
                tbcChangeProfile.Visible = false;
            }
            else
            {
                // Nếu pnlProfile đang ẩn, hiển thị nó
                tbcChangeProfile.Visible = true;
            }
        }
    }
}
