using System;
namespace OOP_Project_Bank
{
	class login
    {
        public static void log(Account Account)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("What's your next move");
            Console.WriteLine("1- Deposit");
            Console.WriteLine("2- Withdraw");
            Console.WriteLine("3- Check balance");
            Console.WriteLine("4- Switch account type");
            Console.WriteLine("5- Exit");

            Console.Write("Move number: ");


            int opr = Convert.ToInt32(Console.ReadLine());
            if (opr == 1)
            {
                Console.Write("Enter your deposit amount: ");
                int amount = Convert.ToInt32(Console.ReadLine());
                Account.Deposit(amount);
                Account.PrintBalance();
                log(Account);
            }
            else if (opr == 2)
            {
                Console.Write("Enter your withdrow amount: ");
                int amount = Convert.ToInt32(Console.ReadLine());
                Account.Withdraw(amount);
                Account.PrintBalance();
                log(Account);
            }
            else if (opr == 3)
            {
                Account.PrintBalance();
                log(Account);

            }
            else if (opr == 4)
            {
                if (Account.accountType == "Checking")
                {
                    Account SAccount = new SavingsAccount(Account);
                    SAccount.PrintBalance();
                    Console.WriteLine("--------------------");
                    login.log(SAccount);
                }
                else
                {
                    Account CAccount = new CheckingAccount(Account);
                    CAccount.PrintBalance();
                    Console.WriteLine("--------------------");
                    login.log(CAccount);

                }
            }
            else if (opr == 5)
            {
                Console.WriteLine("bye");
            }
            else
            {
                Console.WriteLine("try again");
            }
        }
    }
}

