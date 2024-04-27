using Ecommerce.Entity.States;
using MediatR;

namespace Ecommerce.Command.States
{
    public class AddStateCommand(string name, Guid countryId) : IRequest<AddStateResponse>
    {
        public string Name { get; private set; } = name;

        public Guid CountryId { get; private set; } = countryId;
    }
}
