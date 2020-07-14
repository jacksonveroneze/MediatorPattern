using System;
using MediatorPattern.Domain.Customer.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediatorPattern.Infra
{
    public interface ICustomerRepository
    {
        Task Save(CustomerEntity customer);

        Task Update(Guid id, CustomerEntity customer);

        Task Delete(Guid id);

        Task<CustomerEntity> GetById(Guid id);

        Task<IEnumerable<CustomerEntity>> GetAll();
    }
}