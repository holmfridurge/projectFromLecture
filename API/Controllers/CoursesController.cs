using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projectFromLecture.Models;
using projectFromLecture.Services;

namespace projectFromLecture.API.Controllers
{
    [Route("api/courses")]
    public class CoursesController : Controller
    {
        public readonly ICoursesService _service;
        public readonly ICourseTemplateService _ctService;

        public CoursesController(ICoursesService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<CourseLiteDTO> GetCourses()
        {
            return _service.GetCourses();
        }

        [HttpGet("/name", Name="GetName")]
        public List<CourseTemplateLiteDTO> GetName()
        {
            return _ctService.GetCourseNames();
        }

        [HttpGet("{semester}", Name="GetCourseBySemester")]
        public List<CourseLiteDTO> GetCoursesOnSemester(string semester = null)
        {
            return _service.GetCoursesBySemester(semester);
        }
    }
}