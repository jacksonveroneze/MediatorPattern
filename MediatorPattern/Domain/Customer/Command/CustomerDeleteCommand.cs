using System;
using MediatR;

namespace MediatorPattern.Domain.Customer.Command
{
    public class CustomerDeleteCommand : IRequest<CustomerResult>
    {
        public Guid Id { get; set; }
    }
}
