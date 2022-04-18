using OAA.Domain.Entities;
using System;

namespace OAA.Application.DTO.ViewModels
{
    /// <summary>
    /// Student view model
    /// </summary>
    public class StudentViewModel : IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
    }
}