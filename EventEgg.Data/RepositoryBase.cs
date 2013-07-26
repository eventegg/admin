using System;
using System.Linq;
using System.Linq.Expressions;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Linq;

namespace EventEgg.Data
{
    public abstract class RepositoryBase<T> : IRepository<T>
        where T : class
    {

        private readonly ISessionFactory _sessionFactory;
        private readonly ISession _session;

        protected RepositoryBase()
        {
            try
            {
                var config = Fluently.Configure()
                       .Database(MsSqlConfiguration.MsSql2008.ConnectionString(c => c.FromConnectionStringWithKey("ConnectionString")))
                       .Mappings(m => m.FluentMappings.AddFromAssemblyOf<T>())
                       .BuildConfiguration();

                _sessionFactory = config.BuildSessionFactory();
                _session = _sessionFactory.OpenSession();
                _session.FlushMode = FlushMode.Commit;
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA: " + ex.Message);
            }
        }

        #region Implementation of IRepository<T>

        public void Insert(T item)
        {
            using (_sessionFactory)
            {
                using (_session)
                {
                    using (var trans = _session.BeginTransaction())
                    {
                        try
                        {
                            _session.Save(item);
                            trans.Commit();
                        }
                        catch
                        {
                            trans.Rollback();
                        }
                        finally
                        {
                            trans.Dispose();
                        }
                    }
                }
            }
        }

        public void Update(T item)
        {
            using (_sessionFactory)
            {
                using (_session)
                {
                    using (var trans = _session.BeginTransaction())
                    {
                        try
                        {
                            _session.Update(item);
                            trans.Commit();
                        }
                        catch
                        {
                            trans.Rollback();
                        }
                        finally
                        {
                            trans.Dispose();
                        }
                    }
                }
            }
        }

        public void Delete(T item)
        {
            using (_sessionFactory)
            {
                using (_session)
                {
                    using (var trans = _session.BeginTransaction())
                    {
                        try
                        {
                            _session.Delete(item);
                            trans.Commit();
                        }
                        catch
                        {
                            trans.Rollback();
                        }
                        finally
                        {
                            trans.Dispose();
                        }
                    }
                }
            }
        }

        public T SingleBy(Expression<Func<T, bool>> query)
        {
            return _session.Query<T>().SingleOrDefault(query);
        }

        public IQueryable<T> Query()
        {
            using (_sessionFactory)
            {
                using (_session)
                {
                    return _session.Query<T>();
                }
            }
        }

        #endregion
    }
}
