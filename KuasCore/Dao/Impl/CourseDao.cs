
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;


namespace KuasCore.Dao.Impl
{
    class CourseDao : GenericDao<Course>
    {
        public void AddEmployee(Course course)
        {
            string command = @"INSERT INTO Course (CourseID, CourseName, CourseDescription) VALUES (@CourseID, @CourseName, @CourseDescription);";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("CourseID", DbType.String).Value = course.CourseID;
            parameters.Add("CourseName", DbType.String).Value = course.CourseName;
            parameters.Add("CourseDescription", DbType.Int32).Value = course.CourseDescription;

            ExecuteNonQuery(command, parameters);
        }

     

    }
}
