using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Contexto;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.Core;
using KIS.System.Advanced.Domain.Entities;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : ExclusaoLogica
    {
        List<string> NotRemoveLogic = new List<string> { "Pedido", "PedidoCancelamento" };
        public ProjetoDataContext Db { get; private set; }

        public RepositoryBase(ProjetoDataContext db = null)
        {
            Db = db ?? new ProjetoDataContext();
        }

        public TEntity Add(TEntity obj)
        {
            if (!NotRemoveLogic.Contains(typeof(TEntity).Name))
                ((ExclusaoLogica)obj).ATIVO = true;

            var result = Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
            return result;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> GetAllAtivos()
        {
            if (NotRemoveLogic.Contains(typeof(TEntity).Name))
                return GetAll();
            return Db.Set<TEntity>().ToList().Where(x => ((ExclusaoLogica)x).ATIVO == true);
        }

        public IEnumerable<TEntity> GetAllInativos()
        {
            if (NotRemoveLogic.Contains(typeof(TEntity).Name))
                return new List<TEntity>();
            return Db.Set<TEntity>().ToList().Where(x => ((ExclusaoLogica)x).ATIVO == false);
        }

        public void RemoveLogic(int id)
        {
            if (NotRemoveLogic.Contains(typeof(TEntity).Name))
                return;

            var obj = GetById(id);
            ((ExclusaoLogica)obj).ATIVO = false;
            Update(obj);
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
