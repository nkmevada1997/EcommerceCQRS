using Ecommerce.Command.Countries;
using Ecommerce.Entity.Countries;
using Ecommerce.Query.Countries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CountriesController(IMediator mediator) : ControllerBase
    {
        readonly IMediator _mediator = mediator;

        [HttpPost("add-country")]
        public async Task<IActionResult> AddCountry(AddCountryRequest request)
        {
            var resonse = await _mediator.Send(new AddCountryCommand(request.Name));
            return Ok(resonse);
        }

        [HttpGet("get-countries")]
        public async Task<IActionResult> GetCountries()
        {
            var resonse = await _mediator.Send(new GetCountriesQuery());
            return Ok(resonse);
        }

        [HttpGet("get-country-detail/{id}")]
        public async Task<IActionResult> GetCountryDetail(Guid id)
        {
            var resonse = await _mediator.Send(new GetCountryDetailQuery(id));
            return Ok(resonse);
        }

        [HttpPut("update-country/{id}")]
        public async Task<IActionResult> UpdateCountry(Guid id, EditCountryRequest request)
        {
            var resonse = await _mediator.Send(new EditCountryCommand(id, request.Name));
            return Ok(resonse);
        }

        [HttpDelete("delete-country/{id}")]
        public async Task<IActionResult> DeleteCountry(Guid id)
        {
            var resonse = await _mediator.Send(new DeleteCountryCommand(id));
            return Ok(resonse);
        }

    }
}
