namespace StudentRegistrationApp
{
    partial class AddOrUpdateCourse
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
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.listBoxDepartment = new System.Windows.Forms.ListBox();
            this.textBoxCourseNumber = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.buttonUpdateCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.Location = new System.Drawing.Point(145, 31);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(180, 160);
            this.listBoxCourses.TabIndex = 0;
            // 
            // listBoxDepartment
            // 
            this.listBoxDepartment.FormattingEnabled = true;
            this.listBoxDepartment.Location = new System.Drawing.Point(145, 240);
            this.listBoxDepartment.Name = "listBoxDepartment";
            this.listBoxDepartment.Size = new System.Drawing.Size(147, 108);
            this.listBoxDepartment.TabIndex = 1;
            // 
            // textBoxCourseNumber
            // 
            this.textBoxCourseNumber.Location = new System.Drawing.Point(145, 390);
            this.textBoxCourseNumber.Name = "textBoxCourseNumber";
            this.textBoxCourseNumber.Size = new System.Drawing.Size(131, 20);
            this.textBoxCourseNumber.TabIndex = 2;
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(145, 445);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(131, 20);
            this.textBoxCourseName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Course Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Course Name";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(98, 492);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCourse.TabIndex = 8;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateCourse
            // 
            this.buttonUpdateCourse.Location = new System.Drawing.Point(238, 492);
            this.buttonUpdateCourse.Name = "buttonUpdateCourse";
            this.buttonUpdateCourse.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateCourse.TabIndex = 9;
            this.buttonUpdateCourse.Text = "Update";
            this.buttonUpdateCourse.UseVisualStyleBackColor = true;
            // 
            // AddOrUpdateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 547);
            this.Controls.Add(this.buttonUpdateCourse);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.textBoxCourseNumber);
            this.Controls.Add(this.listBoxDepartment);
            this.Controls.Add(this.listBoxCourses);
            this.Name = "AddOrUpdateCourse";
            this.Text = "AddOrUpdateCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.ListBox listBoxDepartment;
        private System.Windows.Forms.TextBox textBoxCourseNumber;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Button buttonUpdateCourse;
    }
}