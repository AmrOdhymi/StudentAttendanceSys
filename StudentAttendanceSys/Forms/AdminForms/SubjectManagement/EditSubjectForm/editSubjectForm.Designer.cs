namespace StudentAttendanceSys.Forms.AdminForms.SubjectManagement.EditSubjectForm
{
    partial class editSubjectForm
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
            this.editSubjectBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.newSelectDepartments = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newSubjectName = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editSubjectBtn
            // 
            this.editSubjectBtn.Location = new System.Drawing.Point(12, 306);
            this.editSubjectBtn.Name = "editSubjectBtn";
            this.editSubjectBtn.Size = new System.Drawing.Size(249, 46);
            this.editSubjectBtn.TabIndex = 12;
            this.editSubjectBtn.Text = "Add Student";
            this.editSubjectBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.newSelectDepartments);
            this.groupBox5.Location = new System.Drawing.Point(12, 77);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(249, 223);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "القسم";
            // 
            // newSelectDepartments
            // 
            this.newSelectDepartments.AutoSize = true;
            this.newSelectDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newSelectDepartments.Location = new System.Drawing.Point(3, 23);
            this.newSelectDepartments.Name = "newSelectDepartments";
            this.newSelectDepartments.Size = new System.Drawing.Size(243, 197);
            this.newSelectDepartments.TabIndex = 10;
            this.newSelectDepartments.Text = "checkBox1";
            this.newSelectDepartments.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newSubjectName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(249, 54);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أسم المادة";
            // 
            // newSubjectName
            // 
            this.newSubjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newSubjectName.Location = new System.Drawing.Point(3, 23);
            this.newSubjectName.Name = "newSubjectName";
            this.newSubjectName.Size = new System.Drawing.Size(243, 27);
            this.newSubjectName.TabIndex = 0;
            // 
            // editSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 364);
            this.Controls.Add(this.editSubjectBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "editSubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editSubjectForm";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editSubjectBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox newSelectDepartments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox newSubjectName;
    }
}