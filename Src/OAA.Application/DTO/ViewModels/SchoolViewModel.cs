using OAA.Domain.Entities;

namespace OAA.Application.DTO.ViewModels
{
    /// <summary>
    /// School view model
    /// </summary>
    public class SchoolViewModel : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TypeName { get; set; }
    }
}