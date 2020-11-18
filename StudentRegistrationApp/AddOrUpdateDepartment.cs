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
    public partial class AddOrUpdateDepartment : Form
    {
        private StudentRegistrationEntities context;

        public AddOrUpdateDepartment()
        {
            InitializeComponent();

            // register the event handlers
            this.Load += AddorUpdateDepartmentForm_Load;
            buttonAddDepartment.Click += ButtonAddDepartment_Click;
            buttonUpdateDepartment.Click += ButtonUpdateDepartment_Click;

            // register event handler for when a car is selected
            listBoxAddOrUpdateDepartment.SelectedIndexChanged += (s, e) => GetDepartment();

            // always dispose of the context when the form is closed.
            this.FormClosed += (s, e) => context.Dispose();
        }

        /// <summary>
		/// Get a selected department from the listbox
		/// </summary>
        private void GetDepartment()
        {
            if (!(listBoxAddOrUpdateDepartment.SelectedItem is Department department))
                return;
            textBoxDepartmentCode.Text = department.DepartmentCode;
            textBoxDepartmentName.Text = department.DepartmentName;
        }

        /// <summary>
        /// Update the db with the new department data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateDepartment_Click(object sender, EventArgs e)
        {
            // the selection contains the entity to update, so make
            // sure it is done.

            if (!(listBoxAddOrUpdateDepartment.SelectedItem is Department department))
            {
                MessageBox.Show("Department to be updated must be selected");
                return;
            }

            // update the entity

            department.DepartmentCode = textBoxDepartmentCode.Text;
            department.DepartmentName = textBoxDepartmentName.Text;

            // now update the db

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot add Department to database" + ex.InnerException.InnerException.Message);
                return;
            }

            this.Tag = department.DepartmentId;  // so parent form can lookup id and reload

            this.DialogResult = DialogResult.OK;
            context.Dispose();
            Close(); // this will not dispose the form on hide!
        }

        /// <summary>
        /// Add a department to the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddDepartment_Click(object sender, EventArgs e)
        {
            // get the Department data from the textboxes

            Department department = new Department()
            {
                DepartmentCode = textBoxDepartmentCode.Text,
                DepartmentName = textBoxDepartmentName.Text,
            };

           
            // now update the db

            try
            {
                context.Departments.Add(department);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot add Department to database" + ex.InnerException.InnerException.Message);
                return;
            }

            // if everyting is ok, get rid of the context, and close the form.

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
        private void AddorUpdateDepartmentForm_Load(object sender, EventArgs e)
        {
            this.Tag = null;
            // Get the context and load the inventory table

            context = new StudentRegistrationEntities();
            context.Database.Log = s => Debug.Write(s);
            context.SaveChanges();
            context.Departments.Load();

            // bind the listbox of Department to the Department table.

            listBoxAddOrUpdateDepartment.DataSource = context.Departments.Local.ToBindingList();

            // no department is selected to start

            listBoxAddOrUpdateDepartment.SelectedIndex = -1;

            // set all textboxes to blank

            textBoxDepartmentCode.ResetText();
            textBoxDepartmentName.ResetText();
        }
    }
}
