using StudentAPI.Contracts;
using StudentAPI.Data;

namespace StudentAPI.Repository
{
    public class CoursesRepository : GenericRepository<Course>, ICoursesRepository
    {
        public CoursesRepository(StudentDbContext context) : base(context)
        {
        }
    }
}