namespace Ecommerce.Entity.Countries
{
    public class GetCountriesResponse : Wrapper
    {
        public List<CountryDTO> Result { get; set; } = [];
    }
}
