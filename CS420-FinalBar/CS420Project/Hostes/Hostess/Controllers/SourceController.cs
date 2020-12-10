using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Hostess.Interfaces;
using Hostess.Models;
using Hostess.Models.Events.Consumed;
using Hostess.Models.Events.Published;
using RabbitMQ.Client;
using System.Text;
using RabbitMQ.Client.Events;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.AspNetCore.Cors;

namespace Hostess.Controllers
{
    [Route("api/[controller]")]
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
        public ActionResult NewReservation([FromBody] ReservationPublished rt)
        {
            rt.TimeStamp = DateTime.Now;
            _eventBus.PublishEvent<ReservationPublished>("newReservation", rt);
            return new JsonResult(rt);

        }

        [HttpGet]
        public ActionResult GetReservation()
        {
            return new JsonResult(_eventBus.ConsumeEvent("newReservation"));
        }

        [HttpPost]
        public ActionResult TableSeated([FromBody] TableSeated ts)
        {
            ts.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<TableSeated>("tableSeated", ts);

            return new JsonResult(ts);
        }

        [HttpGet]
        public ActionResult TableReady()
        {
            return new JsonResult(_eventBus.ConsumeEvent("tableReady"));
        }
    }
}
