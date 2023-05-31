using ED9ACS_HFT_2022232_Models;
using ED9ACS_HFT_2022232_Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ED9ACS_HFT_2022232_Logic
{
    public class ArtistsLogic : IArtistsLogic
    {

        protected IRepository<Artists> _ArtistRepository;
        protected IRepository<Reservations> _ReservationsRepository;

        public ArtistsLogic(IRepository<Artists> artistRepository, IRepository<Reservations> reservationsRepository)
        {
            _ArtistRepository = artistRepository;
            _ReservationsRepository = reservationsRepository;
        }

        public Artists AddNewArtist(Artists NewArtist)
        {

            this._ArtistRepository.Create(NewArtist);
            return NewArtist;
        }
        public void DeleteArtist(int id)
        {
            Artists ArtistToDelete = this._ArtistRepository.Read(id);
            if (ArtistToDelete != null)
            {
                this._ArtistRepository.Delete(ArtistToDelete);
            }
            else
            {
                throw new ArgumentException("This ID can't be found on our ArtistsDatabase.");
            }
        }
        public void UpdateArtistCost(Artists value)
        {
            this._ArtistRepository.Update(value);
        }
        public IEnumerable<Artists> GetAllArtists()
        {
            return this._ArtistRepository.ReadAll();
        }
        public Artists GetArtist(int id)
        {
            Artists ArtistToReturn = this._ArtistRepository.Read(id);
            if (ArtistToReturn != null)
            {
                return ArtistToReturn;
            }
            else
            {
                throw new Exception("This ID can't be found on our ArtistsDatabase.");
            }
        }




        // 3 non-crud methods
        public IEnumerable<KeyValuePair<string, int>> ArtistEarnings()
        {
            var TotalEarning = from artists in this._ArtistRepository.ReadAll().ToList()
                               join reservations in this._ReservationsRepository.ReadAll().ToList()
                               on artists.Id equals reservations.ArtistId
                               group reservations by reservations.ArtistId.Value into gr
                               select new KeyValuePair<string, int>
                               (_ArtistRepository.Read(gr.Key).Name, (gr.Count()) * _ArtistRepository.Read(gr.Key).Price);
            return TotalEarning;
        }
        public List<KeyValuePair<string, int>> MostPaidArtist()
        {
            int max = ArtistEarnings().Max(t => t.Value);
            string[] maxNums = ArtistEarnings().Where(x => x.Value == max).Select(x => x.Key).ToArray();
            List<KeyValuePair<string, int>> r = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < maxNums.Length; i++)
            {
                r.Add(new KeyValuePair<string, int>(maxNums[i], max));
            }
            return r;

        }
        public List<KeyValuePair<string, int>> LessPaidArtist()
        {
            int min = ArtistEarnings().Min(t => t.Value);
            string[] minNums = ArtistEarnings().Where(x => x.Value == min).Select(x => x.Key).ToArray();
            List<KeyValuePair<string, int>> r = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < minNums.Length; i++)
            {
                r.Add(new KeyValuePair<string, int>(minNums[i], min));
            }
            return r;
        }
    }
}
