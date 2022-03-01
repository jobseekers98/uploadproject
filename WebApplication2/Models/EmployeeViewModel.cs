using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{



    public class EmployeeViewModel
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
        public EmployeeViewModel()
        {
            StateDropDownList = new List<StateList>()
        {
        new StateList { Text = "Andhra Pradesh", Value = 1 },
        new StateList { Text = "Arunachal Pradesh", Value = 2 },
        new StateList { Text = "Assam", Value = 3 },
        new StateList { Text = "Bihar", Value = 4 },
        new StateList { Text = "Chhattisgarh", Value = 5 },
        new StateList { Text = "Goa", Value = 6 },
        new StateList { Text = "Gujarat", Value = 7 },
        new StateList { Text = "Haryana", Value = 8 },
        new StateList { Text = "Himachal Pradesh", Value = 9 },
        new StateList { Text = "Jammu and Kashmir", Value = 10 },
        new StateList { Text = "Jharkhand", Value = 11 },
        new StateList { Text = "Karnataka", Value = 12 },
        new StateList { Text = "Kerala", Value = 13 },
        new StateList { Text = "Madhya Pradesh", Value = 14 },
        new StateList { Text = "Maharashtra", Value = 15 },
        new StateList { Text = "Mizoram", Value = 16 },
        new StateList { Text = "Nagaland", Value = 17 },
        new StateList { Text = "Odisha", Value = 18 },
        new StateList { Text = "Punjab", Value = 19 },
        new StateList { Text = "Rajasthan", Value = 20 },
        new StateList { Text = "Sikkim", Value = 21 },
        new StateList { Text = "Tamilnadu", Value = 22 },
        new StateList { Text = "Telangana", Value = 23 },
        new StateList { Text = "Uttar Pradesh", Value = 24 },
        new StateList { Text = "Uttarakhand", Value = 25 },
        new StateList { Text = "West Bengal", Value = 26 },
         new StateList { Text = "Manipur", Value = 27 },
         new StateList { Text = "Meghalaya", Value = 28 },
        new StateList { Text = "Tripura", Value = 29 },

        };
        }
        public List<StateList> StateDropDownList { get; set; }
    }
    public class StateList
    {
        [Key]
        public int Value { get; set; }
        public string Text { get; set; }
        
    }
}

