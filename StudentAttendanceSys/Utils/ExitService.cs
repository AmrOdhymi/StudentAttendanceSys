﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSys.Utils
{
    public class ExitService
    {
        public static bool ConfirmExit()
        {
            DialogResult r = MessageBox.Show("هل انت متاكد من اغلاق البرنامج",
                "تحذير",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign
                );
            return r == DialogResult.Yes;
        }
    }
}
//رسالة تاكيد الخروج مشتركه بين الواجهات