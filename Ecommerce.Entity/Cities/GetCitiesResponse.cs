namespace Ecommerce.Entity.Cities
{
    public class GetCitiesResponse : Wrapper
    {
        public List<CityDTO> Result { get; set; } = [];
    }
}
