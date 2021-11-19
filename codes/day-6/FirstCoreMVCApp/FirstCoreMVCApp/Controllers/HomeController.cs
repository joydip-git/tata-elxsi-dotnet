using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Welcome to MVC";
        }

        public string SayHi()
        {
            return "Hi...";
        }
    }
}
