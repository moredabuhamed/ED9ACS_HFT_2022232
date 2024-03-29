﻿using ED9ACS_HFT_2022232_Models;
using ED9ACS_HFT_2022232_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED9ACS_HFT_2022232_Logic
{
    public class FansLogic : IFansLogic
    {
        protected IRepository<Reservations> _ReservationsRepository;
        protected IRepository<Fans> _FansRepository;
        public FansLogic(IRepository<Reservations> reservationsRepo, IRepository<Fans> fansRepo)
        {
            _ReservationsRepository = reservationsRepo;
            _FansRepository = fansRepo;
        }

        public void UpdateCity(Fans fan)
        {
            this._FansRepository.Update(fan);
        }
        public Fans AddNewFan(Fans fan)
        {
            if (fan.Name == null)
            {
                throw new ArgumentException("ERROR : Please provide a Name");
            }
            else
            {

                this._FansRepository.Create(fan);
                return fan;
            }

        }
        public void DeleteFan(int id)
        {
            Fans FanToDelete = this._FansRepository.Read(id);
            if (FanToDelete != null)
            {
                this._FansRepository.Delete(FanToDelete);
            }
            else
            {
                throw new ArgumentException("Error : No FAN with this Id is found.");
            }
        }
        public IEnumerable<Fans> GetAllFans()
        {
            return this._FansRepository.ReadAll();
        }
        public Fans GetFan(int id)
        {
            Fans fanToReturn = this._FansRepository.Read(id);
            if (fanToReturn != null)
            {
                return fanToReturn;
            }
            else
            {
                throw new Exception("This ID can't be found on our FansDatabase.");
            }
        }


        // 2 non-crud methods
        public List<KeyValuePair<int, int>> BestFan()
        {


            var BestFan = from fan in this._FansRepository.ReadAll().ToList()
                          join Reservations in this._ReservationsRepository.ReadAll().ToList()
                          on fan.Id equals Reservations.FanId
                          group Reservations by Reservations.FanId.Value into gr
                          select new
                          {
                              id = gr.Key,
                              c = gr.Count()
                          };
            int max = BestFan.AsEnumerable().Max(t => t.c);

            int[] maxNumOfReservationss = BestFan.Where(x => x.c == max).Select(x => x.id).ToArray();
            List<KeyValuePair<int, int>> r = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < maxNumOfReservationss.Length; i++)
            {
                r.Add(new KeyValuePair<int, int>(maxNumOfReservationss[i], max));
            }
            return r;
        }
        public List<KeyValuePair<int, int>> WorstFan()
        {
            var WorstFan = from fan in this._FansRepository.ReadAll().ToList()
                           join Reservations in this._ReservationsRepository.ReadAll().ToList()
                           on fan.Id equals Reservations.FanId
                           group Reservations by Reservations.FanId.Value into gr
                           select new
                           {
                               id = gr.Key,
                               c = gr.Count()
                           };
            int min = WorstFan.AsEnumerable().Min(t => t.c);
            int[] maxNumOfReservationss = WorstFan.Where(x => x.c == min).Select(x => x.id).ToArray();
            List<KeyValuePair<int, int>> r = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < maxNumOfReservationss.Length; i++)
            {
                r.Add(new KeyValuePair<int, int>(maxNumOfReservationss[i], min));
            }

            return r;
        }
        public int ReservationsNumber(int id)
        {
            if (GetFan(id) == null)
            {
                throw new Exception("This Fan id does not exist in our Database.");
            }
            else
            {
                var res = this._ReservationsRepository.ReadAll().Count(x => x.FanId == id);
                return res;
            }


        }

    }
}
