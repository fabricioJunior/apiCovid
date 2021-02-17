using covidAPI.API_Externa;
using covidAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace covidAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Covid19Controller : ControllerBase
    {
        public async Task<IEnumerable<Pais>> GetAsync()
        {
            IEnumerable<Pais> retorno = await new PaiseFactory().GetPaises();
            return retorno;
        }


    }
}
