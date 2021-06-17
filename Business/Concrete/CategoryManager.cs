using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureExample.Business.Abstract;
using LayeredArchitectureExample.Core.Utilities.Results;
using LayeredArchitectureExample.DataAccess.Abstract;
using LayeredArchitectureExample.Entities.Concrete;

namespace LayeredArchitectureExample.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IDataResult <List<Category>> GetAll()
        {
            return  new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == id));
        }
    }
}
