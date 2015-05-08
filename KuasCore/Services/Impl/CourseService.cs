using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using System.Collections.Generic;
namespace KuasCore.Services.Impl
{
    class CourseService
    {
        public IEmployeeDao EmployeeDao { get; set; }

        public void AddCourse(Employee employee)
        {
            EmployeeDao.AddEmployee(employee);
        }

        public Employee GetCourseByName(string Name)
        {
            return EmployeeDao.GetEmployeeById(Name);
        }
    }
}
