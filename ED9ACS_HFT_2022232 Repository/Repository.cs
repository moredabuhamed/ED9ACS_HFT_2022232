using ED9ACS_HFT_2022232_Data;

namespace ED9ACS_HFT_2022232_Repository
{
    public class Repository<T>
    {
        private TalkWithYourFavoriteArtistDbContext dbContext;

        public Repository(TalkWithYourFavoriteArtistDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}