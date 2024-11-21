using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class QuanLyBT : Form
    {   
        private string connectionString = "Server=localhost;Database=SchoolDB;Integrated Security=True;";
        private int selectedAssignmentId = 0;  
        private string userRole;  

        public QuanLyBT(string role)
        {
            InitializeComponent();
            userRole = role;
            PhanQuyen();
        }

        private void PhanQuyen()
        {
            if (userRole == "Teacher")
            {
                btnAssignNew.Enabled = true;
                btnDeleteAssignment.Enabled = true;
                btnEditAssignment.Enabled = true;
            }
            else if (userRole == "Student")
            {
                btnAssignNew.Enabled = false;
                btnDeleteAssignment.Enabled = false;
                btnEditAssignment.Enabled = false;
            }
        }

        private void btnLoadAssignments_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT AssignmentId, TenBT, NgayNop FROM Assignments";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        lstAssignments.Items.Clear();  

                        while (reader.Read())
                        {
                            lstAssignments.Items.Add(reader["TenBT"] + " - Due: " + reader["NgayNop"]).ToString("dd/MM/yyyy");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lstAssignments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAssignments.SelectedIndex != -1)
            {
                string selectedItem = lstAssignments.SelectedItem.ToString();
                string[] parts = selectedItem.Split(new string[] { " - Due: " }, StringSplitOptions.None);
                string assignmentName = parts[0];

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT AssignmentId FROM Assignments WHERE TenBT = @TenBT";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenBT", assignmentName);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            selectedAssignmentId = (int)reader["AssignmentId"];
                        }
                    }
                }

                txtAssignmentName.Text = assignmentName;
                string dueDateQuery = "SELECT NgayNop FROM Assignments WHERE AssignmentId = @AssignmentId";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(dueDateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AssignmentId", selectedAssignmentId);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            dtpDueDate.Value = (DateTime)reader["NgayNop"];
                        }
                    }
                }
            }
        }

        private void btnAssignNew_Click(object sender, EventArgs e)
        {
            string assignmentName = txtAssignmentName.Text;
            DateTime dueDate = dtpDueDate.Value;

            if (string.IsNullOrEmpty(assignmentName))
            {
                MessageBox.Show("Nhập tên bài tập.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Assignments (TenBT, NgayNop) VALUES (@TenBT, @NgayNop)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenBT", assignmentName);
                        command.Parameters.AddWithValue("@NgayNop", dueDate);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Bài tập thêm thành công!");
                btnLoadAssignments.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDeleteAssignment_Click(object sender, EventArgs e)
        {
            if (lstAssignments.SelectedItem == null)
            {
                MessageBox.Show("Chọn bài tập để xóa.");
                return;
            }

            if (selectedAssignmentId == 0)
            {
                MessageBox.Show("Không thể xác định bài tập được chọn.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Assignments WHERE AssignmentId = @AssignmentId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AssignmentId", selectedAssignmentId);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Xóa thành công!");
                btnLoadAssignments.PerformClick(); // Làm mới danh sách
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnEditAssignment_Click(object sender, EventArgs e)
        {
            string assignmentName = txtAssignmentName.Text;
            DateTime dueDate = dtpDueDate.Value;

            if (string.IsNullOrEmpty(assignmentName))
            {
                MessageBox.Show("Nhập tên bài tập.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Assignments SET TenBT = @TenBT, NgayNop = @NgayNop WHERE AssignmentId = @AssignmentId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenBT", assignmentName);
                        command.Parameters.AddWithValue("@NgayNop", dueDate);
                        command.Parameters.AddWithValue("@AssignmentId", selectedAssignmentId);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cập nhật thành công");
                btnLoadAssignments.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ManageAssignmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
