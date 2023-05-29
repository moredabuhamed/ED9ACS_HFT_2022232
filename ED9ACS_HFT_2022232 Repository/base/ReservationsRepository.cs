﻿using ED9ACS_HFT_2022232_Data;
using ED9ACS_HFT_2022232_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED9ACS_HFT_2022232_Repository
{
    public class ReservationsRepository : Repository<Reservations>, IReservationsRepository
    {
        public ReservationsRepository(TalkWithYourFavoriteArtistDbContext DbContext) : base(DbContext) { }
        public void UpdateDate(int id, DateTime newDate)
        {
            var reservation = this.Read(id);
            if (reservation == null)
            {
                throw new Exception("This id doesn't match to any order in our Database");

            }
            else
            {
                reservation.DateTime = newDate;
                this.context.SaveChanges();
            }

        }
        public override Reservations Read(int id)
        {
            return this.ReadAll().SingleOrDefault(reservation => reservation.Id == id);

        }

        public override void Update(Reservations entity)
        {
            var reservation = this.Read(entity.Id);
            if (reservation == null)
            {
                throw new Exception("This id doesn't match any order in our Database");
            }
            else
            {
                reservation.DateTime = entity.DateTime;
                this.context.SaveChanges();
            }
        }
    }
}
