﻿using DesignPatternsIntro.Abstraction;

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
