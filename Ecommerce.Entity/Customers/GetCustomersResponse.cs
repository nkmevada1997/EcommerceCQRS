namespace Ecommerce.Entity.Customers
{
    public class GetCustomersResponse : Wrapper
    {
        public List<CustomerDTO> Result { get; set; } = [];
    }
}
