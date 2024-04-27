using Ecommerce.Command.Countries;
using Ecommerce.Entity.Countries;
using Ecommerce.Interface.Countries;
using MediatR;

namespace Ecommerce.Handler.Counties
{
    public class AddCountryHandler(ICountryService service) : IRequestHandler<AddCountryCommand, AddCountryResponse>
    {
        readonly ICountryService _service = service;

        public async Task<AddCountryResponse> Handle(AddCountryCommand command, CancellationToken cancellationToken)
        {
            return await _service.AddCountryAsync(new AddCountryRequest
            {
                Name = command.Name,
            });
        }
    }
}
