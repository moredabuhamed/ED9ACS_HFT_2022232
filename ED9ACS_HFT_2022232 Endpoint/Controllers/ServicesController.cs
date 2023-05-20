﻿using ED9ACS_HFT_2022232_Endpoint.services;
using ED9ACS_HFT_2022232_Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using ED9ACS_HFT_2022232_Models;

namespace ED9ACS_HFT_2022232_Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        IServicesLogic SL;
        IHubContext<SignalRHub> hub;

        public ServicesController(IServicesLogic sL, IHubContext<SignalRHub> hub)
        {
            SL = sL;
            this.hub = hub;
        }

        // GET: /services
        [HttpGet]
        public IEnumerable<Services> Get()
        {
            return SL.GetAllServices();
        }


        // GET /services/5
        [HttpGet("{id}")]
        public Services Get(int id)
        {
            return SL.GetService(id);
        }

        // POST /services
        [HttpPost]
        public void Post([FromBody] Services value)
        {
            SL.AddNewService(value);
            this.hub.Clients.All.SendAsync("ServiceCreated", value);
        }


        // PUT /services
        [HttpPut]
        public void Put([FromBody] Services value)
        {
            SL.UpdateServiceCost(value);
            this.hub.Clients.All.SendAsync("ServiceUpdated", value);
        }


        // DELETE /services/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var artistToDelete = this.SL.GetService(id);
            SL.DeleteService(id);
            this.hub.Clients.All.SendAsync("ServiceDeleted", artistToDelete);
        }
    }
}
