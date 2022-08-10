namespace BankAccountProject
{
    public class Account
    {
        private decimal balance;

        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Credit(decimal amount)
        {
            Balance = Balance + amount;//Add amount to balance
        }

        public decimal Balance 
        {
            get 
            {
                return balance;
            }
            set
            {
                //Validate that value is greater than or equal 0;
                //If it is not, balance is left unchanged
                if(value >= 0)
                    balance = value;

            }
        }
    }
}
