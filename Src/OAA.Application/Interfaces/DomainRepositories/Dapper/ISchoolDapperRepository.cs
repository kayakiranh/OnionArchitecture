using OAA.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OAA.Application.Interfaces.DomainRepositories.Dapper
{
    /// <summary>
    /// School repository
    /// </summary>
    public interface ISchoolDapperRepository
    {
        Task<List<School>> GetAll(string whereQuery = "", int page = 0, int pageSize = 20);
        Task<School> GetById(int id);
        Task<School> Insert(School model);
        Task<School> Update(School model);
        Task<int> Count();
        Task<bool> Remove(int id);
        Task<bool> Truncate();
    }
}