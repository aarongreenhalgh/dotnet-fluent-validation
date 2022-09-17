using MediatR;

namespace dotnet.fluent.validation.Endpoints.Customer.Post
{
    public record CreateCustomerCommand(Customer customer) : IRequest<Customer>;

}
