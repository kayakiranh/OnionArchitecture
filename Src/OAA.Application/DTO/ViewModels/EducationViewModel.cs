using OAA.Domain.Entities;

namespace OAA.Application.DTO.ViewModels
{
    public class EducationViewModel : IEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
    }
}