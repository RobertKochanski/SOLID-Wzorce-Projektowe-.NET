using DesignPatternsIntro.Abstraction;
using DesignPatternsIntro.Encapsulation.Inheritance;
using DesignPatternsIntro.Hermetization;
using DesignPatternsIntro.Interface;

namespace DesignPatternsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailSender emailSender = new EmailSender();

            emailSender.SendEmail("to@email.com", "title", "body");
        }
    }
}
