using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Models
{
    class Course
    {
        public string CourseID { get; set; }

        public string CourseName { get; set; }

        public Int32 CourseDescription { get; set; }

        public override string ToString()
        {
            return "Employee: Id = " + CourseID + ", Name = " + CourseName + ".";
        }
    }
}
