namespace Ecommerce.Entity.Cities
{
    public class CityDTO : ModelBase
    {
        public required string Name { get; set; }

        public Guid StateId { get; set; }
    }
}
