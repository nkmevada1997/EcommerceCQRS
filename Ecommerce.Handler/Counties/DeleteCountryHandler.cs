using Ecommerce.Command.Countries;
using Ecommerce.Entity.Countries;
using Ecommerce.Interface.Countries;
using MediatR;

namespace Ecommerce.Handler.Counties
{
    public class DeleteCountryHandler(ICountryService service) : IRequestHandler<DeleteCountryCommand, DeleteCountryResponse>
    {
        readonly ICountryService _service = service;

        public async Task<DeleteCountryResponse> Handle(DeleteCountryCommand command, CancellationToken cancellationToken)
        {
            return await _service.DeleteCountryAsync(command.Id);
        }
    }
}
