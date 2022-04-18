using OAA.Application.Interfaces.DomainRepositories.Dapper;
using OAA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAA.Infrastructure.Persistance.Mssql.Dapper
{
    public class SchoolRepository : ISchoolDapperRepository
    {
        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public Task<List<School>> GetAll(string whereQuery = "", int page = 0, int pageSize = 20)
        {
            throw new NotImplementedException();
        }

        public Task<School> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<School> Insert(School model)
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

        public Task<School> Update(School model)
        {
            throw new NotImplementedException();
        }
    }
}
