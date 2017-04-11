using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MSF.LogisticsPlatform.Domain.Infrastucture;
using Dapper;
using System.Linq;
using System.Data;
using static MSF.LogisticsPlatform.Domain.Entities.Product;
using MSF.LogisticsPlatform.Domain.Entities;

namespace MSF.LogisticsPlatform.Domain.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        //create an obj.instance of IDbConnection

        private readonly IDbConnection _dbConnection;
        public ProductRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;

        }
        public new IEnumerable<Product> GetAll()
        {
            //Get all the Products

            List<Product> productList = SqlMapper.Query<Product>(_dbConnection, "SELECT * FROM Product", CommandType.Text).ToList();
            return productList;

        }



        public Product Get(int id)
        {

            //Retreive Product by ID and show only product details
            /*string sQuery = "SELECT * FROM Product"
                               + " WHERE ProductID = @id";


            return bs.Connection.Query<Product>(sQuery, new { Id = id }).FirstOrDefault();
            */

            //Query for mapping two tables Products and Supplier
            //var sql = @"
            //select * from Product where ProductID = @id
            //select * from Supplier where SupplierId = @id";

            //using (var multi = _dbConnection.QueryMultiple(sql, new { id = id }))
            //{
            //    var products = multi.Read<Product>().SingleOrDefault();
            //    var suppliers = multi.Read<Supplier>().ToList();

            //    if (products != null && suppliers != null)
            //    {


            //        products.suppliers.AddRange(suppliers);
            //    }
            //    return products;
            //}
            throw new NotImplementedException();

        }

        /* public new void Add(Product prod)
         {
             using (IDbConnection dbConnection = Conn.Connection)
             {
                 Conn.Connection.Open();
                 string sQuery = "INSERT INTO Product (ProductTypeId,SupplierId, ProductName, DateCreated, Image, bActive)"
                                 + " VALUES(@ProductTypeId, @SupplierId,@ProductName,@DateCreated,@Image, @bActive)";


                 Conn.Connection.Execute(sQuery, prod);
             }
             Conn.Connection.Close();
         }*/


    }
}
