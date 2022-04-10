using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace OAA.Application
{
    /// <summary>
    /// Application layer dependency resolver
    /// </summary>
    public static class ApplicationDependencyResolver
    {
        public static void Injector(this IServiceCollection serviseCollection) 
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            serviseCollection.AddAutoMapper(assembly);
            serviseCollection.AddMediatR(assembly);
        }
    }
}