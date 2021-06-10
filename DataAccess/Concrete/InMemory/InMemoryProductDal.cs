using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LayeredArchitectureExample.DataAccess.Abstract;
using LayeredArchitectureExample.Entities.Concrete;
using LayeredArchitectureExample.Entities.DTOs;

namespace LayeredArchitectureExample.DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal:IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{CategoryId = 1,ProductId = 1,ProductName = "Bardak",UnitPrice = 15,UnitsInStock = 15},
                new Product{CategoryId = 2,ProductId = 1,ProductName = "Kamera",UnitPrice = 500,UnitsInStock = 3},
                new Product{CategoryId = 3,ProductId = 2,ProductName = "Telefon",UnitPrice = 1500,UnitsInStock = 2},
                new Product{CategoryId = 4,ProductId = 2,ProductName = "Klavye",UnitPrice = 150,UnitsInStock = 65},
                new Product{CategoryId = 5,ProductId = 2,ProductName = "Fare",UnitPrice = 85,UnitsInStock = 15}
            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }
        public void Update(Product product)
        {
            Product productToUpdate= _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.ProductId = product.ProductId;
            }
        }
        public void Delete(Product product)
        {
            _products.Remove(_products.SingleOrDefault(x => x.ProductId == product.ProductId));
        }
        public List<Product> GetAllByCategory(int categoryId) => _products.Where(x => x.CategoryId == categoryId).ToList();

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
