using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAttendanceSys.Forms.AdminForms.StudentManagement.UCStudentManagement;
using StudentAttendanceSys.Forms.AdminForms.DepartmentManagement.UCDepartmentManagement;
using StudentAttendanceSys.Forms.AdminForms.FacultyManagement.UCFaclutyManagement;
using StudentAttendanceSys.Forms.AdminForms.SubjectManagement.UCSubjectManagement;
using StudentAttendanceSys.Utils;

namespace StudentAttendanceSys.Forms.AdminForms.AdminDashboard
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm(string userName)
        {
            InitializeComponent();
            userNamrToolStripStatusLabel.Text = userName;
        }

        private void studentMUCBtn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UCStudentManagement UCStudentManagement = new UCStudentManagement();
            panelContainer.Controls.Add(UCStudentManagement);
        }

        private void subjectMUCBtn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UCSubjectManagement UCSubjectManagement = new UCSubjectManagement();
            panelContainer.Controls.Add(UCSubjectManagement);
        }

        private void facultyMUCBtn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UCFacultyManagement UCFacultyManagement = new UCFacultyManagement();
            panelContainer.Controls.Add(UCFacultyManagement);
        }

        private void departmentMUCBtn_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UCDepartmentManagement UCDepartmentManagement = new UCDepartmentManagement();
            panelContainer.Controls.Add(UCDepartmentManagement);
        }

        private void mainUC_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminDashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ExitService.ConfirmExit())
            {
                e.Cancel = true;
            }
        }
    }
}
