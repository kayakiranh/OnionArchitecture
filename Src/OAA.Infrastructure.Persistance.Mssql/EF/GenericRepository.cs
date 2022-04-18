using OAA.Application.Interfaces.DomainRepositories.EntityFramework;
using OAA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAA.Infrastructure.Persistance.Mssql.EF
{
    public class GenericRepository<T> : IGenericEntityFrameworkRepository<T> where T : IEntity
    {

        public Task<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllByFilter(object whereQuery, int page = 0, int pageSize = 20)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Insert(T model)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Truncate()
        {
            throw new NotImplementedException();
        }
    }
}