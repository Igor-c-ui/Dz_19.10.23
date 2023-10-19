using System;
namespace Tumakov7
{
    class Bank_Account2
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
            get
            {
                return number_account;
            }
        }
        public float Balance_Account
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
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

        public Bank_Account2(float balance, Type_bank_account bank_account)
        {
            number_account = next_number_account;
            this.balance = balance;
            this.bank_account = bank_account;
            Generate_next_number_account();
        }
    }
}
