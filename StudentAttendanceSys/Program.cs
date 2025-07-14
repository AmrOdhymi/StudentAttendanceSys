using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAttendanceSys.Forms.LoginForm;
using StudentAttendanceSys.Forms.AdminForms.AdminDashboard;
using StudentAttendanceSys.Forms.FacultyForm.FacultyMainMenue;
using StudentAttendanceSys.Models;
using StudentAttendanceSys.Forms.FacultyForm.AttendanceForm;
using StudentAttendanceSys.Forms.AdminForms.DepartmentManagement.AddDepartmentForm;


namespace StudentAttendanceSys
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new addDepartmentForm());

            /*
                        Login login = new Login();
                        DialogResult result = login.ShowDialog();

                        if (result == DialogResult.OK)
                        {

                            if (CurrentUser.User_Type == "Doctor")
                            {
                                Application.Run(new FacultyMainMenueForm());
                            }
                            else if (CurrentUser.User_Type == "Admin")
                            {
                                Application.Run(new AdminDashboardForm());
                            }

                        }
            */
        }
    }
}
