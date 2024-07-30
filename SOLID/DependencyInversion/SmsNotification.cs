namespace DependencyInversion
{
    public class SmsNotification : INotificatinSender
    {
        public void SendNotification(User user)
        {
            Console.WriteLine($"Sending sms notification to user: {user.Name}");
        }
    }
}
