namespace Ecommerce.Entity
{
    public class Wrapper
    {
        public bool IsError { get; set; }

        public required string Message { get; set; }

        public string? ExceptionMessage { get; set; }
    }
}
