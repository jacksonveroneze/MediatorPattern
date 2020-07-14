using System;

namespace MediatorPattern.Domain.Customer.Entity
{
    public class CustomerEntity
    {
        public CustomerEntity(string firstName, string lastName, string email, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }

        public Guid Id { get; } = Guid.NewGuid();

        public string FirstName { get; }

        public string LastName { get; }

        public string Email { get; }

        public string Phone { get; }
    }
}