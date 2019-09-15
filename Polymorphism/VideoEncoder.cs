using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Polymorphism
{
    class VideoEncoder
    {
        private readonly IList<INotificationChannel> notificationChannels;
        public VideoEncoder()
        {
            notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // ... Video Encoding logic

            // Polymorphic behaviour, 
            // depending on the type of channel, a different send() method will be called at runtime
            foreach (var channel in notificationChannels)
                channel.Send(new Message());
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            notificationChannels.Add(channel);
        }
    }
}
