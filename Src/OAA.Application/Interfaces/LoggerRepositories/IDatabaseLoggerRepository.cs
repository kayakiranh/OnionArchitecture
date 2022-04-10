using OAA.Application.Interfaces.EntityRepositories;
using OAA.Domain.Entities;

namespace OAA.Application.Interfaces.LoggerRepositories
{
    /// <summary>
    /// Database log repository
    /// Basic operations called from generic repository, other operations must coding
    /// </summary>
    public interface IDatabaseLoggerRepository : IGenericRepository<Log> { }
}