using System;
using System.Collections.Generic;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        // To get all products by id
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);

        // To Update a product 
        public void UpdateProduct(Product product);

        // To Create a product
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();

        //To Delete a product
        public void DeleteProduct(Product product);
    }
}

