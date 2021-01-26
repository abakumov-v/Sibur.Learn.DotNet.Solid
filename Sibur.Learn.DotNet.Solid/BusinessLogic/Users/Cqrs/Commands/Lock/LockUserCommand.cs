using System;

namespace Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Cqrs.Commands.Lock
{
    public class LockUserCommand
    {
        public int UserId { get; }

        public LockUserCommand(int userId)
        {
            if (userId <= 0)
                throw new ArgumentNullException(nameof(userId), "Требуется указать ID пользователя");

            UserId = userId;
        }
    }
}