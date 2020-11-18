using System;
using System.Collections.Generic;
using System.Linq;
using StudentRegistrationCodeFirstFromDB;
using System.Diagnostics;

namespace StudentRegisatrationValidation
{
    public static class CourseValidation
    {
        /// <summary>
        /// Make sure all couraw info exists and is not blank
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public static bool InfoIsInvalid(this Course course)
        {
            return (course.CourseName == null);
        }

        /// <summary>
        /// See if a course's id is already taken by another item in course
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public static bool CourseExists(this Course course)
        {
            using (StudentRegistrationEntities context = new StudentRegistrationEntities())
            {
                context.Database.Log = (s => Debug.Write(s));
                return context.Courses.Any(c => c.CourseNumber == course.CourseNumber) && context.Courses.Any(c => c.DepartmentId == course.DepartmentId);
            }
        }
    }
}
