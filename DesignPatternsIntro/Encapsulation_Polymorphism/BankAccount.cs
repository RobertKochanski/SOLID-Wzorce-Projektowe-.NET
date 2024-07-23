namespace DesignPatternsIntro.Hermetization
{
    internal class BankAccount
    {
        protected float _balance;
        public string Name { get; set; }

        public void MakeDeposit(float amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount must be positive number");
            }
            
            _balance += amount;
        }
        public virtual void MakeWithdraw(float amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount must be positive number");
            }

            _balance -= amount;
        }

        public float GetBalance()
        {
            return _balance;
        }
    }
}
