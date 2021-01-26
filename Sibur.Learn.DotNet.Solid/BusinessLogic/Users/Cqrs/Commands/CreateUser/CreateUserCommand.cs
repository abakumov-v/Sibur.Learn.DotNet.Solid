using System;

namespace Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Cqrs.Commands.CreateUser
{
    public class CreateUserCommand
    {
        public string FullName { get; }

        public CreateUserCommand(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentNullException(nameof(fullName), "Требуется указать имя пользователя");

            FullName = fullName;
        }
    }
}