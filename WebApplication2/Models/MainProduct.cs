using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class MainProduct
    {
        [Key]

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int SubCategoryId { get; set; }

    }
}
