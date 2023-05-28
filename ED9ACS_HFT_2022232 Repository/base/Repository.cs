using ED9ACS_HFT_2022232_Data;
using System.Linq;

namespace ED9ACS_HFT_2022232_Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected TalkWithYourFavoriteArtistDbContext context;
        protected Repository(TalkWithYourFavoriteArtistDbContext ctx)
        {
            this.context = ctx;
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);

            context.SaveChanges();
        }
        public IQueryable<T> GetAll()
        {
            return this.context.Set<T>();
        }
        public abstract T GetOne(int id);
        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }
    }

 }