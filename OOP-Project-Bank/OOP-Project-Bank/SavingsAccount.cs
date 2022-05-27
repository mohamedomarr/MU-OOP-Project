using System;
namespace OOP_Project_Bank
{
    class SavingsAccount : Account
    {
        private double _interestRate;

        // Copy Constructor
        public SavingsAccount(Account switchedFrom) : base(switchedFrom)
        {
            accountType = "Saving";
            this._interestRate = 0.25;
            Balance += (Balance * this._interestRate);
        }

        // Paramterized Constructor
        public SavingsAccount(double balance)
            : base(balance)
        {
            this._interestRate = 0.25;
            Balance += (Balance * this._interestRate);
        }

        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount + (amount * this._interestRate);
                return true;
            }
            return false;
        }


        public override bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                // Deducting from balance
                Balance -= amount;
                return true;
            }
            return false;
        }


        public override void PrintBalance()
        {

            Console.WriteLine("The account balance is: " + base.Balance);
            Console.WriteLine("In text: " + ToString());
        }

        public override string ToString()
        {
            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] tens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] ten = { "zero", "Ten", "Twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] levels = { "Hundred", "Thousand", "Million" };
            string strYear = Balance.ToString();

            if (strYear.Length == 0)
            {
                return numbers[0];
            }
            else if (strYear.Length == 1)
            {
                int num = Convert.ToInt32(strYear[0]) - '0';
                return numbers[num];
            }
            else if (strYear.Length == 2)
            {
                if (Balance < 20 && Balance > 9)
                {

                    int num = Convert.ToInt32(strYear[1]) - '0';
                    return tens[num];
                }
                else
                {
                    int tenat = Convert.ToInt32(strYear[0]) - '0';
                    int num = Convert.ToInt32(strYear[1]) - '0';
                    return ten[tenat] + " " + numbers[num];
                }
            }
            else if (strYear.Length == 3)
            {
                int num = Convert.ToInt32(strYear[0]) - '0';
                int tenat = Convert.ToInt32(strYear[1]) - '0';
                int ones = Convert.ToInt32(strYear[2]) - '0';
                return numbers[num] + ten[tenat] + " " + numbers[num];
            }
            else if (strYear.Length == 4)
            {
                int thau = Convert.ToInt32(strYear[0]) - '0';
                int hun = Convert.ToInt32(strYear[1]) - '0';
                int tenat = Convert.ToInt32(strYear[2]) - '0';
                int ones = Convert.ToInt32(strYear[3]) - '0';

                if (hun > 0 || tenat > 0 || ones > 0)
                    return numbers[thau] + " " + levels[1] + " and more";
                else
                    return numbers[thau] + " " + levels[1];
            }
            else
            {
                return "more than 9999";
            }
        }
    }
}

