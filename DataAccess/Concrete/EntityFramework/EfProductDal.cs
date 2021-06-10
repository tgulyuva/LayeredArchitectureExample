using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureExample.Core.DataAccess.EntityFramework;
using LayeredArchitectureExample.DataAccess.Abstract;
using LayeredArchitectureExample.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace LayeredArchitectureExample.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
