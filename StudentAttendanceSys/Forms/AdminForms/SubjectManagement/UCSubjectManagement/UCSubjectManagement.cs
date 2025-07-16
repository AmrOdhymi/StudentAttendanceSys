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
using StudentAttendanceSys.Models;
using StudentAttendanceSys.Services.Admin;


namespace StudentAttendanceSys.Forms.AdminForms.SubjectManagement.UCSubjectManagement
{
    public partial class UCSubjectManagement : UserControl
    {
        CoursesService courses = new CoursesService();
        private List<Course> allcourses;
        public UCSubjectManagement()
        {
            InitializeComponent();
            allcourses = courses.getAllCourses();
            SubjectDataGridView.DataSource = allcourses;
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
            if(SubjectDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = SubjectDataGridView.SelectedRows[0];
                string subjectName = selectedRow.Cells["CourseName"].Value.ToString();
                DialogResult deleteResult = MessageBox.Show("\nهل انت متاكد من حذف مادة" + "\n" + subjectName,
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

        private void SubjectSercheBox_TextChanged(object sender, EventArgs e)
        {
            string filterCourseName = SubjectSercheBox.Text;

            //القائمه التي تحتفظ بالمواد بعد الفلتره
            List<Course> filteredCourses = new List<Course>();

            // المرور على كل ماده في القائمة الأصلية
            foreach (Course course in allcourses)
            {
                // تحويل اسم الماده إلى حروف صغيرة للتحقق من وجود النص بداخله
                string courseNameLower = course.CourseName.ToLower();

                // تحويل النص المعطى إلى حروف صغيرة 
                string searchNameLower = filterCourseName.ToLower();

                // التحقق مما إذا كان اسم الماده يحتوي على النص المكتوب
                if (courseNameLower.Contains(searchNameLower))
                {
                    // إذا وجدنا تطابق نضيف الكورس للقائمة المفلتره
                    filteredCourses.Add(course);
                }
            }

            // تعيين القائمة المصفاة كمصدر بيانات للـ DataGridView ليتم عرضها
            SubjectDataGridView.DataSource = filteredCourses;
        }
    }
}
