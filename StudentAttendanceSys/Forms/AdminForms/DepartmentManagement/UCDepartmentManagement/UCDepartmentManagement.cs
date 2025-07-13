using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAttendanceSys.Forms.AdminForms.DepartmentManagement.AddDepartmentForm;
using StudentAttendanceSys.Forms.AdminForms.DepartmentManagement.EditDepartmentForm;

namespace StudentAttendanceSys.Forms.AdminForms.DepartmentManagement.UCDepartmentManagement
{
    public partial class UCDepartmentManagement : UserControl
    {
        public UCDepartmentManagement()
        {
            InitializeComponent();
        }

        private void addNewDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addDepartmentForm addDepartmentForm = new addDepartmentForm();
            addDepartmentForm.ShowDialog();
        }

        private void editCurrentDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editDepartmentForm editDepartmentForm = new editDepartmentForm();
            editDepartmentForm.ShowDialog();
        }

        private void deleteCurrentDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string departmentName = "علوم الحاسوب";
            DialogResult deleteResult = MessageBox.Show("\nهل انت متاكد من حذف الطالب" + "\n" + departmentName,
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
