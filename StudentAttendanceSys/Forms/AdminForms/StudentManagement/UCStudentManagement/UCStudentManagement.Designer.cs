namespace StudentAttendanceSys.Forms.AdminForms.StudentManagement.UCStudentManagement
{
    partial class UCStudentManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.studentContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurrentStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxViewDepartments = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.studentSercheBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.departmentListBoxSelect = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.studentdateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.studentContextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.ContextMenuStrip = this.studentContextMenuStrip;
            this.dataGridViewStudents.Location = new System.Drawing.Point(0, 96);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(792, 357);
            this.dataGridViewStudents.TabIndex = 1;
            // 
            // studentContextMenuStrip
            // 
            this.studentContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.studentContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.editCurrentStudentToolStripMenuItem,
            this.deleteCurrentStudentToolStripMenuItem});
            this.studentContextMenuStrip.Name = "studentContextMenuStrip";
            this.studentContextMenuStrip.Size = new System.Drawing.Size(230, 76);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // editCurrentStudentToolStripMenuItem
            // 
            this.editCurrentStudentToolStripMenuItem.Name = "editCurrentStudentToolStripMenuItem";
            this.editCurrentStudentToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.editCurrentStudentToolStripMenuItem.Text = "Edit Current Student";
            this.editCurrentStudentToolStripMenuItem.Click += new System.EventHandler(this.editCurrentStudentToolStripMenuItem_Click);
            // 
            // deleteCurrentStudentToolStripMenuItem
            // 
            this.deleteCurrentStudentToolStripMenuItem.Name = "deleteCurrentStudentToolStripMenuItem";
            this.deleteCurrentStudentToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.deleteCurrentStudentToolStripMenuItem.Text = "Delete Current Student";
            this.deleteCurrentStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentStudentToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Management";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 27);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(391, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(361, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث بالاسم او الرقم التعريفي";
            // 
            // listBoxViewDepartments
            // 
            this.listBoxViewDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxViewDepartments.FormattingEnabled = true;
            this.listBoxViewDepartments.ItemHeight = 20;
            this.listBoxViewDepartments.Location = new System.Drawing.Point(3, 23);
            this.listBoxViewDepartments.Name = "listBoxViewDepartments";
            this.listBoxViewDepartments.Size = new System.Drawing.Size(163, 38);
            this.listBoxViewDepartments.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxViewDepartments);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(216, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(169, 64);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فلتره حسب القسم";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(44, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(169, 64);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "فلتره حسب التاريخ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 27);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.ContextMenuStrip = this.studentContextMenuStrip;
            this.studentDataGridView.Location = new System.Drawing.Point(0, 96);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.RowHeadersWidth = 51;
            this.studentDataGridView.RowTemplate.Height = 24;
            this.studentDataGridView.Size = new System.Drawing.Size(792, 329);
            this.studentDataGridView.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.studentSercheBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(391, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(361, 64);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بحث بالاسم او الرقم التعريفي";
            // 
            // studentSercheBox
            // 
            this.studentSercheBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentSercheBox.Location = new System.Drawing.Point(3, 23);
            this.studentSercheBox.Name = "studentSercheBox";
            this.studentSercheBox.Size = new System.Drawing.Size(355, 27);
            this.studentSercheBox.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.departmentListBoxSelect);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(216, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(169, 64);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "فلتره حسب القسم";
            // 
            // departmentListBoxSelect
            // 
            this.departmentListBoxSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentListBoxSelect.FormattingEnabled = true;
            this.departmentListBoxSelect.ItemHeight = 20;
            this.departmentListBoxSelect.Location = new System.Drawing.Point(3, 23);
            this.departmentListBoxSelect.Name = "departmentListBoxSelect";
            this.departmentListBoxSelect.Size = new System.Drawing.Size(163, 38);
            this.departmentListBoxSelect.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.studentdateTimePicker);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(44, 29);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(169, 64);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "فلتره حسب التاريخ";
            // 
            // studentdateTimePicker
            // 
            this.studentdateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.studentdateTimePicker.Location = new System.Drawing.Point(3, 23);
            this.studentdateTimePicker.Name = "studentdateTimePicker";
            this.studentdateTimePicker.Size = new System.Drawing.Size(163, 27);
            this.studentdateTimePicker.TabIndex = 0;
            // 
            // UCStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "UCStudentManagement";
            this.Size = new System.Drawing.Size(792, 425);
            this.Load += new System.EventHandler(this.UCStudentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.studentContextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxViewDepartments;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip studentContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCurrentStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentStudentToolStripMenuItem;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox studentSercheBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox departmentListBoxSelect;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker studentdateTimePicker;
    }
}
