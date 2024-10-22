using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LapTrinhMang
{
    public partial class ProfileForm : Form
    {
        public string username { get; set; }

        // Chuỗi kết nối đến cơ sở dữ liệu
        string constring = "Data Source=HOANGPHUC\\SQLEXPRESS;Initial Catalog=ChatClient;Integrated Security=True;TrustServerCertificate=True";

        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            // Hiển thị tên đăng nhập
           ProfileName.Text = username;

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
                                // Cập nhật thông tin trên form
                                
                                txtName.Text = dataReader["name"].ToString();
                                txtUserName.Text = dataReader["username"].ToString();
                                txtPassword.Text = dataReader["password"].ToString(); // Hiển thị mật khẩu dưới dạng rõ
                                txtPassword.PasswordChar = '*'; // Ẩn mật khẩu bằng dấu hoa thị
                            }
                        }
                        else
                        {
                            //MessageBox.Show("Không tìm thấy thông tin người dùng.");
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
