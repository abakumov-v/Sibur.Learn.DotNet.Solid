﻿using Sibur.Learn.DotNet.Solid.Models;

namespace Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Factories.Decorated
{
    public class AdminUserFactory : IUserFactory
    {
        private readonly IUserFactory _userFactory;

        public AdminUserFactory()
        {
            _userFactory = new UserFactory();
        }

        public User Create(string fullName)
        {
            var user = _userFactory.Create(fullName);
            user.IsAdmin = true;
            return user;
        }
    }
}