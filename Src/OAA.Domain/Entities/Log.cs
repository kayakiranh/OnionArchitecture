using System;

namespace OAA.Domain.Entities
{
    /// <summary>
    /// Log table
    /// </summary>
    public class Log : IEntity
    {
        public int Id { get; set; }     
        public string Message { get; set; }
        public int Status { get; set; }
        public DateTime Created { get; set; }
    }
}