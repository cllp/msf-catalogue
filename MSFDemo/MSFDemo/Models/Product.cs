using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSFDemo.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double ProductTypeId { get; set; }
        public DateTime dt{get; set;}
        public bool bActive { get; set; }
        public Guid rowGUID { get; set; }
    }
}
