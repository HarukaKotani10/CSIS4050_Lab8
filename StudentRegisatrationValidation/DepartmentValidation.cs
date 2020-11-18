using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRegistrationCodeFirstFromDB;
using System.Diagnostics;

namespace StudentRegisatrationValidation
{
    public static class DepartmentValidation
    {

        /// <summary>
        /// Make sure all department info exists and is not blank
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public static bool InfoIsInvalid(this Department department)
        {
            return (department.DepartmentCode == null || department.DepartmentName.Trim().Length == 0 ||
                department.DepartmentCode == null || department.DepartmentName.Trim().Length == 0);
        }

        /// <summary>
        /// See if a department's id is already taken by another item in department
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static bool DepartmentExists(this Department department)
        {
            using (StudentRegistrationEntities context = new StudentRegistrationEntities())
            {
                context.Database.Log = (s => Debug.Write(s));
                return context.Departments.Any(c => c.DepartmentId == department.DepartmentId) || context.Departments.Any(c => c.DepartmentCode == department.DepartmentCode);
            }
        }
    }
}
