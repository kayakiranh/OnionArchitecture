using System.Collections.Generic;

namespace OAA.Application.Interfaces.LoggerRepositories
{
    /// <summary>
    /// File Log repository
    /// </summary>
    public interface IFileLoggerRepository
    {
        List<string> Read();
        void Write(string log);        
    }
}