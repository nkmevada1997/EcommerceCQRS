using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Repository.Models
{
    public class Customer : ModelBase
    {
        public required string FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime DOB { get; set; }

        public required string Gender { get; set; }

        public required string Email { get; set; }

        public required string PhoneNumber { get; set; }

        public required string Password { get; set; }

        public Guid CountryId { get; set; }

        public Guid StateId { get; set; }

        public Guid CityId { get; set; }
    }
}
