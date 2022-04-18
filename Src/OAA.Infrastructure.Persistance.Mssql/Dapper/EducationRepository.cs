using OAA.Application.Interfaces.DomainRepositories.Dapper;
using OAA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAA.Infrastructure.Persistance.Mssql.Dapper
{
    public class EducationRepository : IEducationDapperRepository
    {
        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public Task<List<Education>> GetAll(string whereQuery = "", int page = 0, int pageSize = 20)
        {
            throw new NotImplementedException();
        }

        public Task<Education> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Education> Insert(Education model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Truncate()
        {
            throw new NotImplementedException();
        }

        public Task<Education> Update(Education model)
        {
            throw new NotImplementedException();
        }
    }
}
