using covidAPI.Models;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace covidAPI.API_Externa
{
    public class PaiseFactory
    { 
        [DisableCors]
        public async Task<IEnumerable<Pais>> GetPaises()
        {  
             Sumario global = JsonSerializer.Deserialize<Sumario>(await Utils.GetAsync("https://api.covid19api.com/summary"));
             ///Ordena os paises 
             IEnumerable<Pais> retorno = global.Countries.OrderByDescending(x => x.TotalConfirmed - x.TotalRecovered).Take(10);
             return retorno;
        }
       
}
}
