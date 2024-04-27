namespace Ecommerce.Entity.States
{
    public class StateDTO : ModelBase
    {
        public required string Name { get; set; }

        public Guid CountryId { get; set; }
    }
}
