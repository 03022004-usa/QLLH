using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class TrangDangNhap : Form
    {
        private string connectionString = "Server=localhost;Database=SchoolDB;Integrated Security=True;";

        public TrangDangNhap()
        {
            InitializeComponent();
            this.btnExit.Click += new System.EventHandler((s, e) => Application.Exit());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT VaiTro FROM Users WHERE TenDangNhap = @username AND MK = @password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", txtUsername.Text);
                        command.Parameters.AddWithValue("@password", txtPassword.Text);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string role = result.ToString();

                            
                            this.Hide(); 
                            TrangChu homeForm = new TrangChu(role); 
                            homeForm.Show(); 

                            
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hay mật khẩu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TrangDangNhap_Load(object sender, EventArgs e)
        {
           
        }
    }
}
