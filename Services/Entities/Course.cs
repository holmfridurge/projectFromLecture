using System;

namespace projectFromLecture.Services.Entities
{
    public class Course
    {
        /// <summary>
        /// Database-generated ID of the course
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// String ID of the course - doesn't have to be unique
        /// Example: T-514-VEFT
        /// </summary>
        public string CourseID { get; set; }
        /// <summary>
        /// An optional parameter that allows the user to query by a given semester
        /// </summary>
        public string Semester { get; set; }
    }
}