using System;

namespace Sibur.Learn.DotNet.Solid.BusinessLogic.Users.Cqrs.Queries.UserById
{
    public class UserByIdQuery
    {
        public int Id { get; }

        public UserByIdQuery(int userId)
        {
            if (userId <= 0)
                throw new ArgumentNullException(nameof(userId), "Требуется указать ID пользователя");

            Id = userId;
        }
    }
}