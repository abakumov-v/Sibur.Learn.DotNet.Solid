namespace Sibur.Learn.DotNet.Solid.Database.Abstract
{
    public interface IDbFactory
    {
        IDatabase CreateTransactional();
        IDatabase Create();
    }
}