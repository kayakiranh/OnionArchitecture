using OAA.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OAA.Application.Interfaces.DomainRepositories.Dapper
{
    /// <summary>
    /// Education repository
    /// </summary>
    public interface IEducationDapperRepository 
    {
        Task<List<Education>> GetAll(string whereQuery = "", int page = 0, int pageSize = 20);
        Task<Education> GetById(int id);
        Task<Education> Insert(Education model);
        Task<Education> Update(Education model);
        Task<int> Count();
        Task<bool> Remove(int id);
        Task<bool> Truncate();
    }
}