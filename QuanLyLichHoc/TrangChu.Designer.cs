namespace QuanLyLichHoc
{
    partial class TrangChu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnManageSchedule;
        private System.Windows.Forms.Button btnManageAssignment;
        private System.Windows.Forms.Button btnSendNotification;  

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {

            this.btnManageSchedule = new System.Windows.Forms.Button();
            this.btnManageAssignment = new System.Windows.Forms.Button();
            this.btnSendNotification = new System.Windows.Forms.Button();
            this.SuspendLayout();
           

            this.btnManageSchedule.Location = new System.Drawing.Point(150, 100);
            this.btnManageSchedule.Name = "btnManageSchedule";
            this.btnManageSchedule.Size = new System.Drawing.Size(150, 44);
            this.btnManageSchedule.TabIndex = 0;
            this.btnManageSchedule.Text = "Lịch Học";
            this.btnManageSchedule.UseVisualStyleBackColor = true;
            this.btnManageSchedule.Click += new System.EventHandler(this.btnManageSchedule_Click);
            

            this.btnManageAssignment.Location = new System.Drawing.Point(150, 150);
            this.btnManageAssignment.Name = "btnManageAssignment";
            this.btnManageAssignment.Size = new System.Drawing.Size(150, 30);
            this.btnManageAssignment.TabIndex = 1;
            this.btnManageAssignment.Text = "Bài Tập";
            this.btnManageAssignment.UseVisualStyleBackColor = true;
            this.btnManageAssignment.Click += new System.EventHandler(this.btnManageAssignment_Click);
            


            this.btnSendNotification.Location = new System.Drawing.Point(150, 195);
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Size = new System.Drawing.Size(150, 30);
            this.btnSendNotification.TabIndex = 2;
            this.btnSendNotification.Text = "Thông Báo";
            this.btnSendNotification.UseVisualStyleBackColor = true;
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);
            


            this.ClientSize = new System.Drawing.Size(659, 424);
            this.Controls.Add(this.btnManageSchedule);
            this.Controls.Add(this.btnManageAssignment);
            this.Controls.Add(this.btnSendNotification);
            this.Name = "HomeForm";
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);

        }
    }
}
