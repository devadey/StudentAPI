using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Contracts;
using StudentAPI.Data;
using StudentAPI.Models.Student;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController:ControllerBase
    {
        private readonly IStudentsRepository _studentsRepository;
        private readonly IMapper _mapper;
        public StudentsController(IStudentsRepository studentsRepository, IMapper mapper)
        {
            _mapper = mapper;
            _studentsRepository = studentsRepository;
            
        }

        [HttpGet("id")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _studentsRepository.GetAsync(id);

            if (student == null)
            {
                return NotFound("No student record was found");
            }
            var result = _mapper.Map<StudentDto>(student);
            return Ok(result);
        }

        [HttpGet("all-Students")]
        public async Task<ActionResult<List<GetStudentsDto>>> GetAllStudents()
        {
            var students = await _studentsRepository.GetAllAsync();

            if (students == null)
            {
                return NotFound("No student record was found");
            }

            var results = _mapper.Map<List<GetStudentsDto>>(students);

            return Ok(results);
        }


        [HttpGet("four-students")]
        public async Task<ActionResult<List<Student>>> GetFourStudents()
        {
            var students = await _studentsRepository.GetFourAsync();
            if (students == null)
            {
                return NotFound("No student record was found");
            }

            var results = _mapper.Map<List<GetStudentsDto>>(students);

            return Ok(results);
        }
        
    }
}