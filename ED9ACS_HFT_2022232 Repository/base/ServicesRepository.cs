using ED9ACS_HFT_2022232_Data;
using ED9ACS_HFT_2022232_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED9ACS_HFT_2022232_Repository
{
    public class ServicesRepository : Repository<Services>, IServicesRepository
    {
        public ServicesRepository(TalkWithYourFavoriteArtistDbContext DbContext) : base(DbContext) { }
        public override Services GetOne(int id)
        {
            return this.GetAll().SingleOrDefault(service => service.Id == id);
        }

        public void UpdatePrice(int id, int newPrice)
        {
            var service = this.GetOne(id);
            if (service == null)
            {
                throw new Exception("This id doesn't match to any service in our Database");
            }
            else
            {
                service.Price = newPrice;
                this.context.SaveChanges();
            }
        }

    }
}
