namespace StudentAttendanceSys.Forms.AdminForms.StudentManagement.AddStudentForm
{
    partial class addStudentForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.studentId = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.emile = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.departmentListBoxSelect = new System.Windows.Forms.ListBox();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(249, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الأسم الأول";
            // 
            // firstName
            // 
            this.firstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstName.Location = new System.Drawing.Point(3, 23);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(243, 27);
            this.firstName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lastName);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(249, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الأسم الأخير";
            // 
            // lastName
            // 
            this.lastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastName.Location = new System.Drawing.Point(3, 23);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(243, 27);
            this.lastName.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.studentId);
            this.groupBox3.Location = new System.Drawing.Point(12, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(249, 53);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الرقم الجامعي";
            // 
            // studentId
            // 
            this.studentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentId.Location = new System.Drawing.Point(3, 23);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(243, 27);
            this.studentId.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.emile);
            this.groupBox4.Location = new System.Drawing.Point(12, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(249, 53);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "البريد الألكتروني او رقم الهاتف";
            // 
            // emile
            // 
            this.emile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emile.Location = new System.Drawing.Point(3, 23);
            this.emile.Name = "emile";
            this.emile.Size = new System.Drawing.Size(243, 27);
            this.emile.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.departmentListBoxSelect);
            this.groupBox5.Location = new System.Drawing.Point(12, 190);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(249, 51);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "القسم";
            // 
            // departmentListBoxSelect
            // 
            this.departmentListBoxSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentListBoxSelect.FormattingEnabled = true;
            this.departmentListBoxSelect.ItemHeight = 20;
            this.departmentListBoxSelect.Location = new System.Drawing.Point(3, 23);
            this.departmentListBoxSelect.Name = "departmentListBoxSelect";
            this.departmentListBoxSelect.Size = new System.Drawing.Size(243, 25);
            this.departmentListBoxSelect.TabIndex = 3;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(12, 306);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(249, 46);
            this.addStudentBtn.TabIndex = 3;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // addStudentForm
            // 
            this.AcceptButton = this.addStudentBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 364);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "addStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox firstName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox studentId;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox emile;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox departmentListBoxSelect;
        private System.Windows.Forms.Button addStudentBtn;
    }
}