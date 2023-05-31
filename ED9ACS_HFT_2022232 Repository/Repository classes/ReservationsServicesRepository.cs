using ED9ACS_HFT_2022232_Data;
using ED9ACS_HFT_2022232_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED9ACS_HFT_2022232_Repository
{
    public class ReservationsServicesRepository : Repository<ReservationsServices>, IRepository<ReservationsServices>
    {
        public ReservationsServicesRepository(TalkWithYourFavoriteArtistDbContext DbContext) : base(DbContext) { }
        public override ReservationsServices Read(int id)
        {
            return this.ReadAll().SingleOrDefault(connection => connection.Id == id);

        }

        public override void Update(ReservationsServices entity)
        {
        }
    }
}
