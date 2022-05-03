using OnionArchitecture.Domain.Common;

namespace OnionArchitecture.Domain.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
