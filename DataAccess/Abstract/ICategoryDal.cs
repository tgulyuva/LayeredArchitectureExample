using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureExample.Core.DataAccess;
using LayeredArchitectureExample.Entities.Concrete;

namespace LayeredArchitectureExample.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
      
    }
}
