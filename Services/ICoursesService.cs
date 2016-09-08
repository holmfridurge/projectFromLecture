using System.Collections.Generic;
using projectFromLecture.Models;

namespace projectFromLecture.Services
{
    public interface ICoursesService
    {
        // Get a list of courses
        List<CourseLiteDTO> GetCourses();

        // Get courses with given semester
        List<CourseLiteDTO> GetCoursesBySemester(string semester);
    }
}