﻿namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            context.EjectCard();

            context.InsertCard();

            //context.InsertPin(1);
            context.InsertPin(8888);

            //context.WithdrawCash(11000);
            context.WithdrawCash(2000);

            context.InsertCard();
        }
    }
}
