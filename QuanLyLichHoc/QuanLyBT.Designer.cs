namespace QuanLyLichHoc
{
    partial class QuanLyBT
    {
       
        private System.ComponentModel.IContainer components = null;

       
        
        /// <param name="disposing"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {
            this.lstAssignments = new System.Windows.Forms.ListBox();
            this.btnLoadAssignments = new System.Windows.Forms.Button();
            this.btnAssignNew = new System.Windows.Forms.Button();
            this.btnDeleteAssignment = new System.Windows.Forms.Button();
            this.btnEditAssignment = new System.Windows.Forms.Button();
            this.txtAssignmentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lstAssignments
            // 
            this.lstAssignments.FormattingEnabled = true;
            this.lstAssignments.ItemHeight = 25;
            this.lstAssignments.Location = new System.Drawing.Point(24, 23);
            this.lstAssignments.Margin = new System.Windows.Forms.Padding(6);
            this.lstAssignments.Name = "lstAssignments";
            this.lstAssignments.Size = new System.Drawing.Size(796, 304);
            this.lstAssignments.TabIndex = 0;
            this.lstAssignments.SelectedIndexChanged += new System.EventHandler(this.lstAssignments_SelectedIndexChanged);
            // 
            // btnLoadAssignments
            // 
            this.btnLoadAssignments.Location = new System.Drawing.Point(860, 23);
            this.btnLoadAssignments.Margin = new System.Windows.Forms.Padding(6);
            this.btnLoadAssignments.Name = "btnLoadAssignments";
            this.btnLoadAssignments.Size = new System.Drawing.Size(240, 58);
            this.btnLoadAssignments.TabIndex = 1;
            this.btnLoadAssignments.Text = "Hiện bài tập";
            this.btnLoadAssignments.UseVisualStyleBackColor = true;
            this.btnLoadAssignments.Click += new System.EventHandler(this.btnLoadAssignments_Click);
            // 
            // btnAssignNew
            // 
            this.btnAssignNew.Location = new System.Drawing.Point(860, 96);
            this.btnAssignNew.Margin = new System.Windows.Forms.Padding(6);
            this.btnAssignNew.Name = "btnAssignNew";
            this.btnAssignNew.Size = new System.Drawing.Size(240, 58);
            this.btnAssignNew.TabIndex = 2;
            this.btnAssignNew.Text = "Thêm bài tập";
            this.btnAssignNew.UseVisualStyleBackColor = true;
            this.btnAssignNew.Click += new System.EventHandler(this.btnAssignNew_Click);
            // 
            // btnDeleteAssignment
            // 
            this.btnDeleteAssignment.Location = new System.Drawing.Point(860, 169);
            this.btnDeleteAssignment.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteAssignment.Name = "btnDeleteAssignment";
            this.btnDeleteAssignment.Size = new System.Drawing.Size(240, 58);
            this.btnDeleteAssignment.TabIndex = 3;
            this.btnDeleteAssignment.Text = "Xóa bài tập";
            this.btnDeleteAssignment.UseVisualStyleBackColor = true;
            this.btnDeleteAssignment.Click += new System.EventHandler(this.btnDeleteAssignment_Click);
            // 
            // btnEditAssignment
            // 
            this.btnEditAssignment.Location = new System.Drawing.Point(860, 242);
            this.btnEditAssignment.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditAssignment.Name = "btnEditAssignment";
            this.btnEditAssignment.Size = new System.Drawing.Size(240, 58);
            this.btnEditAssignment.TabIndex = 4;
            this.btnEditAssignment.Text = "Sửa bài tập";
            this.btnEditAssignment.UseVisualStyleBackColor = true;
            this.btnEditAssignment.Click += new System.EventHandler(this.btnEditAssignment_Click);
            // 
            // txtAssignmentName
            // 
            this.txtAssignmentName.Location = new System.Drawing.Point(300, 365);
            this.txtAssignmentName.Margin = new System.Windows.Forms.Padding(6);
            this.txtAssignmentName.Name = "txtAssignmentName";
            this.txtAssignmentName.Size = new System.Drawing.Size(520, 31);
            this.txtAssignmentName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 371);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên bài tập";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(300, 442);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(520, 31);
            this.dtpDueDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 454);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày nộp";
            // 
            // QuanLyBT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 724);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAssignmentName);
            this.Controls.Add(this.btnEditAssignment);
            this.Controls.Add(this.btnDeleteAssignment);
            this.Controls.Add(this.btnAssignNew);
            this.Controls.Add(this.btnLoadAssignments);
            this.Controls.Add(this.lstAssignments);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "QuanLyBT";
            this.Text = "Quản Lý bài tập";
            this.Load += new System.EventHandler(this.ManageAssignmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAssignments;
        private System.Windows.Forms.Button btnLoadAssignments;
        private System.Windows.Forms.Button btnAssignNew;
        private System.Windows.Forms.Button btnDeleteAssignment;
        private System.Windows.Forms.Button btnEditAssignment;
        private System.Windows.Forms.TextBox txtAssignmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
