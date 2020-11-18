﻿namespace StudentRegistrationApp
{
    partial class StudentRegistrationMainForm
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
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.dataGridViewRegistration = new System.Windows.Forms.DataGridView();
            this.dataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonCourse = new System.Windows.Forms.Button();
            this.buttonDrop = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonDepartment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(84, 52);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowHeadersWidth = 62;
            this.dataGridViewStudent.RowTemplate.Height = 28;
            this.dataGridViewStudent.Size = new System.Drawing.Size(742, 214);
            this.dataGridViewStudent.TabIndex = 0;
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourse.Location = new System.Drawing.Point(84, 320);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.RowHeadersWidth = 62;
            this.dataGridViewCourse.RowTemplate.Height = 28;
            this.dataGridViewCourse.Size = new System.Drawing.Size(698, 269);
            this.dataGridViewCourse.TabIndex = 1;
            // 
            // dataGridViewRegistration
            // 
            this.dataGridViewRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistration.Location = new System.Drawing.Point(84, 683);
            this.dataGridViewRegistration.Name = "dataGridViewRegistration";
            this.dataGridViewRegistration.RowHeadersWidth = 62;
            this.dataGridViewRegistration.RowTemplate.Height = 28;
            this.dataGridViewRegistration.Size = new System.Drawing.Size(952, 192);
            this.dataGridViewRegistration.TabIndex = 2;
            // 
            // dataGridViewDepartment
            // 
            this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartment.Location = new System.Drawing.Point(1078, 52);
            this.dataGridViewDepartment.Name = "dataGridViewDepartment";
            this.dataGridViewDepartment.RowHeadersWidth = 62;
            this.dataGridViewDepartment.RowTemplate.Height = 28;
            this.dataGridViewDepartment.Size = new System.Drawing.Size(516, 229);
            this.dataGridViewDepartment.TabIndex = 3;
            // 
            // buttonStudent
            // 
            this.buttonStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonStudent.Location = new System.Drawing.Point(904, 92);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(112, 125);
            this.buttonStudent.TabIndex = 4;
            this.buttonStudent.Text = "Add Or Update Student";
            this.buttonStudent.UseVisualStyleBackColor = true;
            // 
            // buttonCourse
            // 
            this.buttonCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonCourse.Location = new System.Drawing.Point(904, 366);
            this.buttonCourse.Name = "buttonCourse";
            this.buttonCourse.Size = new System.Drawing.Size(112, 132);
            this.buttonCourse.TabIndex = 5;
            this.buttonCourse.Text = "Add Or Update Course";
            this.buttonCourse.UseVisualStyleBackColor = true;
            // 
            // buttonDrop
            // 
            this.buttonDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonDrop.Location = new System.Drawing.Point(1155, 788);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(146, 57);
            this.buttonDrop.TabIndex = 6;
            this.buttonDrop.Text = "Drop";
            this.buttonDrop.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonRegister.Location = new System.Drawing.Point(1155, 683);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(146, 52);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // buttonDepartment
            // 
            this.buttonDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonDepartment.Location = new System.Drawing.Point(1628, 103);
            this.buttonDepartment.Name = "buttonDepartment";
            this.buttonDepartment.Size = new System.Drawing.Size(134, 129);
            this.buttonDepartment.TabIndex = 8;
            this.buttonDepartment.Text = "Add Or Update Department";
            this.buttonDepartment.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(80, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(84, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Courses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(84, 642);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Registeration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(1074, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Departments";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(1330, 699);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 142);
            this.label5.TabIndex = 14;
            this.label5.Text = "Register by selecteing entire row\r\nstudents and courses then \r\nhit Register butto" +
    "n.\r\n\r\nDrop by selecting entire row\r\nRegistration and then hit \r\nDrop button.";
            // 
            // StudentRegistrationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 925);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDepartment);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonDrop);
            this.Controls.Add(this.buttonCourse);
            this.Controls.Add(this.buttonStudent);
            this.Controls.Add(this.dataGridViewDepartment);
            this.Controls.Add(this.dataGridViewRegistration);
            this.Controls.Add(this.dataGridViewCourse);
            this.Controls.Add(this.dataGridViewStudent);
            this.Name = "StudentRegistrationMainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
        private System.Windows.Forms.DataGridView dataGridViewRegistration;
        private System.Windows.Forms.DataGridView dataGridViewDepartment;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Button buttonCourse;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonDepartment;
        public System.Windows.Forms.Button buttonDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

