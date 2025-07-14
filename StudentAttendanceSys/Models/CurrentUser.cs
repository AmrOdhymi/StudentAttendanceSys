namespace StudentAttendanceSys.Models
{
    public struct CurrentUser
    {
        public int UserId { get; }
        public string UserType { get; }
        public string FullName { get; }

        public CurrentUser(int userId, string userType, string fullName)
        {
            UserId = userId;
            UserType = userType;
            FullName = fullName;
        }
    }
}




// كلاس للاحتفاظ بابيانات المستخدم الحالي الذي قام بتسجيل الدخول