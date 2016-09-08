using System.Collections.Generic;
using projectFromLecture.Models;

namespace projectFromLecture.Services
{
    public interface ICourseTemplateService
    {
        // Get a list of courses
        List<CourseTemplateLiteDTO> GetCourseNames();

    }
}