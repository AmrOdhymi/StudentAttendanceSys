﻿namespace StudentAttendanceSys.Forms.AdminForms.AdminDashboard
{
    partial class AdminDashboardForm
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
            this.sideMenu = new System.Windows.Forms.Panel();
            this.mainUC = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.studentMUCBtn = new System.Windows.Forms.Button();
            this.reportUCBtn = new System.Windows.Forms.Button();
            this.subjectMUCBtn = new System.Windows.Forms.Button();
            this.departmentMUCBtn = new System.Windows.Forms.Button();
            this.facultyMUCBtn = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.adminStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.userNamrToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sideMenu.SuspendLayout();
            this.adminStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sideMenu.Controls.Add(this.mainUC);
            this.sideMenu.Controls.Add(this.exit);
            this.sideMenu.Controls.Add(this.studentMUCBtn);
            this.sideMenu.Controls.Add(this.reportUCBtn);
            this.sideMenu.Controls.Add(this.subjectMUCBtn);
            this.sideMenu.Controls.Add(this.departmentMUCBtn);
            this.sideMenu.Controls.Add(this.facultyMUCBtn);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.sideMenu.Location = new System.Drawing.Point(792, 0);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(190, 453);
            this.sideMenu.TabIndex = 0;
            // 
            // mainUC
            // 
            this.mainUC.BackColor = System.Drawing.Color.Gainsboro;
            this.mainUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainUC.Location = new System.Drawing.Point(10, 9);
            this.mainUC.Name = "mainUC";
            this.mainUC.Size = new System.Drawing.Size(170, 50);
            this.mainUC.TabIndex = 0;
            this.mainUC.Text = "الرئيسية";
            this.mainUC.UseVisualStyleBackColor = false;
            this.mainUC.Click += new System.EventHandler(this.mainUC_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Gainsboro;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(10, 394);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(170, 50);
            this.exit.TabIndex = 6;
            this.exit.Text = "خروج";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // studentMUCBtn
            // 
            this.studentMUCBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.studentMUCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentMUCBtn.Location = new System.Drawing.Point(10, 81);
            this.studentMUCBtn.Name = "studentMUCBtn";
            this.studentMUCBtn.Size = new System.Drawing.Size(170, 50);
            this.studentMUCBtn.TabIndex = 1;
            this.studentMUCBtn.Text = "إدارة الطلاب";
            this.studentMUCBtn.UseVisualStyleBackColor = false;
            this.studentMUCBtn.Click += new System.EventHandler(this.studentMUCBtn_Click);
            // 
            // reportUCBtn
            // 
            this.reportUCBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.reportUCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportUCBtn.Location = new System.Drawing.Point(10, 317);
            this.reportUCBtn.Name = "reportUCBtn";
            this.reportUCBtn.Size = new System.Drawing.Size(170, 50);
            this.reportUCBtn.TabIndex = 5;
            this.reportUCBtn.Text = "التقارير";
            this.reportUCBtn.UseVisualStyleBackColor = false;
            // 
            // subjectMUCBtn
            // 
            this.subjectMUCBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.subjectMUCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectMUCBtn.Location = new System.Drawing.Point(10, 139);
            this.subjectMUCBtn.Name = "subjectMUCBtn";
            this.subjectMUCBtn.Size = new System.Drawing.Size(170, 50);
            this.subjectMUCBtn.TabIndex = 2;
            this.subjectMUCBtn.Text = "إدارة المواد";
            this.subjectMUCBtn.UseVisualStyleBackColor = false;
            this.subjectMUCBtn.Click += new System.EventHandler(this.subjectMUCBtn_Click);
            // 
            // departmentMUCBtn
            // 
            this.departmentMUCBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.departmentMUCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentMUCBtn.Location = new System.Drawing.Point(10, 255);
            this.departmentMUCBtn.Name = "departmentMUCBtn";
            this.departmentMUCBtn.Size = new System.Drawing.Size(170, 50);
            this.departmentMUCBtn.TabIndex = 4;
            this.departmentMUCBtn.Text = "إدارة الاقسام";
            this.departmentMUCBtn.UseVisualStyleBackColor = false;
            this.departmentMUCBtn.Click += new System.EventHandler(this.departmentMUCBtn_Click);
            // 
            // facultyMUCBtn
            // 
            this.facultyMUCBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.facultyMUCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyMUCBtn.Location = new System.Drawing.Point(10, 196);
            this.facultyMUCBtn.Name = "facultyMUCBtn";
            this.facultyMUCBtn.Size = new System.Drawing.Size(170, 50);
            this.facultyMUCBtn.TabIndex = 3;
            this.facultyMUCBtn.Text = "إدارة هيئة التدريس";
            this.facultyMUCBtn.UseVisualStyleBackColor = false;
            this.facultyMUCBtn.Click += new System.EventHandler(this.facultyMUCBtn_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(792, 425);
            this.panelContainer.TabIndex = 1;
            // 
            // adminStatusStrip
            // 
            this.adminStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.adminStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.userNamrToolStripStatusLabel});
            this.adminStatusStrip.Location = new System.Drawing.Point(0, 427);
            this.adminStatusStrip.Name = "adminStatusStrip";
            this.adminStatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.adminStatusStrip.Size = new System.Drawing.Size(792, 26);
            this.adminStatusStrip.TabIndex = 2;
            this.adminStatusStrip.Text = "adminStatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 20);
            this.toolStripStatusLabel1.Text = "أسم المستخدم / ";
            // 
            // userNamrToolStripStatusLabel
            // 
            this.userNamrToolStripStatusLabel.Name = "userNamrToolStripStatusLabel";
            this.userNamrToolStripStatusLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.adminStatusStrip);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.sideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboardForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboardForm_FormClosing);
            this.sideMenu.ResumeLayout(false);
            this.adminStatusStrip.ResumeLayout(false);
            this.adminStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Button mainUC;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button studentMUCBtn;
        private System.Windows.Forms.Button reportUCBtn;
        private System.Windows.Forms.Button subjectMUCBtn;
        private System.Windows.Forms.Button departmentMUCBtn;
        private System.Windows.Forms.Button facultyMUCBtn;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.StatusStrip adminStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel userNamrToolStripStatusLabel;
    }
}