using OAA.Domain.Entities;
using System.Collections.Generic;

namespace OAA.Application.Interfaces.EntityRepositories
{
    /// <summary>
    /// Generic repository for all entities.
    /// </summary>
    /// <typeparam name="T">Any class that inheritences from IEntity</typeparam>
    public interface IGenericRepository<T> where T : IEntity
    {
        List<T> GetAll();
        List<T> GetAllByFilter(object filter);
        List<T> GetAllByPaging(int pageCount, int pageSize = 20);
        T GetById(int id);
        T Insert(T model);
        T Update(T model);
        bool Remove(int id);
        bool Truncate();
    }
}