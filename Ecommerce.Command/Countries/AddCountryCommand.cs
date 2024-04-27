using Ecommerce.Entity.Countries;
using MediatR;

namespace Ecommerce.Command.Countries
{
    public class AddCountryCommand(string name) : IRequest<AddCountryResponse>
    {
        public string Name { get; private set; } = name;
    }
}
