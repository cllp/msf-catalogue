using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MSF.LogisticsPlatform.Domain.Entities;
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
            IEnumerable<Product> productList = SqlMapper.Query<Product>(_dbConnection, "dbo.GetFilteredProductList", commandType: CommandType.StoredProcedure);
            return productList;
        }

        public IEnumerable<ProductDetail> GetById(int id)
        {
            IEnumerable<ProductDetail> productDetailList;
            productDetailList = SqlMapper.Query<ProductDetail>(_dbConnection, "SELECT * FROM dbo.vProductData Where ProductID =" + id);
            return productDetailList;
        }

        public IEnumerable<Product> GetFilteredProducts(string parameterAsArray)
        {
            StringBuilder query = new StringBuilder();
            query.Append("Exec dbo.GetFilteredProductsList ");
            query.Append(parameterAsArray);

            IEnumerable<Product> productList = SqlMapper.Query<Product>(_dbConnection, query.ToString());
            return productList;
        }
    }
}
