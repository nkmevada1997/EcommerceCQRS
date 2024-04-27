using Ecommerce.Entity.Countries;
using Ecommerce.Interface.Countries;
using Ecommerce.Query.Countries;
using MediatR;

namespace Ecommerce.Handler.Counties
{
    public class GetCountryDetailHandler(ICountryService service) : IRequestHandler<GetCountryDetailQuery, GetCountryDetailResponse>
    {
        readonly ICountryService _service = service;

        public async Task<GetCountryDetailResponse> Handle(GetCountryDetailQuery query, CancellationToken cancellationToken)
        {
            return await _service.GetCountryDetailAsync(query.Id);
        }
    }
}
