using System;
using MediatR;

namespace MediatorPattern.Domain.Customer.Command
{
    public class CustomerUpdateActionNotification : INotification
    {
        public CustomerUpdateActionNotification(Guid id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public Guid Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public string Email { get; }
    }
}