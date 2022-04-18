using OAA.Application.Interfaces.DomainRepositories.Dapper;
using OAA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAA.Infrastructure.Persistance.Mssql.Dapper
{
    public class StudentRepository : IStudentDapperRepository
    {
        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetAll(string whereQuery = "", int page = 0, int pageSize = 20)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> Insert(Student model)
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

        public Task<Student> Update(Student model)
        {
            throw new NotImplementedException();
        }
    }
}
