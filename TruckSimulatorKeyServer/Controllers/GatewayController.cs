using System;
using System.Collections;
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

        [HttpGet]
        public string Get()
        {
            string message = "API v1\nAvailable key list: "+ $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/api/v1/gateway/keys";
            return message;
        }

        [HttpGet]
        [Route("keys")]
        public List<Keystroke> GetKeys()
        {
            string[] key_arr = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "ESC", "SPACEBAR", "ENTER", "TAB", "PAGE_UP", "PAGE_DOWN", "END", "HOME", "INSERT", "DELETE", "NUMPAD_0", "NUMPAD_1", "NUMPAD_2", "NUMPAD_3", "NUMPAD_4", "NUMPAD_5", "NUMPAD_6", "NUMPAD_7", "NUMPAD_8", "NUMPAD_9", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12" };
            List<Keystroke> key_list = new List<Keystroke>();
            Keystroke key_tmp = new Keystroke();
            foreach(var e in key_arr)
            {
                key_tmp.KeyCode = e;
                key_tmp.KeyName = "Key " + e;
                key_list.Add(key_tmp);
                key_tmp = new Keystroke();
            }
            return key_list;
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
