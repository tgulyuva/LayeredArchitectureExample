using System.Collections.Generic;
using LayeredArchitectureExample.Core.DataAccess;
using LayeredArchitectureExample.Entities.Concrete;
using LayeredArchitectureExample.Entities.DTOs;

namespace LayeredArchitectureExample.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
