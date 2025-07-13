namespace StudentAttendanceSys.Forms.AdminForms.DepartmentManagement.EditDepartmentForm
{
    partial class editDepartmentForm
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
            this.editDepartmentBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editDepartmentName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editDepartmentBtn
            // 
            this.editDepartmentBtn.Location = new System.Drawing.Point(12, 93);
            this.editDepartmentBtn.Name = "editDepartmentBtn";
            this.editDepartmentBtn.Size = new System.Drawing.Size(249, 46);
            this.editDepartmentBtn.TabIndex = 13;
            this.editDepartmentBtn.Text = "Edit Department";
            this.editDepartmentBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editDepartmentName);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(249, 54);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أسم القسم";
            // 
            // editDepartmentName
            // 
            this.editDepartmentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editDepartmentName.Location = new System.Drawing.Point(3, 23);
            this.editDepartmentName.Name = "editDepartmentName";
            this.editDepartmentName.Size = new System.Drawing.Size(243, 27);
            this.editDepartmentName.TabIndex = 0;
            // 
            // editDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 156);
            this.Controls.Add(this.editDepartmentBtn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "editDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editDepartmentForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editDepartmentBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox editDepartmentName;
    }
}