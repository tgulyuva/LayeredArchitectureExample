using System;
using LayeredArchitectureExample.Business.Concrete;
using LayeredArchitectureExample.DataAccess.Concrete.EntityFramework;
using LayeredArchitectureExample.DataAccess.Concrete.InMemory;

namespace LayeredArchitectureExample.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);   
            }
            Console.ReadLine();
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
