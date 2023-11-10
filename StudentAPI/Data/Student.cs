using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string MatricNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime AdmittedDay { get; set; }

        [ForeignKey(nameof(CourseId))]
        public int CourseId { get; set; }
        public Course Courses { get; set; }
        
    }
}