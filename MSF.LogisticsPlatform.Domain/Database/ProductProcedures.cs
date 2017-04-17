using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MSF.LogisticsPlatform.Domain.Entities;
using MSF.LogisticsPlatform.Domain.Database.Data;
using Dapper;
using System.Linq;

namespace MSF.LogisticsPlatform.Domain.Database
{
    public class ProductProcedures : IProductProcedures
    {
        private readonly IDbConnection _dbConnection;

        public ProductProcedures(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            //List<Product> productList = SqlMapper.Query<Product>(_dbConnection, "EXEC spFiltreratMeck()", CommandType.StoredProcedure).ToList();
            //return productList;

            //throw new NotImplementedException();
            IEnumerable<Product> productList = SqlMapper.Query<Product>(_dbConnection, "dbo.GetFilteredProductList", commandType: CommandType.StoredProcedure);
            return productList;

        }
        

            public Domain.Entities.Product Get(int id)
            {

                   //mapping data between two tables
                    var sql = @"
                     select * from Product where ProductID = @id
                     select  * from AttributeClassification where AttributeSectionID = @id";

                    using (var multi = _dbConnection.QueryMultiple(sql, new { id = id }))
                    {
                        var products = multi.Read<Domain.Entities.Product>().SingleOrDefault();
                        var attributeClassification = multi.Read<AttributeClassification>().ToList();

                        if (products != null && attributeClassification != null)
                        {
                            products.attributeClassification.AddRange(attributeClassification);
                        }
                        return products;
                    }

                }
            }
            
            
       
        public IEnumerable<Product> GetFilteredProducts(ShelterFilter shelterFilter)
        {            
            throw new NotImplementedException();
        }


    }
}
