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
            this.listBoxStudent.ItemHeight = 20;
            this.listBoxStudent.Location = new System.Drawing.Point(188, 39);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.Size = new System.Drawing.Size(468, 344);
            this.listBoxStudent.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(199, 475);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 26);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(199, 539);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 26);
            this.textBoxLastName.TabIndex = 3;
            // 
            // buttonStudentAdd
            // 
            this.buttonStudentAdd.Location = new System.Drawing.Point(224, 736);
            this.buttonStudentAdd.Name = "buttonStudentAdd";
            this.buttonStudentAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonStudentAdd.TabIndex = 4;
            this.buttonStudentAdd.Text = "Add";
            this.buttonStudentAdd.UseVisualStyleBackColor = true;
            // 
            // buttonStudentUpdate
            // 
            this.buttonStudentUpdate.Location = new System.Drawing.Point(476, 736);
            this.buttonStudentUpdate.Name = "buttonStudentUpdate";
            this.buttonStudentUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonStudentUpdate.TabIndex = 5;
            this.buttonStudentUpdate.Text = "Update";
            this.buttonStudentUpdate.UseVisualStyleBackColor = true;
            // 
            // listBoxStudentDepartment
            // 
            this.listBoxStudentDepartment.FormattingEnabled = true;
            this.listBoxStudentDepartment.ItemHeight = 20;
            this.listBoxStudentDepartment.Location = new System.Drawing.Point(199, 606);
            this.listBoxStudentDepartment.Name = "listBoxStudentDepartment";
            this.listBoxStudentDepartment.Size = new System.Drawing.Size(120, 84);
            this.listBoxStudentDepartment.TabIndex = 6;
            // 
            // AddOrUpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 864);
            this.Controls.Add(this.listBoxStudentDepartment);
            this.Controls.Add(this.buttonStudentUpdate);
            this.Controls.Add(this.buttonStudentAdd);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.listBoxStudent);
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