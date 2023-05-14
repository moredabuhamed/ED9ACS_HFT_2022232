using ED9ACS_HFT_2022232_Models;

namespace ED9ACS_HFT_2022232_Repository
{
    public interface IArtistsRepository : IRepository<Artists>
    {

        void UpdatePrice(int id, int newprice);

    }
}