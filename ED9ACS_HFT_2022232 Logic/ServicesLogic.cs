using ED9ACS_HFT_2022232_Models;
using ED9ACS_HFT_2022232_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED9ACS_HFT_2022232_Logic
{
    public class ServicesLogic : IServicesLogic
    {
        protected IServicesRepository _ServicesRepository;

        public ServicesLogic(IServicesRepository servicesRepository)
        {
            _ServicesRepository = servicesRepository;
        }

        public void UpdateServiceCost(Services serv)
        {
            this._ServicesRepository.UpdatePrice(serv.Id, serv.Price);
        }
        public IEnumerable<Services> GetAllServices()
        {
            return this._ServicesRepository.ReadAll();
        }
        public Services GetService(int id)
        {
            Services ServiceToReturn = this._ServicesRepository.Read(id);
            if (ServiceToReturn != null)
            {
                return ServiceToReturn;
            }
            else
            {
                throw new Exception("This ID can't be found on our ServicesDatabase.");
            }
        }
        public Services AddNewService(Services serv)
        {
            if (serv.Name == null)
            {
                throw new ArgumentException("ERROR : Please provide a Name");
            }
            else
            {

                this._ServicesRepository.Create(serv);
                return serv;
            }

        }
        public void DeleteService(int id)
        {
            Services ServiceToDelete = this._ServicesRepository.Read(id);
            if (ServiceToDelete != null)
            {
                this._ServicesRepository.Delete(ServiceToDelete);
            }
            else
            {
                throw new Exception("This ID can't be found on our ServicesDatabase.");
            }
        }

    }
}
