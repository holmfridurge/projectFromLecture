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
        public string CourseID { get; set; }

        /// <summary>
        /// Example: 20163 -> fall 2016
        /// </summary>  
        public string Name { get; set; }
    }
}
