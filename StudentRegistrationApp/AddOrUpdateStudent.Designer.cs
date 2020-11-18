namespace StudentRegistrationApp
{
    partial class AddOrUpdateStudent
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
            this.listBoxStudent = new System.Windows.Forms.ListBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.buttonStudentAdd = new System.Windows.Forms.Button();
            this.buttonStudentUpdate = new System.Windows.Forms.Button();
            this.listBoxStudentDepartment = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxStudent
            // 
            this.listBoxStudent.FormattingEnabled = true;
            this.listBoxStudent.Location = new System.Drawing.Point(125, 25);
            this.listBoxStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.Size = new System.Drawing.Size(313, 225);
            this.listBoxStudent.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(133, 309);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(68, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(133, 350);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(68, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // buttonStudentAdd
            // 
            this.buttonStudentAdd.Location = new System.Drawing.Point(149, 478);
            this.buttonStudentAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStudentAdd.Name = "buttonStudentAdd";
            this.buttonStudentAdd.Size = new System.Drawing.Size(52, 26);
            this.buttonStudentAdd.TabIndex = 4;
            this.buttonStudentAdd.Text = "Add";
            this.buttonStudentAdd.UseVisualStyleBackColor = true;
            // 
            // buttonStudentUpdate
            // 
            this.buttonStudentUpdate.Location = new System.Drawing.Point(317, 478);
            this.buttonStudentUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStudentUpdate.Name = "buttonStudentUpdate";
            this.buttonStudentUpdate.Size = new System.Drawing.Size(60, 26);
            this.buttonStudentUpdate.TabIndex = 5;
            this.buttonStudentUpdate.Text = "Update";
            this.buttonStudentUpdate.UseVisualStyleBackColor = true;
            // 
            // listBoxStudentDepartment
            // 
            this.listBoxStudentDepartment.FormattingEnabled = true;
            this.listBoxStudentDepartment.Location = new System.Drawing.Point(133, 394);
            this.listBoxStudentDepartment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxStudentDepartment.Name = "listBoxStudentDepartment";
            this.listBoxStudentDepartment.Size = new System.Drawing.Size(81, 56);
            this.listBoxStudentDepartment.TabIndex = 6;
            // 
            // AddOrUpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 562);
            this.Controls.Add(this.listBoxStudentDepartment);
            this.Controls.Add(this.buttonStudentUpdate);
            this.Controls.Add(this.buttonStudentAdd);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.listBoxStudent);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddOrUpdateStudent";
            this.Text = "AddOrUpdateStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudent;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button buttonStudentAdd;
        private System.Windows.Forms.Button buttonStudentUpdate;
        private System.Windows.Forms.ListBox listBoxStudentDepartment;
    }
}