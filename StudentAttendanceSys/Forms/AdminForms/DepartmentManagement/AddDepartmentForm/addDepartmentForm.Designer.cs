namespace StudentAttendanceSys.Forms.AdminForms.DepartmentManagement.AddDepartmentForm
{
    partial class addDepartmentForm
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
            this.addDepartmentBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.departmentName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addDepartmentBtn
            // 
            this.addDepartmentBtn.Location = new System.Drawing.Point(12, 87);
            this.addDepartmentBtn.Name = "addDepartmentBtn";
            this.addDepartmentBtn.Size = new System.Drawing.Size(249, 46);
            this.addDepartmentBtn.TabIndex = 11;
            this.addDepartmentBtn.Text = "Add Department";
            this.addDepartmentBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.departmentName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(249, 54);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أسم القسم";
            // 
            // departmentName
            // 
            this.departmentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentName.Location = new System.Drawing.Point(3, 23);
            this.departmentName.Name = "departmentName";
            this.departmentName.Size = new System.Drawing.Size(243, 27);
            this.departmentName.TabIndex = 0;
            // 
            // addDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 156);
            this.Controls.Add(this.addDepartmentBtn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "addDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addDepartmentForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDepartmentBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox departmentName;
    }
}