using ED9ACS_HFT_2022232_Data;
using ED9ACS_HFT_2022232_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED9ACS_HFT_2022232_Repository
{
    public class FansRepository : Repository<Fans>, IRepository<Fans>
    {
        public FansRepository(TalkWithYourFavoriteArtistDbContext DbContext) : base(DbContext) { }
        public override Fans Read(int id)
        {
            return this.ReadAll().SingleOrDefault(fan => fan.Id == id);

        }

        public override void Update(Fans entity)
        {
            var fan = this.Read(entity.Id);
            if (fan == null)
            {
                throw new Exception("This id doesn't match any Fan in our Database");
            }
            else
            {
                fan.City = entity.City;
                this.context.SaveChanges();
            }
        }

     
    }

}
