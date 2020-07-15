using System;
using MediatR;

namespace MediatorPattern.Domain.Customer.Command
{
    public class CustomerDeleteActionNotification : INotification
    {
        public CustomerDeleteActionNotification(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}