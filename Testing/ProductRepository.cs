using System;
using Dapper;
using System.Data;
using Testing.Models;
using System.Collections.Generic;

namespace Testing
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        IEnumerable<Product> IProductRepository.GetAllProducts()
        {
            return _conn.Query <Product>("SELECT * FROM PRODUCTS;");
        }
    }
}

