using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Kitchen.Interfaces;
using Kitchen.Models;
using Kitchen.Models.Events.Consumed;
using Kitchen.Models.Events.Published;

namespace Kitchen.Controllers
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
        public ActionResult FoodReady([FromBody] FoodReady food)
        {
            food.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<FoodReady>("foodReady", food);

            return new JsonResult(food);
        }
        [HttpGet]
        public ActionResult GetFoodOrder()
        {
            return new JsonResult(_eventBus.ConsumeEvent("orderFood"));
        }


    }
}
