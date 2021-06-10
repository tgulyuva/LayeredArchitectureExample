using System.Collections.Generic;
using LayeredArchitectureExample.Core.DataAccess;
using LayeredArchitectureExample.Entities.Concrete;

namespace LayeredArchitectureExample.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
