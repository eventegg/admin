using System;
using System.Collections.Generic;
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
                Console.WriteLine("TYPE: " + typeof(T));

                var config = Fluently.Configure()
                       .Database(MsSqlConfiguration.MsSql2008.ConnectionString(c => c.FromConnectionStringWithKey("ConnectionString")))
                       .Mappings(m => m.FluentMappings.AddFromAssemblyOf<T>())
                       .BuildConfiguration();

                Console.WriteLine("DED: " + typeof(T));
                _sessionFactory = config.BuildSessionFactory();

                _session = _sessionFactory.OpenSession();
                _session.FlushMode = FlushMode.Commit;
                
                Console.WriteLine("SESSION:" + _session.IsOpen);
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA: " + ex.Message + "-" + ex.InnerException.Message);
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

        public IList<T> List()
        {
            var list = _session.Query<T>().ToList();

            return list;
        }

        public IList<T> ListBy(Expression<Func<T, bool>> query)
        {
            return _session.Query<T>().Where(query).ToList();
        }

        #endregion
    }
}
