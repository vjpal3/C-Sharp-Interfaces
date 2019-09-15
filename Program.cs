using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Testabilty;
using Interfaces.Extensibility;
using Interfaces.Polymorphism;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run code for Interface Polymorphism
            var encoder = new VideoEncoder();
            //Polymorphic dispatch
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SMSNotificationChannel());
            encoder.Encode(new Video());

            //Run code for Extensibility
            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            //dbMigrator.Migrate();

            //Console.ForegroundColor = ConsoleColor.White;

            // The behaviour of the app is changed by extending the app, 
            // instead of changing the existing code. (OCP)
            // Here the extension point is, use of an interface 
            var dbMigratorFileLogging = new DbMigrator(new FileLogger("e:\\log.txt"));
            dbMigratorFileLogging.Migrate();
            
            //Run code for Testability
            //var orderProcessor = new OrderProcessor(new ShippingCalculator());
            //var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            //orderProcessor.Process(order);
        }
    }
}
