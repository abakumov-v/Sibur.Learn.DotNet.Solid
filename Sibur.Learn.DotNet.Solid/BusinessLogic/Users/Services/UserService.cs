using System.Threading.Tasks;
using Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Factories;
using Sibur.Learn.DotNet.Solid.Database;
using Sibur.Learn.DotNet.Solid.Database.Abstract;
using Sibur.Learn.DotNet.Solid.Models;

namespace Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Services
{
    public class UserService : IUserService
    {
        private readonly IDbFactory _dbFactory;
        private readonly IUserFactory _userFactory;

        public UserService()
        {
            _dbFactory = new DbFactory();
            _userFactory = new UserFactory();
        }

        public async Task<User> GetUserAsync(int id)
        {
            using (var db = _dbFactory.Create())
            {
                var foundUser = await db.Users.GetByIdAsync(id);
                return foundUser;
            }
        }

        public async Task CreateAsync(User newUser)
        {
            using (var db = _dbFactory.CreateTransactional())
            {
                var creatingUser = _userFactory.Create(newUser.FullName);
                await db.Users.CreateAsync(creatingUser);
                await db.CommitAsync();
            }
        }

        public async Task Lock(int id)
        {
            using (var db = _dbFactory.CreateTransactional())
            {
                await db.Users.LockAsync(id);
                await db.CommitAsync();
            }
        }
    }
}