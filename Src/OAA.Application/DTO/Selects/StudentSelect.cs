using OAA.Domain.Entities;

namespace OAA.Application.DTO.Selects
{
    /// <summary>
    /// Student Select
    /// </summary>
    public class StudentSelect : IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }
}