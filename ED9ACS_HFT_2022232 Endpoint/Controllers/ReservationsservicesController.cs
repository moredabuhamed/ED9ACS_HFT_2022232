using ED9ACS_HFT_2022232_Logic;
using ED9ACS_HFT_2022232_Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ED9ACS_HFT_2022232_Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReservationsservicesController : ControllerBase
    {
        IReservationsServicesLogic RSL;

        public ReservationsservicesController(IReservationsServicesLogic rSL)
        {
            RSL = rSL;
        }
        // GET: /reservationsservices
        [HttpGet]
        public IEnumerable<ReservationsServices> Get()
        {
            return RSL.GetAllConnections();
        }


        // GET /reservationsservices/5
        [HttpGet("{id}")]
        public ReservationsServices Get(int id)
        {
            return RSL.GetConnection(id);
        }

        // POST /reservationsservices
        [HttpPost]
        public void Post([FromBody] ReservationsServices value)
        {
            RSL.AddNewConnection(value);
        }



        // DELETE /reservationsservices/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            RSL.DeleteConnection(id);
        }
    }
}
