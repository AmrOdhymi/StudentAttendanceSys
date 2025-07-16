namespace StudentAttendanceSys.Forms.AdminForms.SubjectManagement.UCSubjectManagement
{
    partial class UCSubjectManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.departmentListBoxSelect = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SubjectSercheBox = new System.Windows.Forms.TextBox();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.subjectContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurrentStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            this.subjectContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject Management";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.departmentListBoxSelect);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(140, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(169, 64);
            this.groupBox5.TabIndex = 8;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SubjectSercheBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(315, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(361, 64);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بحث بأسم المادة";
            // 
            // SubjectSercheBox
            // 
            this.SubjectSercheBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectSercheBox.Location = new System.Drawing.Point(3, 23);
            this.SubjectSercheBox.Name = "SubjectSercheBox";
            this.SubjectSercheBox.Size = new System.Drawing.Size(355, 27);
            this.SubjectSercheBox.TabIndex = 3;
            this.SubjectSercheBox.TextChanged += new System.EventHandler(this.SubjectSercheBox_TextChanged);
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SubjectDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SubjectDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.ContextMenuStrip = this.subjectContextMenuStrip;
            this.SubjectDataGridView.Location = new System.Drawing.Point(0, 96);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.RowHeadersWidth = 51;
            this.SubjectDataGridView.RowTemplate.Height = 24;
            this.SubjectDataGridView.Size = new System.Drawing.Size(792, 329);
            this.SubjectDataGridView.TabIndex = 6;
            // 
            // subjectContextMenuStrip
            // 
            this.subjectContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.subjectContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.editCurrentStudentToolStripMenuItem,
            this.deleteCurrentStudentToolStripMenuItem});
            this.subjectContextMenuStrip.Name = "studentContextMenuStrip";
            this.subjectContextMenuStrip.Size = new System.Drawing.Size(228, 76);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.addNewStudentToolStripMenuItem.Text = "Add New Subject";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // editCurrentStudentToolStripMenuItem
            // 
            this.editCurrentStudentToolStripMenuItem.Name = "editCurrentStudentToolStripMenuItem";
            this.editCurrentStudentToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.editCurrentStudentToolStripMenuItem.Text = "Edit Current Subject";
            this.editCurrentStudentToolStripMenuItem.Click += new System.EventHandler(this.editCurrentStudentToolStripMenuItem_Click);
            // 
            // deleteCurrentStudentToolStripMenuItem
            // 
            this.deleteCurrentStudentToolStripMenuItem.Name = "deleteCurrentStudentToolStripMenuItem";
            this.deleteCurrentStudentToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.deleteCurrentStudentToolStripMenuItem.Text = "Delete Current Subject";
            this.deleteCurrentStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentStudentToolStripMenuItem_Click);
            // 
            // UCSubjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.SubjectDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "UCSubjectManagement";
            this.Size = new System.Drawing.Size(792, 425);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            this.subjectContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox departmentListBoxSelect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox SubjectSercheBox;
        private System.Windows.Forms.DataGridView SubjectDataGridView;
        private System.Windows.Forms.ContextMenuStrip subjectContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCurrentStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentStudentToolStripMenuItem;
    }
}
