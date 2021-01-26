using System.Threading.Tasks;
using Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Factories;
using Sibur.Learn.DotNet.Solid.Database;
using Sibur.Learn.DotNet.Solid.Database.Abstract;
using Sibur.Learn.DotNet.Solid.Models;

namespace Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Services
{
    public class AdminUserService : IUserService
    {
        private readonly IDbFactory _dbFactory;
        private readonly IUserFactory _userFactory;

        public AdminUserService()
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

        public Task CreateAsync(User newUser)
        {
            throw new System.NotImplementedException();
        }

        public Task Lock(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}