using System;
using System.Linq;
using System.Collections.Generic;
using projectFromLecture.Models;
using projectFromLecture.Services.Entities;

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


            if (semester == null)
            {
                semester = "20163";
            }


            var result = (from c in _db.Courses
                join ct in _db.CourseTemplates on c.CourseID equals ct.CourseID
                where c.Semester == semester
                orderby ct.Name
                select new CourseLiteDTO
                {
                    ID = c.ID,
                    Name = ct.Name,
                    Semester = c.Semester
                }).ToList();

            return result;
        }


        public CourseLiteDTO GetCourseById(int id)
        {
            return (from c in _db.Courses
                join ct in _db.CourseTemplates on c.CourseID equals ct.CourseID
                where c.ID == id
                orderby ct.Name
                select new CourseLiteDTO
                {
                    ID = c.ID,
                    Name = ct.Name,
                    Semester = c.Semester
                }).SingleOrDefault();

        }

/*        public void AddCourse(AddCourseViewModel model)
        {
            // Validation!
            // 1. Validate that the TemplateID is valid and that such CourseTemplate exists!
            // 2. Validate that the semester is valid
            var course = new Course
            {
                CourseID = model.CourseID,
                Semester = model.Semester,
                DateCreated = DateTime.Now
            };

            _db.Courses.Add(course);
            _db.SaveChanges();
        }*/


        public Course DeleteCourse(int id)
        {
            var deleteCourse = (from c in _db.Courses
                where c.ID == id
                select new Course
                {
                    ID = c.ID,
                    CourseID = c.CourseID,
                    Semester = c.Semester
                }).FirstOrDefault();

            if(deleteCourse != null) {
                _db.Remove(deleteCourse);
                _db.SaveChanges();
                return deleteCourse;
            } else {
                return null;
            }

        }

        public void UpdateCourse(UpdateCourseViewModel model, int id)
        {
            var course = (from c in _db.Courses
                where c.ID == id
                select new Course
                {
                    CourseID = model.CourseID,
                    Semester = model.Semester
                }).SingleOrDefault();

            course.CourseID = "T-111-PROG";
            course.Semester = "20163";



            _db.SaveChanges();
        }
    }
}