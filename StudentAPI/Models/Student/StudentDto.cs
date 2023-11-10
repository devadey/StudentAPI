namespace StudentAPI.Models.Student
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string MatricNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime AdmittedDay { get; set; }

        public int CourseId { get; set; }
          
    }
}