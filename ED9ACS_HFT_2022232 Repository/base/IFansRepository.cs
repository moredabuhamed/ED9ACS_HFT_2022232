using ED9ACS_HFT_2022232_Models;
using System.Collections.Generic;

namespace ED9ACS_HFT_2022232_Repository
{
    public interface IFansRepository : IRepository<Fans>
    {
        void UpdateCity(int id, string newcity);

    }
}