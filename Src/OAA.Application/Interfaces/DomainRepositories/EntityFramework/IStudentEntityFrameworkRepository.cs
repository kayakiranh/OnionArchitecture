using OAA.Domain.Entities;

namespace OAA.Application.Interfaces.DomainRepositories.EntityFramework
{
    /// <summary>
    /// Student repository
    /// Basic operations called from generic repository, other operations must coding
    /// </summary>
    public interface IStudentEntityFrameworkRepository : IGenericEntityFrameworkRepository<Student>
    {
        Student GetByEmail(string email);
    }
}