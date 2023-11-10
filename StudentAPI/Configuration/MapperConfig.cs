using AutoMapper;
using StudentAPI.Data;
using StudentAPI.Models.Course;
using StudentAPI.Models.Student;

namespace StudentAPI.Configuration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Student, GetStudentsDto>().ReverseMap();
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Course, GetCoursesDto>().ReverseMap();
        }
    }
}