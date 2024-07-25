using DesignPatternsIntro.Hermetization;

namespace DesignPatternsIntro.Encapsulation.Inheritance
{
    internal class CompanyBankAccount : BankAccount
    {
        public void TakeLoan(float amount)
        {
            //...
        }

        public override void MakeWithdraw(float amount)
        {
            Console.WriteLine("Make withdraw for company bank account");
        }
    }
}
