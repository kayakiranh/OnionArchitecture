using System;

namespace OAA.Domain.Entities
{
    /// <summary>
    /// Student table
    /// </summary>
    public class Student : IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime Created { get; set; }
    }
}