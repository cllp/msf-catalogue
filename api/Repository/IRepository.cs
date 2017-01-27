namespace MSF.Catalogue.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using MSF.Catalogue.Models;
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T item);
        void Remove(int id);
        void Update(T item);
        T FindByID(int id);
        IEnumerable<T> FindAll();
    }
}