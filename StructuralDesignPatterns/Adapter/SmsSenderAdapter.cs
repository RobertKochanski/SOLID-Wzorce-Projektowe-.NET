using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SmsSenderAdapter : INotificationSender
    {
        private SmsSender _SmsSender = new SmsSender();

        public void SendNotification(int userId, Notification notification)
        {
            string userPhoneNumber = ""; // based on userId
            _SmsSender.SendSMS(userPhoneNumber, $"{notification.Title} {notification.Body}");
        }
    }
}
