using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entity.Cities
{
    public class EditCityRequest
    {
        public Guid CityId { get; set; }
        [Required]
        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please Enter Only Letters")]
        public string CityName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "State")]
        public Guid StateId { get; set; }
    }
}
