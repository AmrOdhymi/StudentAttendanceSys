using System;
using System.Data;
using System.Data.SqlClient;
using StudentAttendanceSys.DataAccess;

namespace StudentAttendanceSys.Services.Admin
{
    /// <summary>
    /// خدمة لإدارة الأقسام (Department) - إضافة أقسام إلى قاعدة البيانات.
    /// </summary>
    public class DepartmentService
    {
        // مدير الاتصال بقاعدة البيانات
        private readonly DbConnectionManager _db;

        /// <summary>
        /// مُنشئ الخدمة يقوم بتهيئة الاتصال بقاعدة البيانات.
        /// </summary>
        public DepartmentService()
        {
            _db = new DbConnectionManager();
        }

        /// <summary>
        /// إضافة قسم جديد إلى قاعدة البيانات باستخدام الإجراء المخزن Add_Department.
        /// </summary>
        /// <param name="departmentId">رقم القسم</param>
        /// <param name="departmentName">اسم القسم</param>
        /// <returns>ترجع true إذا نجحت الإضافة، و false إذا فشلت</returns>
        public bool AddDepartment(int departmentId, string departmentName)
        {
            try
            {
                // إنشاء أمر SQL لتشغيل الإجراء المخزن
                using (SqlCommand cmd = new SqlCommand("Add_Department", _db.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // إضافة المعاملات (parameters) إلى الأمر
                    cmd.Parameters.AddWithValue("@Department_ID", departmentId);
                    cmd.Parameters.AddWithValue("@Department_Name", departmentName);

                    // فتح الاتصال وتنفيذ الأمر
                    _db.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    _db.Close();

                    // التحقق من نجاح العملية
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // طباعة الخطأ في حالة الفشل
                Console.WriteLine("خطأ أثناء إضافة القسم: " + ex.Message);

                // تأكد من إغلاق الاتصال
                _db.Close();
                return false;
            }
        }
    }
}
