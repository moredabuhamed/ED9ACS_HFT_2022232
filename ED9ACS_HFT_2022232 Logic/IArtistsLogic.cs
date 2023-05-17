using ED9ACS_HFT_2022232_Models;
using System.Collections.Generic;

namespace ED9ACS_HFT_2022232_Logic
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