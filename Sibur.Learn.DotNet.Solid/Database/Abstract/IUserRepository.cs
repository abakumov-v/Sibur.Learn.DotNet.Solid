using System.Threading.Tasks;
using Sibur.Learn.DotNet.Solid.Models;

namespace Sibur.Learn.DotNet.Solid.Database.Abstract
{
    public interface IUserRepository
    {
        Task CreateAsync(User creatingUser);
        Task LockAsync(int userId);
        Task<User> GetByIdAsync(int id);
    }
}