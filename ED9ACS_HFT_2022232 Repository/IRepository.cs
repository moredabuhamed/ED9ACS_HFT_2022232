using System.Linq;

namespace ED9ACS_HFT_2022232_Repository
{
    public interface IRepository<T> where T : class
    {
        T GetOne(int id);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
    }
}