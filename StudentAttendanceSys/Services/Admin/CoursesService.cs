using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentAttendanceSys.DataAccess;
using StudentAttendanceSys.Models;
using System.Data.SqlClient;
using System.Data;

namespace StudentAttendanceSys.Services.Admin
{
     
    public class CoursesService
    {
        private DbConnectionManager _db;
        public CoursesService()
        {
            _db = new DbConnectionManager();   
        }
        // لاستبدال اوامر السكول Procedure  محتاج انشاء دوال
        public bool AddCourse(string courseName,string courseCode,int doctorId,int departmentId)
        {
            string query="";
            try
            {
                var param = new SqlParameter[]{
          //  new SqlParameter("@username", SqlDbType.NVarChar) { Value = id },
            new SqlParameter("@Course_Name", SqlDbType.NVarChar) { Value = courseName },
            new SqlParameter("@Course_Code", SqlDbType.NVarChar) { Value = courseCode },
            new SqlParameter("@User_ID", SqlDbType.Int) { Value = doctorId },
            new SqlParameter("@Department_ID", SqlDbType.Int) { Value = departmentId },
            };

                _db.ExecuteNonQuery(query, param);
                _db.Close();
                return true;
            }
            catch (Exception ex)
            {
                _db.Close();
                return false;
            }
        } 
        public bool UpdateCourse(string courseName, string courseCode, int doctorId, int departmentId,int courseId)
        {
            string query="";
            try
            {
                var param = new SqlParameter[]{
            new SqlParameter("@username", SqlDbType.NVarChar) { Value = courseId },
            new SqlParameter("@Course_Name", SqlDbType.NVarChar) { Value = courseName },
            new SqlParameter("@Course_Code", SqlDbType.NVarChar) { Value = courseCode },
            new SqlParameter("@User_ID", SqlDbType.Int) { Value = doctorId },
            new SqlParameter("@Department_ID", SqlDbType.Int) { Value = departmentId },
            };

                _db.ExecuteNonQuery(query, param);
                _db.Close();
                return true;
            }
            catch (Exception ex)
            {
                _db.Close();
                return false;
            }
        }
        public bool DeleteCourse(int courseId)
        {
            string query = "";
            try
            {
                var param = new SqlParameter("@Course_ID", SqlDbType.Int) { Value = courseId };
            
                _db.ExecuteNonQuery(query, param);
                _db.Close();
                return true;
            }
            catch (Exception ex)
            {
                _db.Close();
                return false;
            }
        }
        public course getCourseById(int courseID)        
        {
            string query = "SELECT c.Course_ID, c.Course_Name,c.Course_code,c.User_ID,cd.Department_ID FROM dbo.tbl_Course c INNER JOIN dbo.tbl_Course_Department cd ON c.Course_ID = cd.Course_ID WHERE c.Course_ID=@Course_ID; ";
            course result= new course(0,null,null,0,0);
            try
            {
                var param = new SqlParameter("@Course_ID", SqlDbType.Int) { Value = courseID };

                result = _db.ExecuteReader(query, reader =>
                {
                    if (reader.Read())
                    {
                        return new course(
                             (int)reader["Course_ID"],
                             (string)reader["Course_Name"],
                             (string)reader["Course_code"],
                             (int)reader["User_ID"],
                             (int)reader["Department_ID"]);
                    }
                    return result;
                }, param);

                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }
        public List<course> getAllCourses()
        {
            string query = "SELECT c.Course_ID, c.Course_Name, c.Course_code, c.User_ID, cd.Department_ID FROM dbo.tbl_Course c INNER JOIN dbo.tbl_Course_Department cd ON c.Course_ID = cd.Course_ID;";
            List<course> result = new List<course>();

            try
            {
                return _db.ExecuteReader(query, reader =>
                {
                    List<course> list = new List<course>();
                    while (reader.Read())
                    {
                        list.Add(new course(
                            (int)reader["Course_ID"],
                            (string)reader["Course_Name"],
                            (string)reader["Course_code"],
                            (int)reader["User_ID"],
                            (int)reader["Department_ID"]));
                    }
                    return list;
                });
            }
            catch (Exception ex)
            {
                // Log the exception
                return new List<course>();
            }
        }



    }
}

