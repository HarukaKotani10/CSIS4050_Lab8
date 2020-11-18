using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using StudentRegistrationCodeFirstFromDB;
using System.Data.Entity;
using System.Diagnostics;
using SeedDatabaseExtensions;
using EFControllerUtilities;

namespace StudentRegistrationApp
{
    public partial class StudentRegistrationMainForm : Form
    {
        private StudentRegistrationEntities context;
        public StudentRegistrationMainForm()
        {
            InitializeComponent();

            this.Text = "Student Registration using AddUpdate Forms";

            context = new StudentRegistrationEntities();
            context.Database.Log = (s => Debug.Write(s));
            context.SeedDatabase();
            context.SaveChanges();

            this.Load += (s, e) => StudentRegistratioMainForm_Load();

            // set the event handlers for buttons

            AddOrUpdateStudent addOrUpdateStudentForm = new AddOrUpdateStudent();
            buttonStudent.Click += (s, e) => AddOrUpdateForm<Student>(dataGridViewStudent, addOrUpdateStudentForm);

            AddOrUpdateDepartment addOrUpdateDepartmentForm = new AddOrUpdateDepartment();
            buttonDepartment.Click += (s, e) => AddOrUpdateForm<Department>(dataGridViewDepartment, addOrUpdateDepartmentForm);

            AddOrUpdateCourse addOrUpdateCourseForm = new AddOrUpdateCourse();
            buttonCourse.Click += (s, e) => AddOrUpdateForm<Course>(dataGridViewCourse, addOrUpdateCourseForm);

            buttonRegister.Click += ButtonRegister_Click;
            buttonDrop.Click += ButtonDrop_Click;

        }

        /// <summary>
        /// Set up all of the datagridview controls
        /// </summary>
        private void StudentRegistratioMainForm_Load()
        {
            // common setup for datagridview controls

            InitializeDataGridView<Student>(dataGridViewStudent, "Students");
            InitializeDataGridView<Department>(dataGridViewDepartment, "Departments");
            InitializeDataGridView<Course>(dataGridViewCourse, "Courses");
            ItitializeDataGridViewRegistration(dataGridViewRegistration);

            //  set unnecessary columns to invisible
            this.dataGridViewStudent.Columns["Courses"].Visible = false;
            this.dataGridViewStudent.Columns["Department"].Visible = false;
            this.dataGridViewCourse.Columns["Students"].Visible = false;
            this.dataGridViewCourse.Columns["Department"].Visible = false;
            this.dataGridViewDepartment.Columns["Courses"].Visible = false;
            this.dataGridViewDepartment.Columns["Students"].Visible = false;

        }

        /// <summary>
        /// Set up and reload registrationGridView 
        /// </summary>
        private void ItitializeDataGridViewRegistration(DataGridView dataGrid)
        {
            dataGrid.Columns.Clear(); // any columns created by the designer, get rid of them
            dataGrid.ReadOnly = true;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewColumn[] columns = new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Department", Width = 100},
                new DataGridViewTextBoxColumn() { Name = "Course Number", Width = 100},
                new DataGridViewTextBoxColumn() { Name = "Course Name", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "StudentID", Width = 100},
                new DataGridViewTextBoxColumn() { Name = "LastName", Width = 100 },

            };

            dataGrid.Columns.AddRange(columns);

            var sortedStudent = from s in context.Students
                                join d in context.Departments
                                on s.DepartmentId equals d.DepartmentId
                                orderby d.DepartmentCode // sorte by departmentCode
                                select s;

            context.Courses.Include(d => d.Students).Load();

            // add rows to registration table
            foreach (Student student in sortedStudent)
                foreach (Course course in student.Courses)
                    foreach (Department d in context.Departments.Where(c => c.DepartmentId == course.DepartmentId))
                    {
                        dataGrid.Rows.Add(new string[] { d.DepartmentCode.ToString(), course.CourseNumber.ToString(), course.CourseName,
                        student.StudentId.ToString(), student.StudentLastName});
                    }

        }


        /// <summary>
        /// Register selected student and course 
        /// and add to the registration table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRegister_Click(object sender, EventArgs e)
        {

            // check if bothe student and course are selected
            if (dataGridViewStudent.SelectedRows.Count == 0 || dataGridViewCourse.SelectedRows.Count == 0)
            {
                MessageBox.Show("No students or Courses selected");
                return;
            }


            foreach (DataGridViewRow studentRow in dataGridViewStudent.SelectedRows)
                foreach (DataGridViewRow courseRow in dataGridViewCourse.SelectedRows)
                {
                    int studentId = (int)studentRow.Cells[0].Value; // get selected studentId
                    int courseId = (int)studentRow.Cells[0].Value; // get selected courseId

                    foreach (Student student in context.Students.Where(c => c.StudentId == studentId)) 
                        foreach (Course course in context.Courses.Where(b => b.CourseId == courseId))
                            foreach (Department d in context.Departments.Where(c => c.DepartmentId == course.DepartmentId))
                                dataGridViewRegistration.Rows.Add(new string[] { d.DepartmentCode, course.CourseNumber.ToString(),
                                course.CourseName, student.StudentId.ToString(), student.StudentLastName }); // add to the datagridview
                    
                }
            }


        /// <summary>
        /// Remove selected Row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDrop_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewRegistration.SelectedRows)
            {
                dataGridViewRegistration.Rows.RemoveAt(row.Index);
            }
        }

        /// <summary>
        /// Common generic method to initialize datagridview controls. Allows users to add and delete data,
        /// sets the datasource, autosizes the control to the columns.
        /// <para>
        /// A list of columns to hide is an optional parameter. No error checking is done on this.
        /// </para>
        /// <para>
        /// We could use a form to delete items, but easy to use gridview for this, so set up 
        /// UserDeleted event.
        /// </para>
        /// </summary>
        /// <typeparam name="T">Data type associated with the gridview</typeparam>
        /// <param name="gridView">DataGridView to be initialized</param>
        /// <param name="navProperties">Columns to be hidden in the DataGridView</param>
        private void InitializeDataGridView<T>(DataGridView gridView, params string[] navProperties) where T : class
        {
            // Allow users to add/delete rows, and fill out columns to the entire width of the control

            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // set the handler used to delete an item. Note use of generics.

            gridView.UserDeletedRow += GridView_UserDeletedRow<T>;

            // probably not needed, but just in case we have some issues

            gridView.DataError += (s, e) => GridView_DataError<T>(s as DataGridView, e);

            // create a binding list and set the DataSource

            gridView.DataSource = SetBindingList<T>();

        }

        /// <summary>
        /// Update the database after the user has deleted the row. The binding list will
        /// have updated the local context entities, so just remove dependencies and save
        /// changes.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_UserDeletedRow<T>(object sender, DataGridViewRowEventArgs e) where T : class
        {
            // gridview will null out the nav properties in dependent objects, so
            // if there is no customer or car for an order, it is safe to remove it
            // too bad gridview and bindinglist don't do this automatically

            foreach (Student student in context.Students)
            {
                foreach (Course course in context.Courses)
                {
                    if (student.Courses == null || course.Students == null)
                        context.Students.Remove(student);
                }

            }

            context.SaveChanges();
        }

        /// <summary>
        /// Catch any gridview data error, log to debug and cancel any event.
        /// Should not happen, as all of our gridviews are readonly. Might show up when items
        /// are deleted.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="e"></param>
        private void GridView_DataError<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + gridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }

        /// <summary>
        /// Generic method to load a table and set it to a BindingList for use
        /// by DataGridView.
        /// 
        /// Can be used to reload tables from db. This is done in the generic
        /// addupdate form processing.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private BindingList<T> SetBindingList<T>() where T : class
        {
            DbSet<T> dbSet = context.Set<T>();

            dbSet.Load();
            BindingList<T> list = dbSet.Local.ToBindingList<T>();
            return list;
        }

        /// <summary>
        /// Generic method to display a form and then update the relevant gridviews.
        /// </summary>
        /// <typeparam name="T">Data type associated with the gridview</typeparam>
        /// <param name="dataGridView">DataGridView to be updated with new data from DB</param>
        /// <param name="form"></param>
        private void AddOrUpdateForm<T>(DataGridView dataGridView, Form form) where T : class
        {
            var result = form.ShowDialog();

            // form has closed

            if (result == DialogResult.OK)
            {
                // reload the db and update the gridview

                // EF will not reload if there are no additions, so we need to force a reload
                // Use the form's Tag to get the key of the item updated, and then force the reload
                // of just that item.
                // If we use controller, the table is just reloaded. This is a bit more efficient,
                // but a pain.

                if (form.Tag != null)
                {
                    int id = (int)form.Tag;

                    T entity = context.Set<T>().Find(id);
                    context.Entry<T>(entity).Reload();
                }
                else dataGridView.DataSource = SetBindingList<T>();

                dataGridView.Refresh();

                // ALWAYS update the registrationGridView, hence use of AsNoTracking()

                ItitializeDataGridViewRegistration(dataGridViewRegistration);
            }

            // do not close, as the form object will be disposed, 
            // just hide the form (make it invisible). 
            // 
            // when the inputForm is opened again (ShowDialog()), the Load event will fire
            //  and the form will be reinitialized

            form.Hide();
        }

        /// <summary>
        /// Load the CustomerOrders view from the db. We need to force a database read,
        /// so the best way is to create a new context and get all the entities for
        /// the CustomerOrders view in the db.
        /// 
        /// </summary>
        public void LoadStudentRegisterView()
        {
            using (StudentRegistrationEntities registrationView = new StudentRegistrationEntities())
            {
                registrationView.Database.Log = (s => Debug.Write(s));

                // force a read from the db, and we don't need to track these entities

                dataGridViewRegistration.DataSource = registrationView.Students.AsNoTracking().ToList();
                dataGridViewRegistration.Refresh();
            }


        }

    }
}
