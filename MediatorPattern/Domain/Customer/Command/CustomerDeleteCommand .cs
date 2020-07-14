using MediatR;

namespace MediatorPattern.Domain.Customer.Command
{
    public class CustomerDeleteCommand : IRequest
    {
        public int Id { get; set; }
    }
}
