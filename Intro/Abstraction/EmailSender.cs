namespace DesignPatternsIntro.Abstraction
{
    internal class EmailSender
    {
        private void ConnectToSmtpServer()
        {
            Console.WriteLine("Connecting to SMTP server");
        }

        private void InsertCredentials()
        {
            Console.WriteLine("Inserting Credentials");
        }

        public void SendEmail(string to, string title, string body)
        {
            ConnectToSmtpServer();
            InsertCredentials();

            Console.WriteLine($"Sending email to {to}, {title} {body}");

            Disconnect();
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnected from server");
        }
    }
}
