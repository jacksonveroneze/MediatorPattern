using System;
using MediatR;

namespace MediatorPattern.Domain.Customer.Command
{
    public class CustomerDeleteCommand : IRequest<string>
    {
        public Guid Id { get; set; }
    }
}
