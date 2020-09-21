using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace calculaJuros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "https://github.com/juliohgt/apiNetCoreWithSwagger.git";
        }
    }
}