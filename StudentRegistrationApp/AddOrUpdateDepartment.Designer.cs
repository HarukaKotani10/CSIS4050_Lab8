namespace StudentRegistrationApp
{
    partial class AddOrUpdateDepartment
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
            this.listBoxAddOrUpdateDepartment = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDepartmentCode = new System.Windows.Forms.TextBox();
            this.textBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.buttonAddDepartment = new System.Windows.Forms.Button();
            this.buttonUpdateDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAddOrUpdateDepartment
            // 
            this.listBoxAddOrUpdateDepartment.FormattingEnabled = true;
            this.listBoxAddOrUpdateDepartment.Location = new System.Drawing.Point(77, 61);
            this.listBoxAddOrUpdateDepartment.Name = "listBoxAddOrUpdateDepartment";
            this.listBoxAddOrUpdateDepartment.Size = new System.Drawing.Size(153, 199);
            this.listBoxAddOrUpdateDepartment.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department Name";
            // 
            // textBoxDepartmentCode
            // 
            this.textBoxDepartmentCode.Location = new System.Drawing.Point(77, 329);
            this.textBoxDepartmentCode.Name = "textBoxDepartmentCode";
            this.textBoxDepartmentCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepartmentCode.TabIndex = 3;
            // 
            // textBoxDepartmentName
            // 
            this.textBoxDepartmentName.Location = new System.Drawing.Point(77, 403);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.Size = new System.Drawing.Size(201, 20);
            this.textBoxDepartmentName.TabIndex = 4;
            // 
            // buttonAddDepartment
            // 
            this.buttonAddDepartment.Location = new System.Drawing.Point(91, 477);
            this.buttonAddDepartment.Name = "buttonAddDepartment";
            this.buttonAddDepartment.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDepartment.TabIndex = 5;
            this.buttonAddDepartment.Text = "Add";
            this.buttonAddDepartment.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateDepartment
            // 
            this.buttonUpdateDepartment.Location = new System.Drawing.Point(213, 477);
            this.buttonUpdateDepartment.Name = "buttonUpdateDepartment";
            this.buttonUpdateDepartment.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateDepartment.TabIndex = 6;
            this.buttonUpdateDepartment.Text = "Update";
            this.buttonUpdateDepartment.UseVisualStyleBackColor = true;
            // 
            // AddOrUpdateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 537);
            this.Controls.Add(this.buttonUpdateDepartment);
            this.Controls.Add(this.buttonAddDepartment);
            this.Controls.Add(this.textBoxDepartmentName);
            this.Controls.Add(this.textBoxDepartmentCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAddOrUpdateDepartment);
            this.Name = "AddOrUpdateDepartment";
            this.Text = "AddOrUpdateDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAddOrUpdateDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDepartmentCode;
        private System.Windows.Forms.TextBox textBoxDepartmentName;
        private System.Windows.Forms.Button buttonAddDepartment;
        private System.Windows.Forms.Button buttonUpdateDepartment;
    }
}