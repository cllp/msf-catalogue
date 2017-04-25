using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Entities
{
    /*
     * ProductFile from product file table.
     * This class is linked to product table.
     * 
     */
    public class ProductFile
    {
        public int ProductID { get; set; }       
        public string ProductFileName { get; set; }       
        public string FDescription { get; set; }        
    }
}
