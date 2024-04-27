using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entity.Countries
{
    public class AddCountryRequest
    {
        [Required]
        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please Enter Only Letters")]
        public string Name { get; set; } = string.Empty;
    }
}
