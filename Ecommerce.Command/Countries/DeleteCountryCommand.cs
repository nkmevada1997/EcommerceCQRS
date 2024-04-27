using Ecommerce.Entity.Countries;
using MediatR;

namespace Ecommerce.Command.Countries
{
    public class DeleteCountryCommand(Guid id) : IRequest<DeleteCountryResponse>
    {
        public Guid Id { get; private set; } = id;
    }
}
