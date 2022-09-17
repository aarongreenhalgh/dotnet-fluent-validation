using dotnet.fluent.validation.Endpoints.Customer.Post;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.fluent.validation.Endpoints.Customer
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator) => _mediator = mediator;

        [HttpPost]
        public async Task<ActionResult> AddCustomer([FromBody] Customer customer)
        {
            var productToReturn = await _mediator.Send(new CreateCustomerCommand(customer));

            return CreatedAtRoute(new { id = productToReturn.Id }, productToReturn);
        }
    }
}
