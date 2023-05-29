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
        public void Create(T entity)
        {
            context.Set<T>().Add(entity);

            context.SaveChanges();
        }
        public IQueryable<T> ReadAll()
        {
            return this.context.Set<T>();
        }
        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }
        public abstract T Read(int id);
        public abstract void Update(T entity);

    }

}