using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentRegistrationCodeFirstFromDB;
using EFControllerUtilities;
using StudentRegisatrationValidation;

namespace StudentRegistrationApp
{
    public partial class AddOrUpdateStudent : Form
    {
		private StudentRegistrationEntities context;
        public AddOrUpdateStudent()
        {
            InitializeComponent();
			context = new StudentRegistrationEntities();

            // register the event handlers
            this.Load += AddOrUpdateStudentForm_Load;
            buttonStudentAdd.Click += ButtonAdd_Click;
            buttonStudentUpdate.Click += ButtonUpdate_Click;


            // register event handler for when a car is selected

            listBoxStudent.SelectedIndexChanged += (s, e) => GetStudent();

        }

		/// <summary>
		/// The form is initially created, but loaded each time it is shown.
		/// Reload data each time the form loaded.
		/// 
		/// This is the handler for the Load event.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddOrUpdateStudentForm_Load(object sender, EventArgs e)
		{

			// bind the listbox of cars to the inventory table.

			listBoxStudent.DataSource = Controller<StudentRegistrationEntities, Student>.SetBindingList();

			// no student is selected to start

			listBoxStudent.SelectedIndex = -1;

			// set all textboxes to blank

			textBoxFirstName.ResetText();
			textBoxLastName.ResetText();
		
		}

		/// <summary>
		/// Get a selected car from the listbox and fill in the textboxes with the
		/// info.
		/// </summary>
		private void GetStudent()
		{
			if (!(listBoxStudent.SelectedItem is Student student))
				return;
			textBoxFirstName.Text = student.StudentFirstName;
			textBoxLastName.Text = student.StudentLastName;

			foreach (Department department in context.Departments)
				listBoxStudentDepartment.Items.Add(department.DepartmentCode);

		}



		/// <summary>
		/// Update the db with the new car data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonUpdate_Click(object sender, EventArgs e)
		{
			// make sure a car is selected
			// could use SelectedIndex < 0 here as well

			if (!(listBoxStudent.SelectedItem is Student student))
			{
				MessageBox.Show("Student to be updated must be selected");
				return;
			}
			//string originalFirstName = student.StudentFirstName;

			student.StudentFirstName = textBoxFirstName.Text;
			student.StudentLastName = textBoxLastName.Text;
			student.DepartmentId = 1;
/*
			string selectedDept = listBoxStudentDepartment.SelectedItem.ToString();

			var d = from i in context.Departments
					where i.DepartmentCode == selectedDept
					select i.DepartmentId;

			int deptId = 0;

			foreach (var i in d)
				deptId = i;

			student.DepartmentId = deptId;*/

			if (student.InfoIsInvalid())
            {
                MessageBox.Show("Student information is missing.");
                return;
            }

/*            if (originalFirstName != student.StudentFirstName && student.CarColorExists())
            {
                MessageBox.Show("Car color already exists: " + student.StudentFirstName);
                return;
            }*/

            if (Controller<StudentRegistrationEntities, Student>.UpdateEntity(student) == false)
			{
				MessageBox.Show("Cannot update car to database");
				return;
			}

			this.DialogResult = DialogResult.OK;

			Close(); // this will not dispose the form on hide!
		}

		/// <summary>
		/// Add a car to the db
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonAdd_Click(object sender, EventArgs e)
		{

			string selectedDept = listBoxStudentDepartment.SelectedItem.ToString();

			var d = from i in context.Departments
					where i.DepartmentCode == selectedDept
					select i.DepartmentId;

			int deptId = 0;

			foreach (var i in d)
				deptId = i;

			// get the car data from the textboxes

			
				Student student = new Student()
				{
					StudentFirstName = textBoxFirstName.Text,
					StudentLastName = textBoxLastName.Text,
					DepartmentId = deptId
				};

            // validity checks

            if (student.InfoIsInvalid())
            {
                MessageBox.Show("Student information is missing.");
                return;
            }

/*            if (student.CarColorExists())
            {
                MessageBox.Show("Car color already exists: " + student.StudentFirstName);
                return;
            }*/

            // now update the db

            if (Controller<StudentRegistrationEntities, Student>.AddEntity(student) == null)
			{
				MessageBox.Show("Cannot add car to database");
				return;
			}


			// if everyting is ok, close the form.

			this.DialogResult = DialogResult.OK;

			Close(); // this will not dispose the form on hide!
		}

	}
}

