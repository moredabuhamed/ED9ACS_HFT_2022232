using ED9ACS_HFT_2022232_Models;
using System.Collections.Generic;

namespace ED9ACS_HFT_2022232_Logic
{
    public interface IReservationsLogic
    {
        void UpdateReservationDate(Reservations reser);
        public Reservations AddNewReservation(Reservations reser);
        public void DeleteReservation(int id);
        Reservations GetReservation(int id);
        IEnumerable<Reservations> GetAllReservations();

    }
}