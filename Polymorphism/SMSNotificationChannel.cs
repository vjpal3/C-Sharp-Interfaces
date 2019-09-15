using System;

namespace Interfaces.Polymorphism
{
    public class SMSNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}
