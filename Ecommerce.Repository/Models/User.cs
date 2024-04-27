using Ecommerce.Utility.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Repository.Models
{
    [Table("Users", Schema = "dbo")]
    public class User : ModelBase
    {
        public required string UserName { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }

        public UserType UserType { get; set; }

        public bool CanLogin { get; set; } = true;

        public Guid? CustomerId { get; set; }

        public Guid? SupplierId { get; set; }

    }
}
