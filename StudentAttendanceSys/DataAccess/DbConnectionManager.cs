using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace StudentAttendanceSys.DataAccess
{
    public class DbConnectionManager
    {
        SqlConnection sqlConnection;


        //database Connection
        public DbConnectionManager()
        {
            //اسم السرفر ثم اسم قاعدة البيانات ثم طريقة الدخول الى السرفر
            //Arise
            //DESKTOP-46062MH
            sqlConnection = new SqlConnection(@"Server=Arise; Database=StudentAttendanceDB;Integrated Security=true");
        }

        // open database Connection
        public void Open()
        {
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();
        }

        // close database Connection
        public void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }


        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
