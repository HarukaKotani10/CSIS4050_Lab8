using EFControllerUtilities;
using StudentRegistrationCodeFirstFromDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApp
{
    public partial class AddOrUpdateCourse : Form
    {
        private StudentRegistrationEntities context;

        public AddOrUpdateCourse()
        {
            InitializeComponent();

            // register the event handlers
            this.Load += AddOrUpdateCourseForm_Load;
            buttonAddCourse.Click += ButtonAddCourse_Click;
            buttonUpdateCourse.Click += ButtonUpdateCourse_Click;

            // register event handler for when a Course is selected
            listBoxCourses.SelectedIndexChanged += (s, e) => GetCourses();

            // always dispose of the context when the form is closed.
            this.FormClosed += (s, e) => context.Dispose();
        }

        private void GetCourses()
        {
            if (!(listBoxCourses.SelectedItem is Course course))
                return;
            textBoxCourseName.Text = course.CourseName;
            textBoxCourseNumber.Text = course.CourseNumber.ToString();

           /* foreach (Department department in context.Departments)
                listBoxDepartment.Items.Add(department.DepartmentId);*/
        }

        private void ButtonUpdateCourse_Click(object sender, EventArgs e)
        {
            if (!(listBoxCourses.SelectedItem is Course course))
            {
                MessageBox.Show("Courses to be updated must be selected");
                return;
            }

            // update the entity
            int deptId = listBoxDepartment.SelectedIndex + 1;

            course.CourseName = textBoxCourseName.Text;
            course.CourseNumber = Convert.ToInt32(textBoxCourseNumber.Text);
            course.DepartmentId = deptId;

            try
            {
                context.SaveChanges();
                context.Departments.Load();
                context.Courses.Load();

                // bind the listbox of Department to the Department table.

                listBoxCourses.DataSource = context.Courses.Local.ToBindingList();
                listBoxDepartment.DataSource = context.Departments.Local.ToBindingList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot add Department to database" + ex.InnerException.InnerException.Message);
                return;
            }

            this.Tag = course.CourseId;  // so parent form can lookup id and reload


            this.DialogResult = DialogResult.OK;
            context.Dispose();

            Close(); // this will not dispose the form on hide!
        }

        private void ButtonAddCourse_Click(object sender, EventArgs e)
        {
          //  string selectedDept = listBoxDepartment.SelectedItem.ToString();

         /*   var d = from i in context.Departments
                    where i.DepartmentName == selectedDept
                    select i.DepartmentId;*/

            int deptId = listBoxDepartment.SelectedIndex+1;

            
            Course course = new Course()
            {   
                CourseName = textBoxCourseName.Text,
                CourseNumber = Convert.ToInt32(textBoxCourseNumber.Text),
                DepartmentId = deptId
            };

            if (Controller<StudentRegistrationEntities, Course>.AddEntity(course) == null)
            {
                MessageBox.Show("Cannot add Course to database");
                return;
            }

            this.DialogResult = DialogResult.OK;
            context.Dispose();
            Close(); // this will not dispose the form on hide!
        }

        private void AddOrUpdateCourseForm_Load(object sender, EventArgs e)
        {
            this.Tag = null;
            // Get the context and load the inventory table

            context = new StudentRegistrationEntities();
            context.Database.Log = s => Debug.Write(s);
            context.SaveChanges();
            context.Departments.Load();
            context.Courses.Load();

            // bind the listbox of Department to the Department table.

            listBoxCourses.DataSource = context.Courses.Local.ToBindingList();
            listBoxDepartment.DataSource = context.Departments.Local.ToBindingList();

            // no department is selected to start

            listBoxCourses.SelectedIndex = -1;
            listBoxDepartment.SelectedIndex = -1;

            // set all textboxes to blank

            textBoxCourseName.ResetText();
            textBoxCourseNumber.ResetText();
        }
    }
}
