using System;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class TrangChu : Form
    {
        private string userRole;

        public TrangChu(string role)
        {
            InitializeComponent();
            userRole = role;
            PhanQuyen();
        }

        private void btnManageSchedule_Click(object sender, EventArgs e)
        {
            QuanLyLichHoc manageScheduleForm = new QuanLyLichHoc(userRole);
            manageScheduleForm.Show();
        }

        private void btnManageAssignment_Click(object sender, EventArgs e)
        {
            QuanLyBT manageAssignmentForm = new QuanLyBT(userRole);
            manageAssignmentForm.Show(); 
        }

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            if (userRole == "Teacher")
            {
               
                ThongBao sendNotificationForm = new ThongBao(userRole);
                sendNotificationForm.Show();
            }
            else
            {
                
                MessageBox.Show("You do not have permission to send notifications.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
        private void PhanQuyen()
        {
            if (userRole == "Teacher")
            {
                btnManageSchedule.Enabled = true;
                btnManageAssignment.Enabled = true;
            }
            else if (userRole == "Student")
            {
                btnManageSchedule.Enabled = true;
                btnManageAssignment.Enabled = true;
                btnSendNotification.Enabled = false;
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
        }
    }
}
