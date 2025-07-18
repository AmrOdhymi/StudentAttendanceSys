﻿namespace StudentAttendanceSys.Forms.AdminForms.StudentManagement.EditStudentForm
{
    partial class editStudentForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.editStudentBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.newDepartmentListBoxSelect = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.newContact = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newLastName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.newStudentId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newFirstName = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editStudentBtn
            // 
            this.editStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStudentBtn.Location = new System.Drawing.Point(12, 306);
            this.editStudentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editStudentBtn.Name = "editStudentBtn";
            this.editStudentBtn.Size = new System.Drawing.Size(249, 46);
            this.editStudentBtn.TabIndex = 9;
            this.editStudentBtn.Text = "Edit Student";
            this.editStudentBtn.UseVisualStyleBackColor = true;
            this.editStudentBtn.Click += new System.EventHandler(this.editStudentBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.newDepartmentListBoxSelect);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 190);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(249, 54);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "القسم";
            // 
            // newDepartmentListBoxSelect
            // 
            this.newDepartmentListBoxSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newDepartmentListBoxSelect.FormattingEnabled = true;
            this.newDepartmentListBoxSelect.ItemHeight = 20;
            this.newDepartmentListBoxSelect.Location = new System.Drawing.Point(4, 24);
            this.newDepartmentListBoxSelect.Margin = new System.Windows.Forms.Padding(4);
            this.newDepartmentListBoxSelect.Name = "newDepartmentListBoxSelect";
            this.newDepartmentListBoxSelect.Size = new System.Drawing.Size(241, 26);
            this.newDepartmentListBoxSelect.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.newContact);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 131);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(249, 54);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "البريد الألكتروني او رقم الهاتف";
            // 
            // newContact
            // 
            this.newContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newContact.Location = new System.Drawing.Point(4, 24);
            this.newContact.Margin = new System.Windows.Forms.Padding(4);
            this.newContact.Name = "newContact";
            this.newContact.Size = new System.Drawing.Size(241, 27);
            this.newContact.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newLastName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(249, 54);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الأسم الأخير";
            // 
            // newLastName
            // 
            this.newLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newLastName.Location = new System.Drawing.Point(4, 24);
            this.newLastName.Margin = new System.Windows.Forms.Padding(4);
            this.newLastName.Name = "newLastName";
            this.newLastName.Size = new System.Drawing.Size(241, 27);
            this.newLastName.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.newStudentId);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 247);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(249, 54);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الرقم الجامعي";
            // 
            // newStudentId
            // 
            this.newStudentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newStudentId.Location = new System.Drawing.Point(4, 24);
            this.newStudentId.Margin = new System.Windows.Forms.Padding(4);
            this.newStudentId.Name = "newStudentId";
            this.newStudentId.Size = new System.Drawing.Size(241, 27);
            this.newStudentId.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newFirstName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(249, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الأسم الأول";
            // 
            // newFirstName
            // 
            this.newFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFirstName.Location = new System.Drawing.Point(4, 24);
            this.newFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.newFirstName.Name = "newFirstName";
            this.newFirstName.Size = new System.Drawing.Size(241, 27);
            this.newFirstName.TabIndex = 0;
            // 
            // editStudentForm
            // 
            this.AcceptButton = this.editStudentBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 364);
            this.Controls.Add(this.editStudentBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "editStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditStudentForm";
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button editStudentBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox newDepartmentListBoxSelect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox newContact;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox newLastName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox newStudentId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox newFirstName;
    }
}