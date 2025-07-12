using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAttendanceSys.Forms.AdminForms.SubjectManagement.AddSubjectForm;
using StudentAttendanceSys.Forms.AdminForms.SubjectManagement.EditSubjectForm;


namespace StudentAttendanceSys.Forms.AdminForms.SubjectManagement.UCSubjectManagement
{
    public partial class UCSubjectManagement : UserControl
    {
        public UCSubjectManagement()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSubjectForm addSubjectForm = new addSubjectForm();
            addSubjectForm.ShowDialog();
        }

        private void editCurrentStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editSubjectForm editSubjectForm = new editSubjectForm();
            editSubjectForm.ShowDialog();
        }

        private void deleteCurrentStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string studentName = "C++";
            DialogResult deleteResult = MessageBox.Show("\nهل انت متاكد من حذف المادة" + "\n" + studentName,
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
