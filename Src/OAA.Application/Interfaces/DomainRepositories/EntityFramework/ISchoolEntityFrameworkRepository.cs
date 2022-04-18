using OAA.Domain.Entities;

namespace OAA.Application.Interfaces.DomainRepositories.EntityFramework
{
    /// <summary>
    /// School repository
    /// Basic operations called from generic repository, other operations must coding
    /// </summary>
    public interface ISchoolEntityFrameworkRepository : IGenericEntityFrameworkRepository<School> { }
}