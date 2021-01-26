using System.Threading.Tasks;
using Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Factories;
using Sibur.Learn.DotNet.Solid.Database;
using Sibur.Learn.DotNet.Solid.Database.Abstract;

namespace Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Cqrs.Commands.CreateUser
{
    public class CreateUserCommandHandler
    {
        private readonly IDbFactory _dbFactory;
        private readonly IUserFactory _userFactory;

        public CreateUserCommandHandler()
        {
            _dbFactory = new DbFactory();
            _userFactory = new UserFactory();
        }

        public async Task HandleAsync(CreateUserCommand request)
        {
            using (var db = _dbFactory.CreateTransactional())
            {
                var creatingUser = _userFactory.Create(request.FullName);
                await db.Users.CreateAsync(creatingUser);
                await db.CommitAsync();
            }
        }
    }
}