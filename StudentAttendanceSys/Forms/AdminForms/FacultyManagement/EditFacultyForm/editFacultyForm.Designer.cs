namespace StudentAttendanceSys.Forms.AdminForms.FacultyManagement.EditFacultyForm
{
    partial class editFacultyForm
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
            this.editFasultyBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NewDepartmentsCheckBoxSelect = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.newContact = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newFirstName = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editFasultyBtn
            // 
            this.editFasultyBtn.Location = new System.Drawing.Point(12, 306);
            this.editFasultyBtn.Name = "editFasultyBtn";
            this.editFasultyBtn.Size = new System.Drawing.Size(249, 46);
            this.editFasultyBtn.TabIndex = 14;
            this.editFasultyBtn.Text = "Edit Fasulty";
            this.editFasultyBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NewDepartmentsCheckBoxSelect);
            this.groupBox5.Location = new System.Drawing.Point(12, 190);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(249, 110);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "القسم";
            // 
            // NewDepartmentsCheckBoxSelect
            // 
            this.NewDepartmentsCheckBoxSelect.AutoSize = true;
            this.NewDepartmentsCheckBoxSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewDepartmentsCheckBoxSelect.Location = new System.Drawing.Point(3, 23);
            this.NewDepartmentsCheckBoxSelect.Name = "NewDepartmentsCheckBoxSelect";
            this.NewDepartmentsCheckBoxSelect.Size = new System.Drawing.Size(243, 84);
            this.NewDepartmentsCheckBoxSelect.TabIndex = 10;
            this.NewDepartmentsCheckBoxSelect.Text = "checkBox1";
            this.NewDepartmentsCheckBoxSelect.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.newContact);
            this.groupBox4.Location = new System.Drawing.Point(12, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(249, 53);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "البريد الألكتروني او رقم الهاتف";
            // 
            // newContact
            // 
            this.newContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newContact.Location = new System.Drawing.Point(3, 23);
            this.newContact.Name = "newContact";
            this.newContact.Size = new System.Drawing.Size(243, 27);
            this.newContact.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newLastName);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(249, 53);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الأسم الأخير";
            // 
            // newLastName
            // 
            this.newLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newLastName.Location = new System.Drawing.Point(3, 23);
            this.newLastName.Name = "newLastName";
            this.newLastName.Size = new System.Drawing.Size(243, 27);
            this.newLastName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newFirstName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(249, 54);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الأسم الأول";
            // 
            // newFirstName
            // 
            this.newFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFirstName.Location = new System.Drawing.Point(3, 23);
            this.newFirstName.Name = "newFirstName";
            this.newFirstName.Size = new System.Drawing.Size(243, 27);
            this.newFirstName.TabIndex = 0;
            // 
            // editFacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 364);
            this.Controls.Add(this.editFasultyBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "editFacultyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editFacultyForm";
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

        private System.Windows.Forms.Button editFasultyBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox NewDepartmentsCheckBoxSelect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox newContact;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox newLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox newFirstName;
    }
}