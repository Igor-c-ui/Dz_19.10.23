namespace Tumakov7
{
    enum Type_bank_account
    {
        Текущий,
        Сберегательный
    }
    class Bank_Account
    {
        
        private uint number_account;
        private float balance;
        private Type_bank_account bank_account;


        public void Set_number_account(uint number)
        {
            number_account = number;
        }
        public uint Get_number_account()
        {
            return number_account;
        }
        public void Set_balance(float client_balance)
        {
            balance = client_balance;
        }
        public float Get_balance()
        {
            return balance;
        }
        public void Set_bank_account(Type_bank_account client_bank_account)
        {
            bank_account = client_bank_account;
        }
        public Type_bank_account Get_bank_account()
        {
            return bank_account;
        }
    }
}
