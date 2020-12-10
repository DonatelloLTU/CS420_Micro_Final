using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using BussBoy.Interfaces;
using BussBoy.Models;
using BussBoy.Models.Events.Published;
using BussBoy.Models.Events.Consumed;

namespace BussBoy.Controllers
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
        public ActionResult TableReady([FromBody] TableReady table)
        {
            table.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<TableReady>("tableReady", table);

            return new JsonResult(table);
        }
        [HttpGet]
        public ActionResult GetChekcPaid()
        {
            return new JsonResult(_eventBus.ConsumeEvent("checkPaid"));
        }

        
    }
}
