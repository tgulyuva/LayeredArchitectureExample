using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureExample.Entities.Concrete;

namespace LayeredArchitectureExample.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int id);
    }
}
