using System;

namespace projectFromLecture.Models
{
    /// <summary>
    /// Stores information about a course as an object.
    /// </summary>
    public class CourseLiteDTO
    {
        /// <summary>
        /// Database-generated ID of the course
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The name of the course.
        /// Example: "Web Services"
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The semester the course is taught.
        /// Example: 20163 -> fall 2016
        /// </summary>  
        public string Semester { get; set; }
    }
}
