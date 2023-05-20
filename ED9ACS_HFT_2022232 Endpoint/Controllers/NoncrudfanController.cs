using ED9ACS_HFT_2022232_Logic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ED9ACS_HFT_2022232_Endpoint.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class NoncrudfanController : ControllerBase
    {
        IFansLogic FL;

        public NoncrudfanController(IFansLogic fL)
        {
            FL = fL;
        }

        // GET: Noncrudfan/ReservationNUM/id
        [HttpGet("{id}")]
        public int ReservationNUM(int id)
        {
            return FL.ReservationsNumber(id);
        }

        // GET: Noncrudfan/BestFans
        [HttpGet]
        public List<KeyValuePair<int, int>> BestFans()
        {
            return FL.BestFan();
        }

        // GET: Noncrudfan/WorstFans
        [HttpGet]
        public List<KeyValuePair<int, int>> WorstFans()
        {
            return FL.WorstFan();
        }

    }
}
