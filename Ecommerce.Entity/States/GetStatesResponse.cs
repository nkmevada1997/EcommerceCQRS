namespace Ecommerce.Entity.States
{
    public class GetStatesResponse : Wrapper
    {
        public List<StateDTO> Result { get; set; } = [];
    }
}
