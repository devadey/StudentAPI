namespace StudentAPI.Models.Course
{
    public class GetCoursesDto
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string TaughtBy { get; set; }

    }
}