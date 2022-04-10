using OAA.Domain.Entities;
using System.Collections.Generic;

namespace OAA.Application.Interfaces.LoggerRepositories
{
    /// <summary>
    /// File Log repository
    /// Basic operations called from generic repository, other operations must coding
    /// </summary>
    public interface IFileLoggerRepository
    {
        List<Log> Read();
        void Write(Log model);        
    }
}