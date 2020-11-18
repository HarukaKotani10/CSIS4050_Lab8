using EFControllerUtilities;
using StudentRegistrationCodeFirstFromDB;
using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Windows.Forms;
using StudentRegisatrationValidation;
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

        /// <summary>
        /// Get a selected course from the listbox
        /// </summary>
        private void GetCourses()
        {
            if (!(listBoxCourses.SelectedItem is Course course))
                return;
            textBoxCourseName.Text = course.CourseName;
            textBoxCourseNumber.Text = course.CourseNumber.ToString();
        }

        /// <summary>
        /// Update the db with the new course data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateCourse_Click(object sender, EventArgs e)
        {
            if (!(listBoxCourses.SelectedItem is Course course))
            {
                MessageBox.Show("Courses to be updated must be selected");
                return;
            }

            // update the entity
            int deptId = listBoxDepartment.SelectedIndex + 1;

            string originalCourse = course.CourseId.ToString();

            course.CourseName = textBoxCourseName.Text;
            course.CourseNumber = Convert.ToInt32(textBoxCourseNumber.Text);
            course.DepartmentId = deptId;

            if (course.InfoIsInvalid())
            {
                MessageBox.Show("course information is missing.");
                return;
            }

            if (originalCourse != course.CourseId.ToString() && course.CourseExists())
            {
                MessageBox.Show("course already exists: " + course.CourseId +1 + "" + course.CourseNumber);
                return;
            }

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

        /// <summary>
        /// Add a course to the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddCourse_Click(object sender, EventArgs e)
        {
             
            int departmentId = listBoxDepartment.SelectedIndex +1; // get selected deparmtnetId
            
            Course course = new Course()
            {   
                CourseName = textBoxCourseName.Text,
                CourseNumber = Convert.ToInt32(textBoxCourseNumber.Text),
                DepartmentId = departmentId
            };

            if (course.InfoIsInvalid())
            {
                MessageBox.Show("course information is missing.");
                return;
            }

            if (course.CourseExists())
            {
                MessageBox.Show("course already exists: " + course.CourseId + 1 + "" + course.CourseNumber);
                return;
            }

            if (Controller<StudentRegistrationEntities, Course>.AddEntity(course) == null)
            {
                MessageBox.Show("Cannot add Course to database");
                return;
            }

            this.DialogResult = DialogResult.OK;
            context.Dispose();
            Close(); // this will not dispose the form on hide!
        }

        /// <summary>
        /// The form is initially created, but loaded each time it is shown.
        /// So make sure the context is created in the Load event.
        /// 
        /// This is the handler for the Load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
