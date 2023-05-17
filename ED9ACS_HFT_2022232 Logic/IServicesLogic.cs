using ED9ACS_HFT_2022232_Models;
using System.Collections.Generic;

namespace ED9ACS_HFT_2022232_Logic
{
    public interface IServicesLogic
    {
        Services GetService(int id);
        IEnumerable<Services> GetAllServices();
        void UpdateServiceCost(Services serv);
        public Services AddNewService(Services serv);
        public void DeleteService(int id);

    }
}