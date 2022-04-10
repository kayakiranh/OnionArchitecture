using System;

namespace OAA.Domain.Entities
{
    /// <summary>
    /// School table
    /// </summary>
    public class School : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Type { get; set; }
        public DateTime Created { get; set; }
    }
}