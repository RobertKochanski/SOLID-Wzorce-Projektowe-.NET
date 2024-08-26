namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificationSender notificationSender = new EmailSender();
            notificationSender.SendNotification(1, new Notification { Title="title", Body="body"});

            INotificationSender smsSender = new SmsSenderAdapter();
            smsSender.SendNotification(1, new Notification { Title = "title", Body = "body" });
        }
    }
}
