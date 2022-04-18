using OAA.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OAA.Application.Interfaces.DomainRepositories.Dapper
{
    /// <summary>
    /// Student repository
    /// </summary>
    public interface IStudentDapperRepository
    {
        Task<List<Student>> GetAll(string whereQuery = "", int page = 0, int pageSize = 20);
        Task<Student> GetByEmail(string email);
        Task<Student> GetById(int id);
        Task<Student> Insert(Student model);
        Task<Student> Update(Student model);
        Task<int> Count();
        Task<bool> Remove(int id);
        Task<bool> Truncate();
    }
}