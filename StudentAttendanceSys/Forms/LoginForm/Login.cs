using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAttendanceSys.Utils;
using StudentAttendanceSys.DataAccess;
using StudentAttendanceSys.Models;
using System.Data.SqlClient; //مؤقت للتجربه

namespace StudentAttendanceSys.Forms.LoginForm
{
    public partial class Login : Form
    {
        Boolean loginSuccessful = false;
        Boolean visibilityState = false;
        public Login()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void passwordVisibleStatus_Click(object sender, EventArgs e)
        {
            if (visibilityState)
            {
                visibilityState = false;
                password.PasswordChar = '*';
                passwordVisibleStatus.Image = Image.FromFile("Icons//visibility_off.png");
            }
            else if (!visibilityState)
            {
                visibilityState = true;
                password.PasswordChar = '\0';
                passwordVisibleStatus.Image = Image.FromFile("Icons//visibility.png");
            }
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            if (ValidationService.CheckIsEmpty(userName.Text) && ValidationService.CheckIsEmpty(password.Text))
            {



                // مؤقت للتجربه الى يتم إنشاء دوال الاستعلام


                // للتجربه قم بانشاء اثنين مستخدمين الاول مدير واثاني دكتور
                //عند تسجيل الدخول كادكتور يفتح تلقائيا نافذة الدكتور
                //وعند تسجيل الدخول كامدير يفتح تلقائيا واجهة المدير






                string name = userName.Text;
                string pass = password.Text;

                DbConnectionManager dbManager = new DbConnectionManager();

                dbManager.Open();

                string query = "SELECT User_ID, User_Type, User_Full_Name " +
                               "FROM tbl_Users " +
                               "WHERE User_Name=@username AND User_Password=@password";

                SqlCommand command = new SqlCommand(query, dbManager.GetConnection());
                command.Parameters.AddWithValue("@username", name);
                command.Parameters.AddWithValue("@password", pass);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    CurrentUser.User_ID = reader.GetInt32(0);
                    CurrentUser.User_Type = reader.GetString(1);
                    CurrentUser.User_Full_Name = reader.GetString(2);

                    loginSuccessful = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("❌ هناك خطأ في اسم المستخدم أو كلمة المرور");
                }

                reader.Close();
                dbManager.Close();
























            }
            else
            {
                MessageBox.Show("يجب ملئ جميع الحقول", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!loginSuccessful)
            {
                if (!ExitService.ConfirmExit())
                    e.Cancel = true;
            }
        }
    }
}
