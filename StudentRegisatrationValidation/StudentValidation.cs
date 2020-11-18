using System;
using System.Collections.Generic;
using System.Linq;
using StudentRegistrationCodeFirstFromDB;
using System.Diagnostics;

namespace StudentRegisatrationValidation
{
    public static class StudentValidation
    {

        /// <summary>
        /// Make sure all student info exists and is not blank
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public static bool InfoIsInvalid(this Student student)
        {
            return (student.StudentFirstName == null || student.StudentFirstName.Trim().Length == 0 ||
                student.StudentLastName == null || student.StudentLastName.Trim().Length == 0);
        }

    }
}
