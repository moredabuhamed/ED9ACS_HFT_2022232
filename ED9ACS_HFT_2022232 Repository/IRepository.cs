using System.Linq;

namespace ED9ACS_HFT_2022232_Repository
{
    public interface IRepository<T> where T : class
    {
        T Read(int id);
        IQueryable<T> ReadAll();
        void Create(T entity);
        void Delete(T entity);
    }
}