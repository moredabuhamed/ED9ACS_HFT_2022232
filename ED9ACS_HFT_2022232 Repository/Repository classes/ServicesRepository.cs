using ED9ACS_HFT_2022232_Data;
using ED9ACS_HFT_2022232_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED9ACS_HFT_2022232_Repository
{
    public class ServicesRepository : Repository<Services>, IRepository<Services>
    {
        public ServicesRepository(TalkWithYourFavoriteArtistDbContext DbContext) : base(DbContext) { }

        public override void Update(Services entity)
        {
            var service = this.Read(entity.Id);
            if (service == null)
            {
                throw new Exception("This id doesn't match any service in our Database");
            }
            else
            {
                service.Price = entity.Price;
                this.context.SaveChanges();
            }
        }
        public override Services Read(int id)
        {
            return this.ReadAll().SingleOrDefault(service => service.Id == id);
        }






    }
}
