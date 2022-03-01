
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class location_Concatenate
    {
        [Key]
        public int Id { get; set; }
       
        public string Postal { get; set; }
       
        public string City { get; set; }
        
        public string District { get; set; }
       
        public string State { get; set; }
       
        public string country { get; set; }
       
        public string Latitude { get; set; }
       
        public string Longitude { get; set; }

    }


    


}

