using ED9ACS_HFT_2022232_Models;
using System.Collections.Generic;

namespace ED9ACS_HFT_2022232_Logic
{
    public interface IReservationsServicesLogic
    {
        public ReservationsServices AddNewConnection(ReservationsServices reservserv);

        public void DeleteConnection(int id);
        public ReservationsServices GetConnection(int id);
        public IEnumerable<ReservationsServices> GetAllConnections();
    }
}