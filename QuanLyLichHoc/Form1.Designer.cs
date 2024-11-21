namespace QuanLyLichHoc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.schoolDBDataSet = new QuanLyLichHoc.SchoolDBDataSet();
            this.assignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentsTableAdapter = new QuanLyLichHoc.SchoolDBDataSetTableAdapters.AssignmentsTableAdapter();
            this.assignmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assignmentIDDataGridViewTextBoxColumn,
            this.tenBTDataGridViewTextBoxColumn,
            this.ngayNopDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assignmentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(761, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "SchoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignmentsBindingSource
            // 
            this.assignmentsBindingSource.DataMember = "Assignments";
            this.assignmentsBindingSource.DataSource = this.schoolDBDataSet;
            // 
            // assignmentsTableAdapter
            // 
            this.assignmentsTableAdapter.ClearBeforeFill = true;
            // 
            // assignmentIDDataGridViewTextBoxColumn
            // 
            this.assignmentIDDataGridViewTextBoxColumn.DataPropertyName = "AssignmentID";
            this.assignmentIDDataGridViewTextBoxColumn.HeaderText = "AssignmentID";
            this.assignmentIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.assignmentIDDataGridViewTextBoxColumn.Name = "assignmentIDDataGridViewTextBoxColumn";
            this.assignmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.assignmentIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // tenBTDataGridViewTextBoxColumn
            // 
            this.tenBTDataGridViewTextBoxColumn.DataPropertyName = "TenBT";
            this.tenBTDataGridViewTextBoxColumn.HeaderText = "TenBT";
            this.tenBTDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tenBTDataGridViewTextBoxColumn.Name = "tenBTDataGridViewTextBoxColumn";
            this.tenBTDataGridViewTextBoxColumn.Width = 200;
            // 
            // ngayNopDataGridViewTextBoxColumn
            // 
            this.ngayNopDataGridViewTextBoxColumn.DataPropertyName = "NgayNop";
            this.ngayNopDataGridViewTextBoxColumn.HeaderText = "NgayNop";
            this.ngayNopDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ngayNopDataGridViewTextBoxColumn.Name = "ngayNopDataGridViewTextBoxColumn";
            this.ngayNopDataGridViewTextBoxColumn.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyLichHoc.SchoolDBDataSet schoolDBDataSet;
        private System.Windows.Forms.BindingSource assignmentsBindingSource;
        private QuanLyLichHoc.SchoolDBDataSetTableAdapters.AssignmentsTableAdapter assignmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNopDataGridViewTextBoxColumn;
    }
}