using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Course>().HasData(          
                new Course { Id=1, CourseName = "Mathematics", CourseCode = "MATH101", TaughtBy = "Professor Smith" },
                new Course { Id=2, CourseName = "History", CourseCode = "HIST101", TaughtBy = "Professor Johnson" },
                new Course { Id=3, CourseName = "Biology", CourseCode = "BIO101", TaughtBy = "Professor Wilson" },
                new Course { Id=4, CourseName = "Chemistry", CourseCode = "CHEM101", TaughtBy = "Professor Brown" },
                new Course { Id=5, CourseName = "Computer Science", CourseCode = "CSCI101", TaughtBy = "Professor Davis" },
                new Course { Id=6, CourseName = "English Literature", CourseCode = "ENGL101", TaughtBy = "Professor White" },
                new Course { Id=7, CourseName = "Physics", CourseCode = "PHYS101", TaughtBy = "Professor Anderson" },
                new Course { Id=8, CourseName = "Psychology", CourseCode = "PSYCH101", TaughtBy = "Professor Martinez" },
                new Course { Id=9, CourseName = "Economics", CourseCode = "ECON101", TaughtBy = "Professor Robinson" },
                new Course { Id=10, CourseName = "Art History", CourseCode = "ARTH101", TaughtBy = "Professor Garcia" }
            );

            modelBuilder.Entity<Student>().HasData(
        new Student
        {
            Id=1, 
            MatricNumber = "M001",
            FirstName = "John",
            LastName = "Doe",
            Department = "Computer Science",
            DateOfBirth = new DateTime(1995, 5, 15),
            AdmittedDay = new DateTime(2019, 9, 1),
            CourseId = 2
        },
        new Student
        {
            Id=2, 
            MatricNumber = "M002",
            FirstName = "Alice",
            LastName = "Smith",
            Department = "Biology",
            DateOfBirth = new DateTime(1998, 3, 20),
            AdmittedDay = new DateTime(2020, 8, 15),
            CourseId= 4
        },
        new Student
        {
            Id=3,
            MatricNumber = "M003",
            FirstName = "Bob",
            LastName = "Johnson",
            Department = "Mathematics",
            DateOfBirth = new DateTime(1997, 8, 10),
            AdmittedDay = new DateTime(2018, 7, 5),
            CourseId=2
        },
        new Student
        {
            Id=4,
            MatricNumber = "M004",
            FirstName = "Sarah",
            LastName = "Williams",
            Department = "Physics",
            DateOfBirth = new DateTime(1996, 12, 5),
            AdmittedDay = new DateTime(2017, 11, 3),
            CourseId=1
        },
        new Student
        {
            Id=5,
            MatricNumber = "M005",
            FirstName = "Mike",
            LastName = "Brown",
            Department = "Chemistry",
            DateOfBirth = new DateTime(1999, 2, 25),
            AdmittedDay = new DateTime(2022, 3, 10),
            CourseId=3
        },
        new Student
        {
            Id=6,
            MatricNumber = "M006",
            FirstName = "Linda",
            LastName = "Davis",
            Department = "History",
            DateOfBirth = new DateTime(1994, 7, 8),
            AdmittedDay = new DateTime(2015, 9, 15),
            CourseId=5
        },
        new Student
        {
            Id=7,
            MatricNumber = "M007",
            FirstName = "Mark",
            LastName = "Martinez",
            Department = "Economics",
            DateOfBirth = new DateTime(1997, 6, 30),
            AdmittedDay = new DateTime(2018, 4, 22),
            CourseId=6
        },
        new Student
        {
            Id=8,
            MatricNumber = "M008",
            FirstName = "Emily",
            LastName = "Taylor",
            Department = "Psychology",
            DateOfBirth = new DateTime(1993, 4, 12),
            AdmittedDay = new DateTime(2014, 10, 5),
            CourseId=7
        },
        new Student
        {
            Id=9,
            MatricNumber = "M009",
            FirstName = "James",
            LastName = "Garcia",
            Department = "English",
            DateOfBirth = new DateTime(1998, 9, 18),
            AdmittedDay = new DateTime(2019, 2, 12),
            CourseId=8
        },
        new Student
        {
            Id=10,
            MatricNumber = "M010",
            FirstName = "Olivia",
            LastName = "Hernandez",
            Department = "Sociology",
            DateOfBirth = new DateTime(1996, 1, 7),
            AdmittedDay = new DateTime(2017, 6, 30),
            CourseId=9
        });

        }
    }
}