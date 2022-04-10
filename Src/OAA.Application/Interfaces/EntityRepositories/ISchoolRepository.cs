using OAA.Domain.Entities;

namespace OAA.Application.Interfaces.EntityRepositories
{
    /// <summary>
    /// School repository
    /// Basic operations called from generic repository, other operations must coding
    /// </summary>
    public interface ISchoolRepository : IGenericRepository<School> { }
}