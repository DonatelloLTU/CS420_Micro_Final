using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Bartender.Interfaces;
using Bartender.Models;
using Bartender.Models.Events.Published;
using Bartender.Models.Events.Consumed;

namespace Bartender.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SourceController : ControllerBase
    {
        IConfiguration _configuration;
        IEventBus _eventBus;

        public SourceController(IConfiguration configuration, IEventBus eventBus)
        {
            _eventBus = eventBus;
            _configuration = configuration;
            eventBus.HostName = _configuration["rabbitmqhostname"];
            eventBus.PortNumber = Convert.ToInt32(_configuration["rabbitmqport"]);
        }

        [HttpPost]
        public ActionResult DrinkReady([FromBody] DrinkReady drinkReady)
        {
            drinkReady.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<DrinkReady>("drinkReady", drinkReady);

            return new JsonResult(drinkReady);
        }

        [HttpGet]
        public ActionResult GetDrinkOrder()
        {
            return new JsonResult(_eventBus.ConsumeEvent("orderDrink"));
        }

        
    }
}
