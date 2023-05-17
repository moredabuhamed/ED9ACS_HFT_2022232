using ED9ACS_HFT_2022232_Data;
using ED9ACS_HFT_2022232_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED9ACS_HFT_2022232_Repository
{
    public interface IArtistsLogic
    {
        public Artists AddNewArtist(Artists newartist);
        public void DeleteArtist(int id);
        Artists GetArtist(int id);
        IEnumerable<Artists> GetAllArtists();
        void UpdateArtistCost(Artists value);

        IEnumerable<KeyValuePair<string, int>> ArtistEarnings();
        List<KeyValuePair<string, int>> MostPaidArtist();
        List<KeyValuePair<string, int>> LessPaidArtist();

    }

}
