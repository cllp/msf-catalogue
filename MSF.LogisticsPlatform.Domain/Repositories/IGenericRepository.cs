using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        //Get a product by ID
        TEntity Get(int Id);
        //Get all products
        IEnumerable<TEntity> GetAll();
        //CRUD operational support
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
