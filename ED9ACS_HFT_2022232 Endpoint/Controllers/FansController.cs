﻿using ED9ACS_HFT_2022232_Endpoint.Services;
using ED9ACS_HFT_2022232_Logic;
using ED9ACS_HFT_2022232_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;

namespace ED9ACS_HFT_2022232_Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FansController : ControllerBase
    {
        IFansLogic FL;
        IHubContext<SignalRHub> hub;
        public FansController(IFansLogic fL, IHubContext<SignalRHub> hub)
        {
            FL = fL;
            this.hub = hub;
        }
        // GET: /Fans
        [HttpGet]
        public IEnumerable<Fans> Get()
        {
            return FL.GetAllFans();
        }


        // GET /fans/5
        [HttpGet("{id}")]
        public Fans Get(int id)
        {
            return FL.GetFan(id);
        }

        // POST /fans
        [HttpPost]
        public void Post([FromBody] Fans value)
        {
            FL.AddNewFan(value);
            this.hub.Clients.All.SendAsync("FanCreated", value);
        }


        // PUT /fans
        [HttpPut]
        public void Put([FromBody] Fans value)
        {
            FL.UpdateCity(value);
            this.hub.Clients.All.SendAsync("FanUpdated", value);

        }


        // DELETE /fans/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var artistToDelete = this.FL.GetFan(id);
            FL.DeleteFan(id);
            this.hub.Clients.All.SendAsync("FanDeleted", artistToDelete);
        }
    }
}
