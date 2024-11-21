namespace QuanLyLichHoc
{
    partial class QuanLyLichHoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstSchedules;
        private System.Windows.Forms.Button btnLoadSchedules;
        private System.Windows.Forms.Button btnEditSchedule;
        private System.Windows.Forms.Button btnDeleteSchedule;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;

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
            this.lstSchedules = new System.Windows.Forms.ListBox();
            this.btnLoadSchedules = new System.Windows.Forms.Button();
            this.btnEditSchedule = new System.Windows.Forms.Button();
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lstSchedules
            // 
            this.lstSchedules.FormattingEnabled = true;
            this.lstSchedules.ItemHeight = 25;
            this.lstSchedules.Location = new System.Drawing.Point(13, 13);
            this.lstSchedules.Name = "lstSchedules";
            this.lstSchedules.Size = new System.Drawing.Size(400, 204);
            this.lstSchedules.TabIndex = 0;
            this.lstSchedules.SelectedIndexChanged += new System.EventHandler(this.lstSchedules_SelectedIndexChanged);
            // 
            // btnLoadSchedules
            // 
            this.btnLoadSchedules.Location = new System.Drawing.Point(420, 13);
            this.btnLoadSchedules.Name = "btnLoadSchedules";
            this.btnLoadSchedules.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSchedules.TabIndex = 1;
            this.btnLoadSchedules.Text = "Hiện lịch học";
            this.btnLoadSchedules.UseVisualStyleBackColor = true;
            this.btnLoadSchedules.Click += new System.EventHandler(this.btnLoadSchedules_Click);
            // 
            // btnEditSchedule
            // 
            this.btnEditSchedule.Location = new System.Drawing.Point(420, 42);
            this.btnEditSchedule.Name = "btnEditSchedule";
            this.btnEditSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnEditSchedule.TabIndex = 2;
            this.btnEditSchedule.Text = "Sửa lịch học";
            this.btnEditSchedule.UseVisualStyleBackColor = true;
            this.btnEditSchedule.Click += new System.EventHandler(this.btnEditSchedule_Click);
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.Location = new System.Drawing.Point(420, 71);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSchedule.TabIndex = 3;
            this.btnDeleteSchedule.Text = "Xóa lịch học";
            this.btnDeleteSchedule.UseVisualStyleBackColor = true;
            this.btnDeleteSchedule.Click += new System.EventHandler(this.btnDeleteSchedule_Click);
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(420, 100);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnAddSchedule.TabIndex = 4;
            this.btnAddSchedule.Text = "Thêm lịch học";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(13, 242);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(100, 31);
            this.txtSubject.TabIndex = 5;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(119, 242);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(100, 31);
            this.txtTeacherName.TabIndex = 6;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(225, 242);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(100, 31);
            this.txtRoom.TabIndex = 7;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(13, 279);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 31);
            this.dtpStartDate.TabIndex = 8;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(219, 279);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 31);
            this.dtpEndDate.TabIndex = 9;
            // 
            // QuanLyLichHoc
            // 
            this.ClientSize = new System.Drawing.Size(947, 380);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.btnDeleteSchedule);
            this.Controls.Add(this.btnEditSchedule);
            this.Controls.Add(this.btnLoadSchedules);
            this.Controls.Add(this.lstSchedules);
            this.Name = "QuanLyLichHoc";
            this.Text = "Quản Lý Lịch Học";
            this.Load += new System.EventHandler(this.ManageScheduleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
