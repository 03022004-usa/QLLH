using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class QuanLyLichHoc : Form
    {
        private string connectionString = "Server=localhost;Database=SchoolDB;Integrated Security=True;";
        private string userRole;
        private int selectedScheduleId; 

        public QuanLyLichHoc(string role)
        {
            InitializeComponent();
            userRole = role;
            PhanQuyen();
            lstSchedules.SelectedIndexChanged += lstSchedules_SelectedIndexChanged;
        }

        
        private void btnLoadSchedules_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ScheduleId, Mon, TenGV, Phong, NgayBatDau, NgayKetThuc FROM Schedules";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        lstSchedules.Items.Clear();
                        while (reader.Read())
                        {
                            lstSchedules.Items.Add($"{reader["ScheduleId"]} - {reader["Mon"]} - {reader["TenGV"]} - {reader["Phong"]} - {reader["NgayBatDau"]} - {reader["NgayKetThuc"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       
        private void lstSchedules_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSchedules.SelectedItem != null)
            {
               
                string selectedItem = lstSchedules.SelectedItem.ToString();

               
                string[] parts = selectedItem.Split(' '); 

                if (parts.Length > 0 && int.TryParse(parts[0], out int id))
                {
                    selectedScheduleId = id;
                    MessageBox.Show("Chọn Lịch Học : " + selectedScheduleId);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy.");
                }
            }
        }

        
        private void DisplayScheduleDetails(int scheduleId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Mon, TenGV, Phong, NgayBatDau, NgayKetThuc FROM Schedules WHERE ScheduleId = @ScheduleId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ScheduleId", scheduleId);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            txtSubject.Text = reader["Mon"].ToString();
                            txtTeacherName.Text = reader["TenGV"].ToString();
                            txtRoom.Text = reader["Phong"].ToString();
                            dtpStartDate.Value = Convert.ToDateTime(reader["NgayBatDau"]);
                            dtpEndDate.Value = Convert.ToDateTime(reader["NgayKetThuc"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
        private void btnEditSchedule_Click(object sender, EventArgs e)
        {
            if (selectedScheduleId == 0)
            {
                MessageBox.Show("Chọn lịch học để sửa.");
                return;
            }

            string newMon = txtSubject.Text;
            string newTenGV = txtTeacherName.Text;
            string newPhong = txtRoom.Text;
            DateTime newNgayBatDau = dtpStartDate.Value;
            DateTime newNgayKetThuc = dtpEndDate.Value;

            if (string.IsNullOrEmpty(newMon) || string.IsNullOrEmpty(newTenGV) || string.IsNullOrEmpty(newPhong))
            {
                MessageBox.Show("Nhập tất cả thông tin.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Schedules SET Mon = @Mon, TenGV = @TenGV, Phong = @Phong, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc WHERE ScheduleId = @ScheduleId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Mon", newMon);
                        command.Parameters.AddWithValue("@TenGV", newTenGV);
                        command.Parameters.AddWithValue("@Phong", newPhong);
                        command.Parameters.AddWithValue("@NgayBatDau", newNgayBatDau);
                        command.Parameters.AddWithValue("@NgayKetThuc", newNgayKetThuc);
                        command.Parameters.AddWithValue("@ScheduleId", selectedScheduleId);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cập nhật thành công!");
                btnLoadSchedules.PerformClick();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {
            if (selectedScheduleId == 0)
            {
                MessageBox.Show("Chọn lịch học để xóa.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Schedules WHERE ScheduleId = @ScheduleId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ScheduleId", selectedScheduleId);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Xóa thành công!");
                btnLoadSchedules.PerformClick(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubject.Text) || string.IsNullOrEmpty(txtTeacherName.Text) || string.IsNullOrEmpty(txtRoom.Text))
            {
                MessageBox.Show("Điền đầy đủ thông tin.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Schedules (Mon, TenGV, Phong, NgayBatDau, NgayKetThuc) VALUES (@Mon, @TenGV, @Phong, @NgayBatDau, @NgayKetThuc)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Mon", txtSubject.Text);
                        command.Parameters.AddWithValue("@TenGV", txtTeacherName.Text);
                        command.Parameters.AddWithValue("@Phong", txtRoom.Text);
                        command.Parameters.AddWithValue("@NgayBatDau", dtpStartDate.Value);
                        command.Parameters.AddWithValue("@NgayKetThuc", dtpEndDate.Value);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm thành công!");
                btnLoadSchedules.PerformClick();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
        private void PhanQuyen()
        {
            if (userRole == "Teacher")
            {
                
                btnEditSchedule.Enabled = true;
                btnDeleteSchedule.Enabled = true;
                btnAddSchedule.Enabled = true;
            }
            else if (userRole == "Student")
            {
                
                btnEditSchedule.Enabled = false;
                btnDeleteSchedule.Enabled = false;
                btnAddSchedule.Enabled = false;
            }
        }

        private void ManageScheduleForm_Load(object sender, EventArgs e)
        {
            btnLoadSchedules.PerformClick(); 
        }
    }
}


