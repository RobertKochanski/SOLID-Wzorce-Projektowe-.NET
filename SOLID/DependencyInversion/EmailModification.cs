namespace DependencyInversion
{
    public class EmailModification : INotificatinSender
    {
        public void SendNotification(User user)
        {
            Console.WriteLine($"Sending notification to user: {user.Name}");
        }
    }
}
