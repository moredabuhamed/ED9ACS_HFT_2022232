﻿using ED9ACS_HFT_2022232_Models;
using ED9ACS_HFT_2022232_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED9ACS_HFT_2022232_Logic
{
    public class ReservationsLogic : IReservationsLogic
    {

        protected IRepository<Reservations> _ReservationsRepository;
        protected IRepository<Fans> _fansrepo;
        protected IRepository<Artists> _artistrepo;

        public ReservationsLogic(IRepository<Reservations> reservationsRepository, IRepository<Fans> fansrepo, IRepository<Artists> artistrepo)
        {
            _ReservationsRepository = reservationsRepository;
            _fansrepo = fansrepo;
            _artistrepo = artistrepo;
        }

        public void UpdateReservationDate(Reservations reser)
        {
            this._ReservationsRepository.Update(reser);
        }
        public Reservations AddNewReservation(Reservations reser)
        {


            if (_fansrepo.Read((int)reser.FanId) == null || _artistrepo.Read((int)reser.ArtistId) == null)
            {
                throw new Exception("Invalid data");
            }
            else
            {
                this._ReservationsRepository.Create(reser);
                return reser;
            }

        }
        public void DeleteReservation(int id)
        {
            Reservations ReservationToDelete = this._ReservationsRepository.Read(id);
            if (ReservationToDelete != null)
            {
                this._ReservationsRepository.Delete(ReservationToDelete);
            }
        }
        public IEnumerable<Reservations> GetAllReservations()
        {
            return this._ReservationsRepository.ReadAll();
        }
        public Reservations GetReservation(int id)
        {
            Reservations ReservationToReturn = this._ReservationsRepository.Read(id);
            if (ReservationToReturn != null)
            {
                return ReservationToReturn;
            }
            else
            {
                throw new Exception("This ID can't be found on our ReservationsDatabase.");
            }
        }

    }
}
