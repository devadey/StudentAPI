using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Contracts;
using StudentAPI.Data;
using StudentAPI.Models.Course;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController:ControllerBase
    {
        private readonly ICoursesRepository _coursesRepository;
        private readonly IMapper _mapper;
        public CoursesController(ICoursesRepository coursesRepository, IMapper mapper)
        {
            _mapper = mapper;
            _coursesRepository = coursesRepository;
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse (int id)
        {
            var record = await _coursesRepository.GetAsync(id);

            if (record == null)
            {
                return NotFound("No Course was found");
            }

            var result = _mapper.Map<CourseDto>(record);

            return Ok(result);
        }

        [HttpGet("all-courses")]
        public async Task<ActionResult<IEnumerable<GetCoursesDto>>> GetAllCourse()
        {
            var records = await _coursesRepository.GetAllAsync();

            if (records == null)
            {
                return NotFound("No Course was found");
            }

            var results = _mapper.Map<List<GetCoursesDto>>(records);

            return Ok(results);
        }

        [HttpGet("four-courses")]
        public async Task<ActionResult<IEnumerable<GetCoursesDto>>> FourCourse()
        {
            var records = await _coursesRepository.GetFourAsync();

            if (records == null)
            {
                return NotFound("No Course was found");
            }

            var results = _mapper.Map<List<GetCoursesDto>>(records);

            return Ok(results);
        }
    }
}