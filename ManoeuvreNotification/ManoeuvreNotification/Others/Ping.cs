using MediatR;

namespace ManoeuvreNotification.Others
{
    public class Ping : INotification
    {
        public string Name { get; set; }
    }
}
