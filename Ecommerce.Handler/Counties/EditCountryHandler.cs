using Ecommerce.Command.Countries;
using Ecommerce.Entity.Countries;
using Ecommerce.Interface.Countries;
using MediatR;

namespace Ecommerce.Handler.Counties
{
    public class EditCountryHandler(ICountryService service) : IRequestHandler<EditCountryCommand, EditCountryResponse>
    {
        readonly ICountryService _service = service;

        public async Task<EditCountryResponse> Handle(EditCountryCommand command, CancellationToken cancellationToken)
        {
            return await _service.EditCountryAsync(command.Id, new EditCountryRequest
            {
                Name = command.Name,
            });
        }
    }
}
