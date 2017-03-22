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
        public int ProductId { get; set; }
        public double ProductTypeId { get; set; }
        public int SupplierId { get; set; }
        public string ProductName { get; set; }
        public DateTime DateCreated{get; set;}
        public bool bActive { get; set; }
        
    }
}
