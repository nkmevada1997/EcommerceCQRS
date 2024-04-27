using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Repository.Models
{
    [Table("Cities", Schema = "dbo")]
    public class City : ModelBase
    {
        public required string Name { get; set; }

        public Guid StateId { get; set; }
    }
}
