using System;
using System.Threading;
using System.Threading.Tasks;
using MediatorPattern.Domain.Customer.Command;
using MediatR;
using Microsoft.Extensions.Logging;

namespace MediatorPattern.EventsHandlers
{
    public class TelegramHandler : INotificationHandler<CustomerCreateActionNotification>
    {
        private readonly ILogger<TelegramHandler> _logger;

        public TelegramHandler(ILogger<TelegramHandler> logger)
            => _logger = logger;

        public Task Handle(CustomerCreateActionNotification notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("[Telegram] O cliente {0} {1} de código {2} foi criado com sucesso", notification.FirstName,
                notification.LastName, notification.Id);

            return Task.CompletedTask;
        }
    }
}