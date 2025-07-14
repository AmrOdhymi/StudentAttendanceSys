using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAttendanceSys.DataAccess;
using StudentAttendanceSys.Services.Admin;


namespace StudentAttendanceSys.Forms.AdminForms.DepartmentManagement.AddDepartmentForm
{
    public partial class addDepartmentForm : Form
    {
        public addDepartmentForm()
        {
            InitializeComponent();
        }

        private void addDepartmentBtn_Click(object sender, EventArgs e)
        {  // قراءة النص من مربع النص الخاص برقم القسم، مع إزالة الفراغات من البداية والنهاية
            string idText = departmentID.Text.Trim();

            // قراءة النص من مربع النص الخاص باسم القسم
            string name = departmentName.Text.Trim();

            // التحقق من أن كلا الحقلين ليسا فارغين
            if (string.IsNullOrWhiteSpace(idText) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("يرجى تعبئة جميع الحقول");
                return; // إيقاف تنفيذ الكود إذا الحقول غير مكتملة
            }

            // محاولة تحويل النص المدخل لرقم صحيح (int)، وتخزينه في المتغير departmentId
            // إذا فشل التحويل (مثلاً: المستخدم كتب "abc")، يتم عرض رسالة خطأ
            if (!int.TryParse(idText, out int departmentId))
            {
                MessageBox.Show("رقم القسم يجب أن يكون رقمًا صحيحًا");
                return; // إيقاف التنفيذ إذا لم يكن الإدخال رقمًا
            }

            // إنشاء كائن من كلاس DepartmentService المسؤول عن تنفيذ الإجراء المخزن
            DepartmentService deptService = new DepartmentService();

            // استدعاء الدالة AddDepartment لإضافة القسم إلى قاعدة البيانات
            bool added = deptService.AddDepartment(departmentId, name);

            // إذا نجحت الإضافة
            if (added)
            {
                MessageBox.Show("تمت الإضافة بنجاح");

                // مسح النصوص من مربعات الإدخال بعد الإضافة
                departmentID.Clear();
                departmentName.Clear();
            }
            else
            {
                // إذا فشلت الإضافة لأي سبب
                MessageBox.Show("فشل في الإضافة");
            }
        }

        
    }
}
