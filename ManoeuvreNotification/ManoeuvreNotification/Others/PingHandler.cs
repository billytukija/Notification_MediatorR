using System;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ManoeuvreNotification.Others
{
    public class PingHandler : INotificationHandler<Ping>
    {
        public PingHandler()
        {
        }

        public Task Handle(Ping notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                // Your process here
                Console.WriteLine("Arrived here");
            });
        }
    }
}
