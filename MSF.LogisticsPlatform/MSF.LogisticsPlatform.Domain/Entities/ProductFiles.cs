using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Entities
{
    public class ProductFiles
    {               
        public int ProductId { get; set; }
        public string ProductFile { get; set; }   
        public Product Product { get; set; }
    }
}
