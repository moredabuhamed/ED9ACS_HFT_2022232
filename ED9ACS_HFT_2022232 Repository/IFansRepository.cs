using ED9ACS_HFT_2022232_Models;
using System.Collections.Generic;

namespace ED9ACS_HFT_2022232_Repository
{
    public interface IFansRepository
    {
        void Add(Fans fan);
        void Delete(Fans fanToDelete);
        IEnumerable<Fans> GetAll();
        Fans GetOne(int id);
        void UpdateCity(int id, string newcity);

    }
}