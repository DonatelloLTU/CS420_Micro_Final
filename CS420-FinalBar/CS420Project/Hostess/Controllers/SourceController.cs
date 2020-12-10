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
using Hostess.Interfaces;
using Hostess.Models;
using Hostess.Models.Events.Consumed;
using Hostess.Models.Events.Published;

namespace Hostess.Controllers
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
        public ActionResult NewReservation([FromBody] ReservationPublished pb)
        {
            pb.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<ReservationPublished>("newReservation", pb);

            return new JsonResult(pb);
        }

        [HttpPost]
        public ActionResult TableSeated([FromBody] TableSeated ts)
        {
            ts.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<TableSeated>("seatedTable", ts);

            return new JsonResult(ts);
        }

        [HttpGet]
        public ActionResult GetReservation()
        {
            return new JsonResult(_eventBus.ConsumeEvent("newReservation"));
        }

        [HttpGet]
        public ActionResult TableReady()
        {
            return new JsonResult(_eventBus.ConsumeEvent("tableReady"));
            // var r = _eventBus.ConsumeEvent<TableReady>("tableReady");
            //We do the work here
            // _eventBus.Acknowledge(r.deliveryTag);
            //return new JsonResult(r.data);

        }



    }
}








