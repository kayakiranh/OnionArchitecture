using OAA.Domain.Entities;

namespace OAA.Application.Interfaces.EntityRepositories
{
    /// <summary>
    /// Education repository
    /// Basic operations called from generic repository, other operations must coding
    /// </summary>
    public interface IEducationRepository : IGenericRepository<Education> { }
}