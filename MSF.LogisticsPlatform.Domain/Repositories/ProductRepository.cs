using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MSF.LogisticsPlatform.Domain.Infrastucture;
using Dapper;
using System.Linq;
using static MSF.LogisticsPlatform.Domain.Entities.Product;
using MSF.LogisticsPlatform.Domain.Entities;

namespace MSF.LogisticsPlatform.Domain.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        //create an obj.instance of IDbConnection
         DBConnectionFactory Conn=new DBConnectionFactory();
        public new IEnumerable<Product> GetAll()
        {
            //Get all the Products
            using (IDbConnection dbConnection = Conn.Connection)
            {
                dbConnection.Open();
                List<Product> productList = SqlMapper.Query<Product>(dbConnection, "SELECT * FROM P.Product", CommandType.Text).ToList();
                return productList;
                
            }

            
        }
        public Product Get(int id)
        {
            
            //Retreive Product by ID and show only product details
            /*string sQuery = "SELECT * FROM Product"
                               + " WHERE ProductID = @id";


            return bs.Connection.Query<Product>(sQuery, new { Id = id }).FirstOrDefault();
            */
            
            //Query for mapping two tables Products and Supplier
            var sql = @"
            select * from P.Product where ProductID = @id
            select * from P.Supplier where SupplierId = @id";

            using (var multi = Conn.Connection.QueryMultiple(sql, new { id = id }))
            {
                var products = multi.Read<Product>().SingleOrDefault();
                var suppliers = multi.Read<Supplier>().ToList();

                if (products != null && suppliers != null)
                {


                    products.suppliers.AddRange(suppliers);
                }
                return products;
            }

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
