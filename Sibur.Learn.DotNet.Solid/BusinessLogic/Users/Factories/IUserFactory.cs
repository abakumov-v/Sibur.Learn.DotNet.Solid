using Sibur.Learn.DotNet.Solid.Models;

namespace Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Factories
{
    public interface IUserFactory
    {
        User Create(string fullName);
    }
}