using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gameshop.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]      
        [Route(nameof(SayHello))]
        public string SayHello()
        {
            return "Hello";
        }
    }
}
