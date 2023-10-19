using System.Security.Policy;

namespace Tumakov7
{
    class Bank_Account3
    {
        public enum Type_bank_account
        {
            Текущий,
            Сберегательный
        }
        private static uint next_number_account = 1;
        private uint number_account;
        private float balance;
        private Type_bank_account bank_account;

        public uint Number_Account
        {
            get{ return number_account; }
        }
        public float Balance_Account
        {
            get{ return balance; }

            set { balance = value; }
        }
        public Type_bank_account Type_Bank_Account
        {
            get { return bank_account; }
            set { bank_account = value; }
        }
        private void Generate_next_number_account()
        {
            next_number_account++;
        }
        public bool Withdraw(uint withdrawn_money)
        {
            if (balance - withdrawn_money > 0)
            {
                balance -= withdrawn_money;
                return true;
            }
            return false;
        }
        public void Put_Money(uint money)
        {
            balance += money;
        }

        public Bank_Account3(float balance, Type_bank_account bank_account)
        {
            number_account = next_number_account;
            this.balance = balance;
            this.bank_account = bank_account;
            Generate_next_number_account();
        }
    }
}
