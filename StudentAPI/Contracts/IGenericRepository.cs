namespace StudentAPI.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync (int id);
        Task<List<T>> GetAllAsync ();
        Task<List<T>> GetFourAsync();
        
    }
}