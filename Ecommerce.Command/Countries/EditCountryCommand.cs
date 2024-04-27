using Ecommerce.Entity.Countries;
using MediatR;

namespace Ecommerce.Command.Countries
{
    public class EditCountryCommand(Guid id, string name) : IRequest<EditCountryResponse>
    {
        public Guid Id { get; set; } = id;
        public string Name { get; private set; } = name;
    }
}
