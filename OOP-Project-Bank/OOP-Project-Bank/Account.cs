using System;
namespace OOP_Project_Bank
{
    interface IAccount
    {
        bool Deposit(double amount);
        bool Withdraw(double amount);
        void PrintBalance();

    }
    class Account : IAccount
    {
        public string accountType;

        private double _balance;

        protected double Balance
        {
            get { return this._balance; }
            set
            {
                if (value >= 0)
                    this._balance = value;
            }
        }

        // Constructor
        public Account(double balance)
        {
            this.Balance = balance;
        }

        public Account(Account switchedFrom)
        {
            this.Balance = switchedFrom.Balance;
        }

        //Virtual Methods
        public virtual bool Deposit(double amount)
        {

            return false;
        }

        public virtual bool Withdraw(double amount)
        {

            return false;
        }

        public virtual void PrintBalance()
        {
            // Console.WriteLine("The balance is: " + Balance);
            Console.WriteLine("In text: " + Balance.ToString());
        }

    }
}

