using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSFDemo.Models;

namespace MSFDemo.Repository
{
    public interface IProductRepository
    {

        void Add(Product prod);
        IEnumerable<Product> GetAll();
        Product GetByID(int id);
        void Delete(int id);
        void Update(Product prod);
    }
}
