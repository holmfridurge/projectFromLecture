using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projectFromLecture.Models;
using projectFromLecture.Services;
using projectFromLecture.Services.Entities;

namespace projectFromLecture.API.Controllers
{
    [Route("api/courses")]
    public class CoursesController : Controller
    {
        public readonly ICoursesService _service;

        public CoursesController(ICoursesService service)
        {
            _service = service;
        }

        /// <summary>
        /// Returns a list of courses. Can be used to query by the semester, if no semester is specified the courses from current semester will be returned.
        /// GET - api/courses
        /// GET - api/courses?semester=20153
        /// </summary>
        [HttpGet]
        public List<CourseLiteDTO> GetCoursesOnSemester(string semester = null)
        {

            return _service.GetCoursesBySemester(semester);
        }
        
        /// <summary>
        /// Returns the information of a course with the given ID.
        /// GET - api/courses/1
        /// </summary>
        [HttpGet("{id}", Name = "GetCourse")]
        public IActionResult GetCourseById(int id)
        {
            if(_service.GetCourseById(id) == null) {
                return NotFound();
            }
            return new ObjectResult(_service.GetCourseById(id));
        }

        /// <summary>
        /// Deletes the course instance with the given id.
        /// DELETE - api/courses/1
        /// </summary>
        [HttpDelete("{id}", Name = "DeleteCourse")]
        public IActionResult DeleteCourse(int id)
        {
            if(_service.DeleteCourse(id) == null) {
                return NotFound();
            }
            _service.DeleteCourse(id);
            return new NoContentResult();
        }

        /// <summary>
        /// Updates the course with the given ID. Changes it to the information given in the body.
        /// PUT - api/courses/1
        /// </summary>
        [HttpPut("{id}", Name = "UpdateCourse")]
        public void UpdateCourse([FromBody]UpdateCourseViewModel model, int id)
        {
             _service.UpdateCourse(model, id);
        }

        /*[HttpGet("{id}/students", Name = "GetStudentsInCourse")]
        public List<StudentLiteDTO> GetStudentsInCourse(int id) {
            return _service.GetStudentsInCourse(id);
        }*/
    }
}