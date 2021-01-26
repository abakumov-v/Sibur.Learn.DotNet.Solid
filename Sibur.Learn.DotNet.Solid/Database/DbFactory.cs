using Sibur.Learn.DotNet.Solid.Database.Abstract;

namespace Sibur.Learn.DotNet.Solid.Database
{
    public class DbFactory : IDbFactory
    {
        public IDatabase CreateTransactional()
        {
            throw new System.NotImplementedException();
        }

        public IDatabase Create()
        {
            throw new System.NotImplementedException();
        }
    }
}