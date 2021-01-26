using Sibur.Learn.DotNet.Solid.Models;

namespace Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Factories
{
    public class UserFactory : IUserFactory
    {
        public User Create(string fullName)
        {
            return new User()
            {
                FullName = fullName
            };
        }
    }
}