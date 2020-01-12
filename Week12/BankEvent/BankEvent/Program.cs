using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using static System.Console;

namespace BankEvent
{
    class Program
    {
        static void Main(string[] args)
        {

            char code;
            decimal amt;

            BankAccount acct = new BankAccount(123456);
            EventListener listener = new EventListener(acct);

            while (true)
            {
                Write("Enter D for deposit, W for withdrawal, X to exit.  ");
                code = Convert.ToChar(ReadLine().ToLower());

                if (code == 'x')
                {
                    break;
                }

                Write("Enter dollar amount: ");
                amt = Convert.ToDecimal(ReadLine());

                switch (code)
                {

                    case 'd':
                        acct.MakeDeposit(amt);
                        break;

                    case 'w':
                        acct.MakeWithdrawal(amt);
                        break;

                    default:
                        WriteLine("Invalid Operation.");
                        break;

                }
            }

            WriteLine("Press any key to end.");
            ReadKey();
        }
    }

    class BankAccount
    {
        private int acctNum;
        private decimal balance;
        public EventHandler BalanceAdjusted;
        

        public BankAccount(int acct)
        {
            acctNum = acct;
            balance = 0;
        }

        public int AcctNum
        {
            get { return acctNum;  }

        }

        public decimal Balance
        {
            get { return balance;  }
        }

        public void MakeDeposit(decimal amt)
        {
            balance += amt;
            OnBalanceAdjusted(EventArgs.Empty);
        }

        public void MakeWithdrawal(decimal amt)
        {
            balance -= amt;
            OnBalanceAdjusted(EventArgs.Empty);
        }

        public void OnBalanceAdjusted(EventArgs e)
        {
            BalanceAdjusted(this, e);

        }
    } // end class BankAccount

    class EventListener
    {
        private BankAccount acct;

        public EventListener(BankAccount account)
        {
            acct = account;
            acct.BalanceAdjusted += new EventHandler(BankAccountBalanceAdjusted);
        }

        private void BankAccountBalanceAdjusted(object sender, EventArgs e)
        {
            WriteLine("The account balance has been adjusted.");
            WriteLine("Account# {0} balance ${1}", acct.AcctNum, acct.Balance.ToString("C2"));
        }
    }
}
