namespace dotnet.fluent.validation.Endpoints.Customer
{
    public class Customer
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public int HouseNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string Postcode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
    }
}
