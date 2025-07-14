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
    internal class LoginService
    {
        DbConnectionManager _connectionManager=new DbConnectionManager();
        
        string query = "SELECT User_ID, User_Type, User_Full_Name " +
                               "FROM tbl_Users " +
                               "WHERE User_Name=@username AND User_Password=@password";
        public CurrentUser Login(string userName , string password)
        {
            var param = new SqlParameter[]
       {
            new SqlParameter("@username", SqlDbType.NVarChar) { Value = userName },
            new SqlParameter("@password", SqlDbType.NVarChar) { Value = password } 
       };
           

            CurrentUser result = _connectionManager.ExecuteReader(query, reader =>
            {
                
                if (reader.Read())
                {
                    return new CurrentUser(
                 (int)reader["User_ID"],
                 (string)reader["User_Type"],
                 (string)reader["User_Full_Name"]);
                }
                return new CurrentUser(0,null,null);
            }, param);

            return result;
        }
    }
}
