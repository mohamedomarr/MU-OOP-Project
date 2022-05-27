// Mohamed Saad Ahmed Ali Omar, SWE, 805554525
// Farah Aysam Mohamed ِِElsaid, SWE, 805481657
// Mariam Abdelnaby hessein Elsaid, SWE, 805775545
using System;

namespace OOP_Project_Bank
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Ask the user for the bank account type
            Console.WriteLine("Choose a bank type 1 or 2");
            Console.WriteLine("1- Checking account");
            Console.WriteLine("2- Saving account");

            int type = Convert.ToInt32(Console.ReadLine());

            if (type == 1)
            {
                Console.Write("Enter your inital deposit: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Account CAccount = new CheckingAccount(number);
                login.log(CAccount);
            }

            else if (type == 2)
            {
                Console.Write("Enter your inital deposit: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Account SAccount = new SavingsAccount(number);
                login.log(SAccount);
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }

        }

    }

}

