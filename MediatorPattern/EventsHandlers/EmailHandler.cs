using System;
using System.Threading;
using System.Threading.Tasks;
using MediatorPattern.Domain.Customer.Command;
using MediatR;
using Microsoft.Extensions.Logging;

namespace MediatorPattern.EventsHandlers
{
    public class EmailHandler : INotificationHandler<CustomerCreateActionNotification>, INotificationHandler<CustomerUpdateActionNotification>
    {
        private readonly ILogger<EmailHandler> _logger;

        public EmailHandler(ILogger<EmailHandler> logger)
            => _logger = logger;

        public Task Handle(CustomerCreateActionNotification notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("[E-mail] O cliente {0} {1} de código {2} foi criado com sucesso", notification.FirstName,
                notification.LastName, notification.Id);

            return Task.CompletedTask;
        }

        public Task Handle(CustomerUpdateActionNotification notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("[E-mail] O cliente {0} {1} de código {2} foi atualizado com sucesso", notification.FirstName,
                notification.LastName, notification.Id);

            return Task.CompletedTask;
        }
    }
}