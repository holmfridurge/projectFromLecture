using System.Collections.Generic;
using projectFromLecture.Models;
using projectFromLecture.Services.Entities;

namespace projectFromLecture.Services
{
    public interface ICoursesService
    {
        // Get courses with given semester
        List<CourseLiteDTO> GetCoursesBySemester(string semester);

        // Get course with given id
        CourseLiteDTO GetCourseById(int id);

        Course DeleteCourse(int id);

        void UpdateCourse(UpdateCourseViewModel model, int id);

    }
}