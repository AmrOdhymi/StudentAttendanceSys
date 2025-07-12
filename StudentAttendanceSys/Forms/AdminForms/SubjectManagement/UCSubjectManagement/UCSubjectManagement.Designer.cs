namespace StudentAttendanceSys.Forms.AdminForms.SubjectManagement.UCSubjectManagement
{
    partial class UCSubjectManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SubjectListBoxSelect = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SubjectSercheBox = new System.Windows.Forms.TextBox();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject Management";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SubjectListBoxSelect);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(140, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(169, 64);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "فلتره حسب القسم";
            // 
            // SubjectListBoxSelect
            // 
            this.SubjectListBoxSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectListBoxSelect.FormattingEnabled = true;
            this.SubjectListBoxSelect.ItemHeight = 20;
            this.SubjectListBoxSelect.Location = new System.Drawing.Point(3, 23);
            this.SubjectListBoxSelect.Name = "SubjectListBoxSelect";
            this.SubjectListBoxSelect.Size = new System.Drawing.Size(163, 38);
            this.SubjectListBoxSelect.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SubjectSercheBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(315, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(361, 64);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بحث بأسم المادة";
            // 
            // SubjectSercheBox
            // 
            this.SubjectSercheBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectSercheBox.Location = new System.Drawing.Point(3, 23);
            this.SubjectSercheBox.Name = "SubjectSercheBox";
            this.SubjectSercheBox.Size = new System.Drawing.Size(355, 27);
            this.SubjectSercheBox.TabIndex = 3;
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.Location = new System.Drawing.Point(0, 96);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.RowHeadersWidth = 51;
            this.SubjectDataGridView.RowTemplate.Height = 24;
            this.SubjectDataGridView.Size = new System.Drawing.Size(792, 357);
            this.SubjectDataGridView.TabIndex = 6;
            // 
            // UCSubjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.SubjectDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "UCSubjectManagement";
            this.Size = new System.Drawing.Size(792, 453);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox SubjectListBoxSelect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox SubjectSercheBox;
        private System.Windows.Forms.DataGridView SubjectDataGridView;
    }
}
