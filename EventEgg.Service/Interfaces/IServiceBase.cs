using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EventEgg.Service.Interfaces
{
    public interface IServiceBase<T> where T:class 
    {
        T GetSingle(Expression<Func<T, bool>> whereCondition);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

        IList<T> ListBy(Expression<Func<T, bool>> whereCondition);
        IList<T> List();

    }
}
