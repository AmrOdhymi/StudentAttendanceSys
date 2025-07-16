namespace StudentAttendanceSys.Forms.AdminForms.DepartmentManagement.UCDepartmentManagement
{
    partial class UCDepartmentManagement
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.departmentSercheBox = new System.Windows.Forms.TextBox();
            this.departmentDataGridView = new System.Windows.Forms.DataGridView();
            this.departmentContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurrentDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).BeginInit();
            this.departmentContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Department Management";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.departmentSercheBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(218, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(361, 64);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بحث بأسم القسم";
            // 
            // departmentSercheBox
            // 
            this.departmentSercheBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentSercheBox.Location = new System.Drawing.Point(3, 23);
            this.departmentSercheBox.Name = "departmentSercheBox";
            this.departmentSercheBox.Size = new System.Drawing.Size(355, 27);
            this.departmentSercheBox.TabIndex = 3;
            // 
            // departmentDataGridView
            // 
            this.departmentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentDataGridView.ContextMenuStrip = this.departmentContextMenuStrip;
            this.departmentDataGridView.Location = new System.Drawing.Point(0, 96);
            this.departmentDataGridView.Name = "departmentDataGridView";
            this.departmentDataGridView.RowHeadersWidth = 51;
            this.departmentDataGridView.RowTemplate.Height = 24;
            this.departmentDataGridView.Size = new System.Drawing.Size(792, 329);
            this.departmentDataGridView.TabIndex = 9;
            // 
            // departmentContextMenuStrip
            // 
            this.departmentContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.departmentContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDepartmentToolStripMenuItem,
            this.editCurrentDepartmentToolStripMenuItem,
            this.deleteCurrentDepartmentToolStripMenuItem});
            this.departmentContextMenuStrip.Name = "departmentContextMenuStrip";
            this.departmentContextMenuStrip.Size = new System.Drawing.Size(259, 76);
            // 
            // addNewDepartmentToolStripMenuItem
            // 
            this.addNewDepartmentToolStripMenuItem.Name = "addNewDepartmentToolStripMenuItem";
            this.addNewDepartmentToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.addNewDepartmentToolStripMenuItem.Text = "Add New Department";
            this.addNewDepartmentToolStripMenuItem.Click += new System.EventHandler(this.addNewDepartmentToolStripMenuItem_Click);
            // 
            // editCurrentDepartmentToolStripMenuItem
            // 
            this.editCurrentDepartmentToolStripMenuItem.Name = "editCurrentDepartmentToolStripMenuItem";
            this.editCurrentDepartmentToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.editCurrentDepartmentToolStripMenuItem.Text = "Edit Current Department";
            this.editCurrentDepartmentToolStripMenuItem.Click += new System.EventHandler(this.editCurrentDepartmentToolStripMenuItem_Click);
            // 
            // deleteCurrentDepartmentToolStripMenuItem
            // 
            this.deleteCurrentDepartmentToolStripMenuItem.Name = "deleteCurrentDepartmentToolStripMenuItem";
            this.deleteCurrentDepartmentToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.deleteCurrentDepartmentToolStripMenuItem.Text = "Delete Current Department";
            this.deleteCurrentDepartmentToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentDepartmentToolStripMenuItem_Click);
            // 
            // UCDepartmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.departmentDataGridView);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Name = "UCDepartmentManagement";
            this.Size = new System.Drawing.Size(792, 425);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).EndInit();
            this.departmentContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox departmentSercheBox;
        private System.Windows.Forms.DataGridView departmentDataGridView;
        private System.Windows.Forms.ContextMenuStrip departmentContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addNewDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCurrentDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentDepartmentToolStripMenuItem;
    }
}
