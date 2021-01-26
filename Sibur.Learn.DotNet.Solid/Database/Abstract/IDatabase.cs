using System;
using System.Threading.Tasks;

namespace Sibur.Learn.DotNet.Solid.Database.Abstract
{
    public interface IDatabase : IDisposable
    {
        IUserRepository Users { get; }
        
        Task CommitAsync();
    }
}