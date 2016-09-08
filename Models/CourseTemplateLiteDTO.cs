using System;

namespace projectFromLecture.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CourseTemplateLiteDTO
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
        /// Database-generated ID of the course
        /// </summary>
        public int CourseID { get; set; }
    }
}
