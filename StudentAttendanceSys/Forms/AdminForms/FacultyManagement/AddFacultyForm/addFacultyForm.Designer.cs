namespace StudentAttendanceSys.Forms.AdminForms.FacultyManagement.AddFacultyForm
{
    partial class addFacultyForm
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
            this.addFasultyBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.departmentsCheckBoxSelect = new System.Windows.Forms.CheckBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addFasultyBtn
            // 
            this.addFasultyBtn.Location = new System.Drawing.Point(12, 306);
            this.addFasultyBtn.Name = "addFasultyBtn";
            this.addFasultyBtn.Size = new System.Drawing.Size(249, 46);
            this.addFasultyBtn.TabIndex = 9;
            this.addFasultyBtn.Text = "Add Fasulty";
            this.addFasultyBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.departmentsCheckBoxSelect);
            this.groupBox5.Location = new System.Drawing.Point(12, 190);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(249, 110);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "القسم";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.contact);
            this.groupBox4.Location = new System.Drawing.Point(12, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(249, 53);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "البريد الألكتروني او رقم الهاتف";
            // 
            // contact
            // 
            this.contact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contact.Location = new System.Drawing.Point(3, 23);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(243, 27);
            this.contact.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lastName);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(249, 53);
            this.groupBox2.TabIndex = 6;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(249, 54);
            this.groupBox1.TabIndex = 4;
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
            // departmentsCheckBoxSelect
            // 
            this.departmentsCheckBoxSelect.AutoSize = true;
            this.departmentsCheckBoxSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentsCheckBoxSelect.Location = new System.Drawing.Point(3, 23);
            this.departmentsCheckBoxSelect.Name = "departmentsCheckBoxSelect";
            this.departmentsCheckBoxSelect.Size = new System.Drawing.Size(243, 84);
            this.departmentsCheckBoxSelect.TabIndex = 10;
            this.departmentsCheckBoxSelect.Text = "checkBox1";
            this.departmentsCheckBoxSelect.UseVisualStyleBackColor = true;
            // 
            // addFacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 364);
            this.Controls.Add(this.addFasultyBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "addFacultyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addFacultyForm";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addFasultyBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.CheckBox departmentsCheckBoxSelect;
    }
}