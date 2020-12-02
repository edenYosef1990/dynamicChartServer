using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Server.Hubs;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IHubContext<ServiceHub> _hub;

        public ChatController(IHubContext<ServiceHub> hub)
        {
            _hub = hub;
        }

        public IActionResult Get()
        {
            return Ok(new { Message = "Request Completed" });
        }
    }
}
