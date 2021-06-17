using System;
using LayeredArchitectureExample.Business.Abstract;
using LayeredArchitectureExample.Business.Concrete;
using LayeredArchitectureExample.DataAccess.Concrete.EntityFramework;
using LayeredArchitectureExample.DataAccess.Concrete.InMemory;

namespace LayeredArchitectureExample.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
            Console.ReadLine();
        }

        private static void CategoryTest()
        {
            ICategoryService categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            IProductService productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetAll();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                      Console.WriteLine(product.ProductName + " / " + product.CategoryId);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }
    }
}
