using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessngerLibrary;

namespace ApiClient.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("{name}")]
        public string Index(string name)
        {
            Messenger messenger = new Messenger();
            return messenger.ShowMessage(name);
        }
    }
}
