using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSys.Models
{
    public struct course
    {
        public int CourseId { get; }
        public string CourseName { get; }
        public string CourseCode { get; }
        public int DoctorId { get; }
        public int DepartmentId { get; }

        public course(int courseId, string courseName, string courseCode, int doctorId, int departmentId)
        {
            CourseId = courseId;
            CourseName = courseName;
            CourseCode = courseCode;
            DoctorId = doctorId;
            DepartmentId = departmentId;
        }
    }
}

