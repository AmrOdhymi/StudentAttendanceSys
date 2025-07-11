using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; //مؤقت
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAttendanceSys.DataAccess;

namespace StudentAttendanceSys.Forms.AdminForms.StudentManagement.UCStudentManagement
{
    public partial class UCStudentManagement : UserControl
    {
        DbConnectionManager dbManager = new DbConnectionManager();
        public UCStudentManagement()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "yyyy";
        }

        private void UCStudentManagement_Load(object sender, EventArgs e)
        {
        }

    }
}