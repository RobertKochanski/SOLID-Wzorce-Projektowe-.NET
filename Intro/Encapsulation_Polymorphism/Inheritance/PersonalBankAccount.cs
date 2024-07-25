using DesignPatternsIntro.Hermetization;

namespace DesignPatternsIntro.Encapsulation.Inheritance
{
    internal class PersonalBankAccount : BankAccount
    {
        public void RequestPersonalLoan()
        {
            Console.WriteLine("Making Request");
        }

        public override void MakeWithdraw(float amount)
        {
            Console.WriteLine("Personal bank account withdraw");
            if (amount < 0)
            {
                throw new Exception("Amount must be positive number");
            }
            if (_balance - amount < 0)
            {
                throw new Exception("Personal bank account cannot go in dept");
            }

            _balance -= amount; 
        }
    }
}
