using ACHStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ACHStore.DataAccess.Interfaces
{
   public interface IRepository<T> where T : Entity
    {
        void Add(T entity);
        void Add(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        T GetByID(int ID);
        IQueryable<T> Search(Expression<Func<T, bool>> predicate, List<string> includedProperties);
        IQueryable<T> GetAll();
    }
}
