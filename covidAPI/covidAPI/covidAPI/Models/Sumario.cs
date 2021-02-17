using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace covidAPI.Models
{
    public class Sumario
    {
        public string ID { get; set; }
        public string Message { get; set; }
        public Global Global { get; set; }
        public IEnumerable<Pais> Countries { get;set;}
        public DateTime Date { get; set; }
    }
}
