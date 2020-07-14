using System;
using System.Threading;
using System.Threading.Tasks;
using MediatorPattern.Notifications;
using MediatR;

namespace MediatorPattern.EventsHandlers
{
    public class EmailHandler : INotification<CustomerActionNotification>
    {
        public Task Handle(CustomerActionNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("O cliente {0} {1} foi {2} com sucesso", notification.FirstName, notification.LastName, notification.Action.ToString().ToLower());
            });
        }
    }
}