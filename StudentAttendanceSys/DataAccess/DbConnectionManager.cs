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
        SqlCommand command;
        SqlDataReader reader;


        //database Connection
        public DbConnectionManager()
        {
            //اسم السرفر ثم اسم قاعدة البيانات ثم طريقة الدخول الى السرفر
            string connectionString = Environment.GetEnvironmentVariable("student_database_CONNECTION_STRING", EnvironmentVariableTarget.User);

            sqlConnection = new SqlConnection(connectionString);
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

            reader.Close();
        }


        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }

        //============= experemntal code don't use ---- كود للتجربة لا تستخدم ======== // 

        // this function is for excetuting insertions and editing into the database 
        // NOTE: it's not for selecting (for select use ExecuteReader) 
        public void ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            command = new SqlCommand(sql, sqlConnection);

            command.Parameters.AddRange(parameters);
            this.Open();
            command.ExecuteNonQuery();

        }
        // this function is for reading or selecting form the database 
        public T ExecuteReader<T>(string sql, Func<SqlDataReader, T> map, params SqlParameter[] parameters)
        {
            command = new SqlCommand(sql, sqlConnection);
            command.Parameters.AddRange(parameters);
            this.Open();
            reader = command.ExecuteReader();
            
                return map(reader);
            
        }
    }
}
