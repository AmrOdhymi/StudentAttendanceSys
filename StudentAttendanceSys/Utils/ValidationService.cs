using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSys.Utils
{
    public class ValidationService
    {
        public static bool CheckIsEmpty(string str)
        {
            return str.Trim() != String.Empty;
        }
    }
}
//sql كلاس فيه دالة للتحقق هل النص فارغ او لا يجب اضافة بعض اساليب الامان للحمايه من ثغرة حقk