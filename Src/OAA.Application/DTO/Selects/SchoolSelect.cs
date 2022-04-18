using OAA.Domain.Entities;

namespace OAA.Application.DTO.Selects
{
    /// <summary>
    /// School Select
    /// </summary>
    public class SchoolSelect : IEntity
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
    }
}