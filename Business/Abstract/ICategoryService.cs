using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureExample.Core.Utilities.Results;
using LayeredArchitectureExample.Entities.Concrete;

namespace LayeredArchitectureExample.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int id);
    }
}
