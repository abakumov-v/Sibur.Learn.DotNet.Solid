using System.Threading.Tasks;
using Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Factories;
using Sibur.Learn.DotNet.Solid.Database;
using Sibur.Learn.DotNet.Solid.Database.Abstract;

namespace Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Cqrs.Commands.Lock
{
    public class LockUserCommandHandler
    {
        private readonly IDbFactory _dbFactory;
        private readonly IUserFactory _userFactory;

        public LockUserCommandHandler()
        {
            _dbFactory = new DbFactory();
            _userFactory = new UserFactory();
        }

        public async Task HandleAsync(LockUserCommand request)
        {
            using (var db = _dbFactory.CreateTransactional())
            {
                await db.Users.LockAsync(request.UserId);
                await db.CommitAsync();
            }
        }
    }
}