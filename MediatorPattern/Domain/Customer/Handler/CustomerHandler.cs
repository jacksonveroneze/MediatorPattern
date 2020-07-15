using MediatorPattern.Domain.Customer.Command;
using MediatorPattern.Domain.Customer.Entity;
using MediatorPattern.Infra;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorPattern.Domain.Customer.Handler
{
    public class CustomerHandler :
        IRequestHandler<CustomerCreateCommand, CustomerResult>,
        IRequestHandler<CustomerUpdateCommand, CustomerResult>,
        IRequestHandler<CustomerDeleteCommand, CustomerResult>
    {
        private readonly IMediator _mediator;
        private readonly ICustomerRepository _customerRepository;
        public CustomerHandler(IMediator mediator, ICustomerRepository customerRepository)
        {
            _mediator = mediator;
            _customerRepository = customerRepository;
        }

        public async Task<CustomerResult> Handle(CustomerCreateCommand request, CancellationToken cancellationToken)
        {
            CustomerEntity customer = new CustomerEntity(request.FirstName, request.LastName, request.Email, request.Phone);

            await _customerRepository.Save(customer);

            await _mediator.Publish(new CustomerCreateActionNotification(customer.Id, customer.FirstName,
                customer.LastName, customer.Email));

            return new CustomerResult();
        }

        public async Task<CustomerResult> Handle(CustomerUpdateCommand request, CancellationToken cancellationToken)
        {
            CustomerEntity customer = new CustomerEntity(request.FirstName, request.LastName, request.Email, request.Phone);

            await _customerRepository.Update(request.Id, customer);

            await _mediator.Publish(new CustomerUpdateActionNotification(customer.Id, customer.FirstName,
                customer.LastName, customer.Email));

            return new CustomerResult();
        }

        public async Task<CustomerResult> Handle(CustomerDeleteCommand request, CancellationToken cancellationToken)
        {
            CustomerEntity client = await _customerRepository.GetById(request.Id);

            await _customerRepository.Delete(client.Id);

            await _mediator.Publish(new CustomerDeleteActionNotification(client.Id));

            return new CustomerResult();
        }
    }
}