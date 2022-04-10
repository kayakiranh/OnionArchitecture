using OAA.Domain.Entities;

namespace OAA.Application.Interfaces.EntityRepositories
{
    /// <summary>
    /// Student repository
    /// Basic operations called from generic repository, other operations must coding
    /// </summary>
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Student GetByEmail(string email);
    }
}