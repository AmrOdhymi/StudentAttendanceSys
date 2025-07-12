using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; //مؤقت
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAttendanceSys.DataAccess;
using StudentAttendanceSys.Forms.AdminForms.StudentManagement.AddStudentForm;
using StudentAttendanceSys.Forms.AdminForms.StudentManagement.EditStudentForm;

namespace StudentAttendanceSys.Forms.AdminForms.StudentManagement.UCStudentManagement
{
    public partial class UCStudentManagement : UserControl
    {
        DbConnectionManager dbManager = new DbConnectionManager();
        public UCStudentManagement()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "yyyy";
        }

        private void UCStudentManagement_Load(object sender, EventArgs e)
        {

        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm.addStudentForm addStudentForm = new addStudentForm();
            addStudentForm.ShowDialog();
        }

        private void editCurrentStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editStudentForm editStudentForm = new editStudentForm();
            editStudentForm.ShowDialog();
        }

        private void deleteCurrentStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string studentName = "يوسف";
            string studentId = "1234";
            DialogResult deleteResult = MessageBox.Show("\nهل انت متاكد من حذف الطالب" + "\n"+ studentName + "\nالذي رقمه الجامعي" + "\n"+ studentId ,
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