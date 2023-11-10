using StudentAPI.Contracts;
using StudentAPI.Data;

namespace StudentAPI.Repository
{
    public class StudentsRepository: GenericRepository<Student>, IStudentsRepository
    {
        public StudentsRepository(StudentDbContext context) : base(context)
        {
        }
    }
}