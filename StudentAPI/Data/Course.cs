using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI.Data
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string TaughtBy { get; set; }
        
        public virtual List<Student> Students { get; set; }

    }
}