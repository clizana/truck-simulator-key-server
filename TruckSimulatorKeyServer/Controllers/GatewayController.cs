using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InputSimulatorStandard;
using InputSimulatorStandard.Native;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TruckSimulatorKeyServer.Helpers;
using TruckSimulatorKeyServer.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TruckSimulatorKeyServer.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GatewayController : ControllerBase
    {
        // GET: api/<GatewayController>
        [HttpGet]
        public string Get()
        {
            return "API v1";
        }

        // POST api/<GatewayController>
        [HttpPost]
        public string Post([FromBody] Keystroke json)
        {
            var key = KeyUtils.KeyToVK(json.KeyCode);
            var simulator = new InputSimulator();
            if (key == 0)
                return "The Key is not mapped";
            simulator.Keyboard.KeyPress(key);
            return "OK";
        }

    }
}
