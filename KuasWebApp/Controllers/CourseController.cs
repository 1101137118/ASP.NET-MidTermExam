using KuasCore.Models;
using KuasCore.Services;
using KuasCore.Services.Impl;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace KuasWebApp.Controllers
{
    public class CourseController : ApiController
    {

        public CourseService CourseService { get; set; }

        [HttpPost]
        public Course AddCourse(Course course)
        {
            CheckCourseIsNotNullThrowException(course);

            try
            {
                CourseService.AddCourse(course);
                return CourseService.GetCourseById(course.Id);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        private void CheckCourseIsNotNullThrowException(Course course)
        {
            throw new NotImplementedException();
        }

      
      

  

        [HttpGet]
        [ActionName("byName")]
        public Course GetCourseByName(string Name)
        {
            var course = CourseService.GetCourseById(Name);

            if (course == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return course;
        }

      

    }

}
