namespace StudentRegistrationApp
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(38, 37);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowHeadersWidth = 62;
            this.dataGridViewStudent.RowTemplate.Height = 28;
            this.dataGridViewStudent.Size = new System.Drawing.Size(858, 214);
            this.dataGridViewStudent.TabIndex = 0;
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourse.Location = new System.Drawing.Point(38, 269);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.RowHeadersWidth = 62;
            this.dataGridViewCourse.RowTemplate.Height = 28;
            this.dataGridViewCourse.Size = new System.Drawing.Size(698, 270);
            this.dataGridViewCourse.TabIndex = 1;
            // 
            // dataGridViewRegistration
            // 
            this.dataGridViewRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistration.Location = new System.Drawing.Point(23, 840);
            this.dataGridViewRegistration.Name = "dataGridViewRegistration";
            this.dataGridViewRegistration.RowHeadersWidth = 62;
            this.dataGridViewRegistration.RowTemplate.Height = 28;
            this.dataGridViewRegistration.Size = new System.Drawing.Size(952, 193);
            this.dataGridViewRegistration.TabIndex = 2;
            // 
            // dataGridViewDepartment
            // 
            this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartment.Location = new System.Drawing.Point(1127, 37);
            this.dataGridViewDepartment.Name = "dataGridViewDepartment";
            this.dataGridViewDepartment.RowHeadersWidth = 62;
            this.dataGridViewDepartment.RowTemplate.Height = 28;
            this.dataGridViewDepartment.Size = new System.Drawing.Size(516, 230);
            this.dataGridViewDepartment.TabIndex = 3;
            // 
            // buttonStudent
            // 
            this.buttonStudent.Location = new System.Drawing.Point(922, 89);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(95, 124);
            this.buttonStudent.TabIndex = 4;
            this.buttonStudent.Text = "Add Or Update Student";
            this.buttonStudent.UseVisualStyleBackColor = true;
            // 
            // buttonCourse
            // 
            this.buttonCourse.Location = new System.Drawing.Point(874, 313);
            this.buttonCourse.Name = "buttonCourse";
            this.buttonCourse.Size = new System.Drawing.Size(112, 133);
            this.buttonCourse.TabIndex = 5;
            this.buttonCourse.Text = "Add Or Update Course";
            this.buttonCourse.UseVisualStyleBackColor = true;
            // 
            // buttonDrop
            // 
            this.buttonDrop.Location = new System.Drawing.Point(1374, 887);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(146, 57);
            this.buttonDrop.TabIndex = 6;
            this.buttonDrop.Text = "Drop";
            this.buttonDrop.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(1374, 783);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(146, 53);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // buttonDepartment
            // 
            this.buttonDepartment.Location = new System.Drawing.Point(1675, 87);
            this.buttonDepartment.Name = "buttonDepartment";
            this.buttonDepartment.Size = new System.Drawing.Size(133, 129);
            this.buttonDepartment.TabIndex = 8;
            this.buttonDepartment.Text = "Add Or Update Department";
            this.buttonDepartment.UseVisualStyleBackColor = true;
            // 
            // StudentRegistrationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1873, 1158);
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
    }
}

