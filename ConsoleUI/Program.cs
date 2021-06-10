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
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(product.ProductName);
            }
            Console.ReadLine();
        }
    }
}
