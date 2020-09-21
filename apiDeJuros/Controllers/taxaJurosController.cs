using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiDeJuros.Entities;
using Microsoft.AspNetCore.Mvc;

namespace apiDeJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class taxaJurosController : ControllerBase
    {        
        [HttpGet]
        public TaxaJuros Get()
        {
            return new TaxaJuros();
        }      
    }
}
