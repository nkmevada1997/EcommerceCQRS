using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entity.Suppliers
{
    public class EditSupplierRequest
    {
        public Guid SupplierId { get; set; }

        [Required(ErrorMessage = "Supplier Name Is Required.")]
        [Display(Name = "Supplier Name")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please Enter Only Letters")]
        [DataType(DataType.Text)]
        [MaxLength((20))]
        public string SupplierName { get; set; } = string.Empty;

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country Is Required.")]
        public Guid CountryId { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "State Is Required.")]
        public Guid StateId { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City Is Required.")]
        public Guid CityId { get; set; }
    }
}
