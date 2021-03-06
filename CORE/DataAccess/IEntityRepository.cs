using CORE.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CORE.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //filtereler yazabilmemiz için örn kategoriye göre listele
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
