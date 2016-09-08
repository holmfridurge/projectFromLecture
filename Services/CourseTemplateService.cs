using System.Linq;
using System.Collections.Generic;
using projectFromLecture.Models;

namespace projectFromLecture.Services
{
    public class CourseTemplateService : ICourseTemplateService
    {
        private readonly AppDataContext _db;
        public CourseTemplateService(AppDataContext db)
        {
            _db = db;
        }

        
        public List<CourseTemplateLiteDTO> GetCourseNames()
        {
            return (from x in _db.CourseTemplate
                select new CourseTemplateLiteDTO
                {
                    ID = x.ID,
                    CourseID = x.CourseID,
                    Name = x.Name
                }).ToList();
        }
    }
}