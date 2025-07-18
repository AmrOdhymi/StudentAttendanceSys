﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAttendanceSys.Utils;
using StudentAttendanceSys.Models;
using StudentAttendanceSys.Services.Admin;

namespace StudentAttendanceSys.Forms.LoginForm
{
    public partial class Login : Form
    {
        Boolean loginSuccessful = false;
        Boolean visibilityState = false;
        public CurrentUser user;
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
                passwordVisibleStatus.Image = Properties.Resources.visibility_off;
            }
            else if (!visibilityState)
            {
                visibilityState = true;
                password.PasswordChar = '\0';
                passwordVisibleStatus.Image =Properties.Resources.visibility;
            }
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            if (ValidationService.CheckIsEmpty(userName.Text) && ValidationService.CheckIsEmpty(password.Text))
            {
                string name = userName.Text;
                string pass = password.Text;

                LoginService loginServise = new LoginService();
   
                 user = loginServise.Login(name, pass);
                if(user.UserType != null)
                {
                    loginSuccessful = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("❌ هناك خطأ في اسم المستخدم أو كلمة المرور");
                }

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
