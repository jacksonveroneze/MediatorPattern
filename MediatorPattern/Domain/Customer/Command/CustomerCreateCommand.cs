using MediatR;

namespace MediatorPattern.Domain.Customer.Command
{
    public class CustomerCreateCommand : IRequest<CustomerResult>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}