using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using System.Collections.Generic;
namespace KuasCore.Services.Impl
{
    class CourseService
    {
        public CourseDao EmployeeDao { get; set; }

        public void AddCourse(Course course)
        {
            EmployeeDao.AddCourse(course);
        }

        public Course GetCourseByName(string Name)
        {
            return CourseDao.GetCourseByName(Name);
        }
    }
}
