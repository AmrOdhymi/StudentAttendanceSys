namespace StudentAttendanceSys.Forms.AdminForms.FacultyManagement.UCFaclutyManagement
{
    partial class UCFacultyManagement
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.facultySercheBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.departmentListBoxSelect = new System.Windows.Forms.ListBox();
            this.facultyDataGridView = new System.Windows.Forms.DataGridView();
            this.fasultyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurrentStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataGridView)).BeginInit();
            this.fasultyContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.facultySercheBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(315, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(361, 64);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بحث بالاسم او الرقم التعريفي";
            // 
            // facultySercheBox
            // 
            this.facultySercheBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facultySercheBox.Location = new System.Drawing.Point(3, 23);
            this.facultySercheBox.Name = "facultySercheBox";
            this.facultySercheBox.Size = new System.Drawing.Size(355, 27);
            this.facultySercheBox.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.departmentListBoxSelect);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(140, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(169, 64);
            this.groupBox5.TabIndex = 6;
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
            // facultyDataGridView
            // 
            this.facultyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultyDataGridView.ContextMenuStrip = this.fasultyContextMenuStrip;
            this.facultyDataGridView.Location = new System.Drawing.Point(0, 96);
            this.facultyDataGridView.Name = "facultyDataGridView";
            this.facultyDataGridView.RowHeadersWidth = 51;
            this.facultyDataGridView.RowTemplate.Height = 24;
            this.facultyDataGridView.Size = new System.Drawing.Size(792, 357);
            this.facultyDataGridView.TabIndex = 7;
            // 
            // fasultyContextMenuStrip
            // 
            this.fasultyContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fasultyContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.editCurrentStudentToolStripMenuItem,
            this.deleteCurrentStudentToolStripMenuItem});
            this.fasultyContextMenuStrip.Name = "studentContextMenuStrip";
            this.fasultyContextMenuStrip.Size = new System.Drawing.Size(223, 76);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.addNewStudentToolStripMenuItem.Text = "Add New Fasulty";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // editCurrentStudentToolStripMenuItem
            // 
            this.editCurrentStudentToolStripMenuItem.Name = "editCurrentStudentToolStripMenuItem";
            this.editCurrentStudentToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.editCurrentStudentToolStripMenuItem.Text = "Edit Current Fasulty";
            this.editCurrentStudentToolStripMenuItem.Click += new System.EventHandler(this.editCurrentStudentToolStripMenuItem_Click);
            // 
            // deleteCurrentStudentToolStripMenuItem
            // 
            this.deleteCurrentStudentToolStripMenuItem.Name = "deleteCurrentStudentToolStripMenuItem";
            this.deleteCurrentStudentToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.deleteCurrentStudentToolStripMenuItem.Text = "Delete Current Fasulty";
            this.deleteCurrentStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentStudentToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Faculty Management";
            // 
            // UCFacultyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.facultyDataGridView);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "UCFacultyManagement";
            this.Size = new System.Drawing.Size(792, 425);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataGridView)).EndInit();
            this.fasultyContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox facultySercheBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox departmentListBoxSelect;
        private System.Windows.Forms.DataGridView facultyDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip fasultyContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCurrentStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentStudentToolStripMenuItem;
    }
}
