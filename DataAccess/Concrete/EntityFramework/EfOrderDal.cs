using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureExample.Core.DataAccess.EntityFramework;
using LayeredArchitectureExample.DataAccess.Abstract;
using LayeredArchitectureExample.Entities.Concrete;

namespace LayeredArchitectureExample.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, NorthwindContext>, IOrderDal
    {
    }
}
