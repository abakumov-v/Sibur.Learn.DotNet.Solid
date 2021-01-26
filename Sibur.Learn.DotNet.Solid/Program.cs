using System;
using Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Factories;
using Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Services;

namespace Sibur.Learn.DotNet.Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new SimpleDependencyProvider();
            provider.AddSingleton(typeof(IUserFactory), typeof(UserFactory));
            provider.AddTransient(typeof(IUserService), typeof(UserService));

            var userService = provider.TryGet<IUserService>();

            Console.WriteLine("Hello World!");
        }
    }
}