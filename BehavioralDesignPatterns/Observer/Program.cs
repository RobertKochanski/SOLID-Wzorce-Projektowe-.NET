namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subscriber1 = new Subscriber("sub1");
            var subscriber2 = new Subscriber("sub2");

            var publisher = new Publisher();

            publisher.Subscribe(subscriber1);
            publisher.Subscribe(subscriber2);

            publisher.Notify("test message");

            publisher.Unsubscribe(subscriber1);

            publisher.Notify("test message2");
        }
    }
}
