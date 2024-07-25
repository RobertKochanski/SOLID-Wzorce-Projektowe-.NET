namespace DesignPatternsIntro.Class
{
    internal class Person
    //(string name)  possible way to create contructor since .NET 8
    {
        public string FirstName;
        public string LastName;

        public Person(string firstname, string lastname) // older way to create contructor
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public void SayHi()
        {
            Console.WriteLine($"Hi, my name is {FirstName}");
        }
    }
}
