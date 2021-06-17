using LayeredArchitectureExample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureExample.Core.Utilities.Results;
using LayeredArchitectureExample.Entities.DTOs;

namespace LayeredArchitectureExample.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int CategoryId);
        IDataResult<List<Product>> GetByUnitPrice(decimal min,decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);
        IDataResult<Product> GetById(int productId);
        IResult Update(Product product);
    }
}