using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Waiter.Interfaces;
using Waiter.Models;
using Waiter.Models.Events.Consumed;
using Waiter.Models.Events.Published;

namespace Waiter.Controllers
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
        public ActionResult OrderDrinks([FromBody] Drinks drinks)
        {
            drinks.TimeStamp = new DateTime();

            _eventBus.PublishEvent<Drinks>("orderDrink", drinks);

            return new JsonResult(drinks);
        }

        [HttpPost]
        public ActionResult OrderFood([FromBody] Food food)
        {
            food.TimeStamp = new DateTime();

            _eventBus.PublishEvent<Food>("orderFood", food);

            return new JsonResult(food);
        }

        [HttpPost]
        public ActionResult CheckPaid([FromBody] CheckPaid cp)
        {
            cp.TimeStamp = new DateTime();

            _eventBus.PublishEvent<CheckPaid>("checkPaid", cp);

            return new JsonResult(cp);
        }

        [HttpGet]
        public ActionResult DrinkReady()
        {
            return new JsonResult(_eventBus.ConsumeEvent("drinkReady"));
        }

        [HttpGet]
        public ActionResult FoodReady()
        {
            return new JsonResult(_eventBus.ConsumeEvent("foodReady"));
        }

        [HttpGet]
        public ActionResult ReadyToPay()
        {
            return new JsonResult(_eventBus.ConsumeEvent("readyToPay"));
        }

        [HttpGet]
        public ActionResult TableSeated()
        {
            return new JsonResult(_eventBus.ConsumeEvent("seatedTable"));
        }










    }
}