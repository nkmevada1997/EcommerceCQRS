namespace Ecommerce.Entity.Suppliers
{
    public class SupplierDTO : ModelBase
    {
        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }

        public Guid CountryId { get; set; }

        public Guid StateId { get; set; }

        public Guid CityId { get; set; }
    }
}
