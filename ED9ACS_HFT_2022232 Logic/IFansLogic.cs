using ED9ACS_HFT_2022232_Models;
using System.Collections.Generic;

namespace ED9ACS_HFT_2022232_Logic
{
    public interface IFansLogic
    {
        void UpdateCity(Fans fan);

        public Fans AddNewFan(Fans fan);
        public void DeleteFan(int id);
        Fans GetFan(int id);
        IEnumerable<Fans> GetAllFans();

        List<KeyValuePair<int, int>> BestFan();
        List<KeyValuePair<int, int>> WorstFan();
        int ReservationsNumber(int id)
;

    }
}