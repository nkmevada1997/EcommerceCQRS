using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Repository.Models
{
    [Table("Suppliers", Schema = "dbo")]
    public class Supplier : ModelBase
    {
        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }

        public Guid CountryId { get; set; }

        public Guid StateId { get; set; }

        public Guid CityId { get; set; }
    }
}
