using Sibur.Learn.DotNet.Solid.Models;
using Sibur.Learn.DotNet.Solid.Models.Abstract;

namespace Sibur.Learn.DotNet.Solid.Database
{
    public class Repository
    {
        public void Save(BaseEntity entity)
        {
            if (entity is User)
            {
                // специфические действия для User
                // очень много кода
                // ...
            }

            if (entity is Cart)
            {
                // специфические действия для Cart
                // очень много кода
                // ...
            }
        }
    }
}