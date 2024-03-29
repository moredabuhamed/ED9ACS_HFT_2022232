﻿using ED9ACS_HFT_2022232_Models;
using ED9ACS_HFT_2022232_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED9ACS_HFT_2022232_Logic
{
    public class ReservationsServicesLogic : IReservationsServicesLogic
    {
        protected IRepository<ReservationsServices> _ReservationsServicesConnectionRepository;

        public ReservationsServicesLogic(IRepository<ReservationsServices> reservationsServicesConnectionRepository)
        {
            _ReservationsServicesConnectionRepository = reservationsServicesConnectionRepository;
        }

        public ReservationsServices AddNewConnection(ReservationsServices reserserv)
        {
            this._ReservationsServicesConnectionRepository.Create(reserserv);
            return reserserv;
        }
        public void DeleteConnection(int id)
        {
            ReservationsServices ConnectionToDelete = this._ReservationsServicesConnectionRepository.Read(id);
            if (ConnectionToDelete != null)
            {
                this._ReservationsServicesConnectionRepository.Delete(ConnectionToDelete);
            }
        }
        public IEnumerable<ReservationsServices> GetAllConnections()
        {
            return this._ReservationsServicesConnectionRepository.ReadAll();
        }
        public ReservationsServices GetConnection(int id)
        {
            ReservationsServices ReservationsServicesToReturn = this._ReservationsServicesConnectionRepository.Read(id);
            if (ReservationsServicesToReturn != null)
            {
                return ReservationsServicesToReturn;
            }
            else
            {
                throw new Exception("This ID can't be found on our ReservationsServicesDatabase.");
            }
        }
    }
}
