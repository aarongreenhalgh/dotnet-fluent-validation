using FluentValidation;

namespace dotnet.fluent.validation.Endpoints.Customer.Post
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(x => x.customer).NotNull().NotEmpty();
            RuleFor(x => x.customer.Id).GreaterThan(0);
            RuleFor(x => x.customer.Forename).NotNull();
            RuleFor(x => x.customer.Surname).NotNull();
            RuleFor(x => x.customer.DOB).LessThan(DateTime.Now);
            RuleFor(x => x.customer.Address).NotNull().NotEmpty();
            RuleFor(x => x.customer.Address.HouseNumber).GreaterThan(0);
            RuleFor(x => x.customer.Address.AddressLine1).NotNull().NotEmpty();
            RuleFor(x => x.customer.Address.AddressLine2).NotNull().NotEmpty();
            RuleFor(x => x.customer.Address.AddressLine3).NotNull().NotEmpty();
            RuleFor(x => x.customer.Address.AddressLine4).NotNull().NotEmpty();
            RuleFor(x => x.customer.Address.Postcode).NotNull().NotEmpty();
            RuleFor(x => x.customer.Address.County).NotNull().NotEmpty();
            RuleFor(x => x.customer.Address.Country).NotNull().NotEmpty();
        }
    }
}
