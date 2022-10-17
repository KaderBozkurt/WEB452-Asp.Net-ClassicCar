using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicCar.Models
{
    public class CarTransmissionViewModel
    {
       

        public List<Car> Cars { get; set; }

        public SelectList Transmissions { get; set; }
        public string CarTransmission {get; set;}
        public string SearchString { get; set; }
        public SelectList Transmission { get; internal set; }
    }
}
