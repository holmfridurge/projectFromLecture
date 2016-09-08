using System.Linq;
using System.Collections.Generic;
using projectFromLecture.Models;

namespace projectFromLecture.Services
{
    public class CoursesService : ICoursesService
    {
        private readonly AppDataContext _db;
        public CoursesService(AppDataContext db)
        {
            _db = db;
        }

        
        public List<CourseLiteDTO> GetCoursesBySemester(string semester)
        {
            /*return (from x in _db.Courses
                    where x.Semester = semester
                    select new CourseLiteDTO{
                        ID = x.ID,
                        Name = x.Name,
                        Semester = x.Semester
                    }).ToList();*/
            
            return (from x in _db.Courses
                    where x.Semester = semester
                    select new CourseLiteDTO{
                        ID = x.ID,
                        Name = x.Name,
                        Semester = x.Semester
                    }).All();
        }


        public List<CourseLiteDTO> GetCourses()
        {
            return (from x in _db.Courses
                select new CourseLiteDTO
                {
                    ID = x.ID,
                    Name = x.Name,
                    Semester = x.Semester
                }).ToList();
        }
    }
}