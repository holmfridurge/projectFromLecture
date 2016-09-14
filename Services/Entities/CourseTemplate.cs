namespace projectFromLecture.Services.Entities
{
    public class CourseTemplate
    {
        /// <summary>
        /// Database-generated ID of the course
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Stores the name of a course.
        /// Example: Vefþjónustur
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// String ID of the course - doesn't have to be unique
        /// Example: T-514-VEFT
        /// </summary>
        public string CourseID { get; set; }
    }
}