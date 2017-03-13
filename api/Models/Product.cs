namespace MSF.Catalogue.Models
{
    using System;
    //using Dapper;
    public class Product : BaseEntity
    {
        //[Key]
        public long Id { get; set; }
 
        //[Required]
        public string Name { get; set; }

        public DateTime Created { get; set; }
    }
}