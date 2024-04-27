using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entity.States
{
    public class EditStateRequest
    {
        public Guid StateId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please Enter Only Letters")]
        public string StateName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Country")]
        public Guid CountryId { get; set; }
    }
}
