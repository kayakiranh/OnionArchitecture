using OAA.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OAA.Application.Interfaces.EntityRepositories
{
    /// <summary>
    /// Generic repository for all entities.
    /// </summary>
    /// <typeparam name="T">Any class that inheritences from IEntity</typeparam>
    public interface IGenericRepository<T> where T : IEntity
    {
        Task<List<T>> GetAll();
        Task<List<T>> GetAllByFilter(object filter);
        Task<List<T>> GetAllByPaging(int pageCount, int pageSize = 20);
        Task<T> GetById(int id);
        Task<T> Insert(T model);
        Task<T> Update(T model);
        Task<bool> Remove(int id);
        Task<bool> Truncate();
    }
}