using ED9ACS_HFT_2022232_Data;
using ED9ACS_HFT_2022232_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED9ACS_HFT_2022232_Repository
{
    public class ReservationsServicesRepository : Repository<ReservationsServices>, IReservationsServicesRepository
    {
        public ReservationsServicesRepository(TalkWithYourFavoriteArtistDbContext DbContext) : base(DbContext) { }
        public override ReservationsServices GetOne(int id)
        {
            return this.GetAll().SingleOrDefault(connection => connection.Id == id);

        }


    }
}
