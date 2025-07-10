namespace StudentAttendanceSys.Forms.LoginForm
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canselBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.password = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.passwordIcon = new System.Windows.Forms.PictureBox();
            this.userNameIcon = new System.Windows.Forms.PictureBox();
            this.passwordVisibleStatus = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordVisibleStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // canselBtn
            // 
            this.canselBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canselBtn.Location = new System.Drawing.Point(46, 193);
            this.canselBtn.Name = "canselBtn";
            this.canselBtn.Size = new System.Drawing.Size(95, 41);
            this.canselBtn.TabIndex = 10;
            this.canselBtn.Text = "إلغاء";
            this.canselBtn.UseVisualStyleBackColor = true;
            this.canselBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // logBtn
            // 
            this.logBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.Location = new System.Drawing.Point(247, 193);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(95, 41);
            this.logBtn.TabIndex = 9;
            this.logBtn.Text = "دخول";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(44, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(295, 61);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "كلمة المرور";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(5, 25);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(284, 30);
            this.password.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(295, 61);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أسم المستخدم";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(5, 25);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(284, 30);
            this.userName.TabIndex = 0;
            // 
            // passwordIcon
            // 
            this.passwordIcon.BackColor = System.Drawing.Color.Black;
            this.passwordIcon.Image = global::StudentAttendanceSys.Properties.Resources.password;
            this.passwordIcon.Location = new System.Drawing.Point(343, 134);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(30, 30);
            this.passwordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordIcon.TabIndex = 13;
            this.passwordIcon.TabStop = false;
            // 
            // userNameIcon
            // 
            this.userNameIcon.BackColor = System.Drawing.Color.Black;
            this.userNameIcon.Image = global::StudentAttendanceSys.Properties.Resources.userName;
            this.userNameIcon.Location = new System.Drawing.Point(343, 38);
            this.userNameIcon.Name = "userNameIcon";
            this.userNameIcon.Size = new System.Drawing.Size(30, 30);
            this.userNameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userNameIcon.TabIndex = 12;
            this.userNameIcon.TabStop = false;
            // 
            // passwordVisibleStatus
            // 
            this.passwordVisibleStatus.BackColor = System.Drawing.Color.Black;
            this.passwordVisibleStatus.Image = global::StudentAttendanceSys.Properties.Resources.visibility_off;
            this.passwordVisibleStatus.Location = new System.Drawing.Point(11, 133);
            this.passwordVisibleStatus.Name = "passwordVisibleStatus";
            this.passwordVisibleStatus.Size = new System.Drawing.Size(30, 30);
            this.passwordVisibleStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordVisibleStatus.TabIndex = 11;
            this.passwordVisibleStatus.TabStop = false;
            this.passwordVisibleStatus.Click += new System.EventHandler(this.passwordVisibleStatus_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.logBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 261);
            this.Controls.Add(this.passwordIcon);
            this.Controls.Add(this.userNameIcon);
            this.Controls.Add(this.passwordVisibleStatus);
            this.Controls.Add(this.canselBtn);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordVisibleStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox passwordIcon;
        private System.Windows.Forms.PictureBox userNameIcon;
        private System.Windows.Forms.PictureBox passwordVisibleStatus;
        private System.Windows.Forms.Button canselBtn;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox userName;
    }
}