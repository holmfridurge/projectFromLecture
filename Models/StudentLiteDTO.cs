using System;

namespace projectFromLecture.Models
{
    /// <summary>
    /// Stores information about a student as an object.
    /// </summary>
    public class StudentLiteDTO
    {
        /// <summary>
        /// Database-generated ID of the student
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The name of the student.
        /// Example: "Jón Jónsson"
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The social security number of the student
        /// Example: 1234567890
        /// </summary>  
        public string SSN { get; set; }
    }
}
