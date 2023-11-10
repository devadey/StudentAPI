using StudentAPI.Models.Student;

namespace StudentAPI.Models.Course
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string TaughtBy { get; set; }
        
        public virtual List<StudentDto> Students { get; set; }
    }
}