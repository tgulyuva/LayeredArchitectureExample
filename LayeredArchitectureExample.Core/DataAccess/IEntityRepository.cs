using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LayeredArchitectureExample.Core.Entities;

namespace LayeredArchitectureExample.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class , IEntity,new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

    }
}
