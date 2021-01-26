using System.Threading.Tasks;
using Sibur.Learn.DotNet.Solid.Database;
using Sibur.Learn.DotNet.Solid.Database.Abstract;
using Sibur.Learn.DotNet.Solid.Models;

namespace Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Cqrs.Queries.UserById
{
    public class UserByIdQueryHandler
    {
        private readonly IDbFactory _dbFactory;

        public UserByIdQueryHandler()
        {
            _dbFactory = new DbFactory();
        }

        public async Task<User> HandleAsync(UserByIdQuery request)
        {
            using (var db = _dbFactory.Create())
            {
                var foundUser = await db.Users.GetByIdAsync(request.Id);
                return foundUser;
            }
        }
    }
}