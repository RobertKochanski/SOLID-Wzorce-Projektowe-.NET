namespace DesignPatternsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("first", "last");

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }
    }
}
