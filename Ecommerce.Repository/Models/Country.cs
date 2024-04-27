using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Repository.Models
{
    [Table("Countries", Schema = "dbo")]
    public class Country : ModelBase
    {
        public required string Name { get; set; }
    }
}
