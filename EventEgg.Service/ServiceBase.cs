using EventEgg.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EventEgg.Service
{

    public abstract class ServiceBase<T> : IServiceBase<T> where T : class 
    {
        #region Implementation of IServiceBase<T>

        public T GetSingle(Expression<Func<T, bool>> whereCondition)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public IList<T> ListBy(Expression<Func<T, bool>> whereCondition)
        {
            throw new NotImplementedException();
        }

        public IList<T> List()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
