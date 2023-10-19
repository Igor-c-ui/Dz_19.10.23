using System;
namespace Tumakov7
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Упр. 7.1
            Bank_Account client = new Bank_Account();
            client.Set_number_account(1);
            client.Set_bank_account(Type_bank_account.Сберегательный);
            client.Set_balance(100000);
            
            Console.WriteLine(client.Get_number_account());
            Console.WriteLine(client.Get_balance());
            Console.WriteLine(client.Get_bank_account());

            //Упр. 7.2
            Bank_Account2 client2 = new Bank_Account2(45678, Bank_Account2.Type_bank_account.Текущий);
            Bank_Account2 client3 = new Bank_Account2(34567, Bank_Account2.Type_bank_account.Сберегательный);

            Console.WriteLine($"client2: {client2.Number_Account}");
            Console.WriteLine($"client3: {client3.Number_Account}");

            //Упр. 7.3
            Bank_Account3 client4 = new Bank_Account3(98456, Bank_Account3.Type_bank_account.Текущий);
            Bank_Account3 client5 = new Bank_Account3(8976543, Bank_Account3.Type_bank_account.Сберегательный);

            Console.WriteLine($"client4: balance = {client4.Balance_Account}");
            bool withdraw_result = client4.Withdraw(456);
            if (!withdraw_result)
            {
                Console.WriteLine("На счету не хватает денег.");
            }
            Console.WriteLine($"client4: balance = {client4.Balance_Account}");

            Console.WriteLine($"client5: balance = {client5.Balance_Account}");
            client5.Put_Money(100000);
            Console.WriteLine($"client5: balance = {client5.Balance_Account}");
        }
    }
}
