using ACHStore.DataAccess.Interfaces;
using ACHStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ACHStore.DataAccess.Handlers
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Search(Expression<Func<T, bool>> predicate, List<string> includedProperties)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
