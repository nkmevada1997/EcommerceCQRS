namespace Ecommerce.Entity.Suppliers
{
    public class GetSuppliersResponse : Wrapper
    {
        public List<SupplierDTO> Result { get; set; } = [];
    }
}
