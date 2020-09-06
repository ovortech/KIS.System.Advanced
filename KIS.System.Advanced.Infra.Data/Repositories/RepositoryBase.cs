using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected ProjetoDataContext Db = new ProjetoDataContext();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
