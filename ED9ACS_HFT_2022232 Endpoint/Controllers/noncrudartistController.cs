using ED9ACS_HFT_2022232_Logic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ED9ACS_HFT_2022232_Endpoint.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class noncrudartistController : ControllerBase
    {
        IArtistsLogic Al;

        public noncrudartistController(IArtistsLogic al)
        {
            Al = al;
        }


        // GET: Noncrudartist/ArtistsEarnings
        [HttpGet]
        public IEnumerable<KeyValuePair<string, int>> ArtistsEarnings()
        {
            return Al.ArtistEarnings();
        }


        // GET: Noncrudartist/Mostpaidart
        [HttpGet]
        public List<KeyValuePair<string, int>> Mostpaidart()
        {
            return Al.MostPaidArtist();
        }


        // GET: Noncrudartist/Lesspaidart
        [HttpGet]
        public List<KeyValuePair<string, int>> Lesspaidart()
        {
            return Al.LessPaidArtist();
        }
    }
}
