using System;

namespace OAA.Domain.Entities
{
    /// <summary>
    /// Education table
    /// Create relationship for students and schools
    /// </summary>
    public class Education : IEntity
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public virtual School School { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public DateTime Created { get; set; }
    }
}