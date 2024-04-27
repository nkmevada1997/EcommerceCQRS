using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entity.States
{
    public class AddStateRequest
    {
        [Required(ErrorMessage = "State is Required")]
        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please Enter Only Letters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country Is Required")]
        [Display(Name = "Country")]
        public Guid? CountryId { get; set; }
    }
}
