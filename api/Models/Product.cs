namespace MSF.Catalogue.Models
{
    //using Dapper;
    public class Product : BaseEntity
    {
        //[Key]
        public long Id { get; set; }
 
        //[Required]
        public string Name { get; set; }
    }
}