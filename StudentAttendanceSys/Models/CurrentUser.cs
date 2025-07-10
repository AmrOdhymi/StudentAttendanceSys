using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSys.Models
{
    public static class CurrentUser
    {
        public static int User_ID { get; set; }
        public static string User_Type { get; set; }
        public static string User_Full_Name { get; set; }

    }
}

// كلاس للاحتفاظ بابيانات المستخدم الحالي الذي قام بتسجيل الدخول