using Sibur.Learn.DotNet.Solid.Models.Abstract;

namespace Sibur.Learn.DotNet.Solid.Models
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
    }
}