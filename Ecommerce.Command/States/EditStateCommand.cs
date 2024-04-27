using Ecommerce.Entity.Cities;
using MediatR;

namespace Ecommerce.Command.States
{
    public class EditStateCommand(Guid id, string name, Guid countryId) : IRequest<EditCityResponse>
    {
        public Guid Id { get; private set; } = id;
        public string Name { get; private set; } = name;
        public Guid CountryId { get; private set; } = countryId;
    }
}
