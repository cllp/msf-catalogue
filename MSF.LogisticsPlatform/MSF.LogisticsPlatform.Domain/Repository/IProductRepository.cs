using System.Collections.Generic;
using System.Threading.Tasks;
using MSF.LogisticsPlatform.Domain.Entities;

namespace MSF.LogisticsPlatform.Domain.Repository
{
    public interface IProductRepository
    {
        //Task<IEnumerable<Product>> GetAll();
        Task<IEnumerable<ProductFiles>> GetAll();
    }
}