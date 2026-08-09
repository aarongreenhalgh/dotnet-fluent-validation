using MediatR;

namespace dotnet.fluent.validation.Endpoints.Customer.Post
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, Customer>
    {
        public CreateCustomerHandler() { }

        public async Task<Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            // do something

            return request.customer;
        }
    }
}
