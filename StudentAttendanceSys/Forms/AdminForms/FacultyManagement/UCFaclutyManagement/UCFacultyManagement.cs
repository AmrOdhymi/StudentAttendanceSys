using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAttendanceSys.Forms.AdminForms.FacultyManagement.AddFacultyForm;
using StudentAttendanceSys.Forms.AdminForms.FacultyManagement.EditFacultyForm;

namespace StudentAttendanceSys.Forms.AdminForms.FacultyManagement.UCFaclutyManagement
{
    public partial class UCFacultyManagement : UserControl
    {
        public UCFacultyManagement()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFacultyForm addFacultyForm = new addFacultyForm();
            addFacultyForm.ShowDialog();
        }

        private void editCurrentStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditFacultyForm.editFacultyForm editFacultyForm = new EditFacultyForm.editFacultyForm();
            editFacultyForm.ShowDialog();
        }

        private void deleteCurrentStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string facultyName = "محمد";
            string facultytId = "1234";
            DialogResult deleteResult = MessageBox.Show("\nهل انت متاكد من حذف الدكتور" + "\n" + facultyName + "\nID الذي يملك ال " + "\n" + facultytId,
                "تنبيه",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign
                );

            if (deleteResult == DialogResult.Yes)
            {
                // نحذف من قواعد البيانات
            }
        }
    }
}
