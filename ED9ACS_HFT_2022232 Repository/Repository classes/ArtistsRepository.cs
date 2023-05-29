using ED9ACS_HFT_2022232_Data;
using ED9ACS_HFT_2022232_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED9ACS_HFT_2022232_Repository
{
    public class ArtistsRepository : Repository<Artists>, IRepository<Artists>
    {
        public ArtistsRepository(TalkWithYourFavoriteArtistDbContext DbContext) : base(DbContext) { }
        public override Artists Read(int id)
        {
            return this.ReadAll().SingleOrDefault(artist => artist.Id == id);

        }

        public override void Update(Artists entity)
        {

        }

        public void UpdatePrice(int id, int newprice)
        {
            var artist = this.Read(id);
            if (artist == null)
            {
                throw new Exception("This id doesn't match to any artist in our Database");
            }
            else
            {
                artist.Price = newprice;
                this.context.SaveChanges();
            }
        }
    }
}
