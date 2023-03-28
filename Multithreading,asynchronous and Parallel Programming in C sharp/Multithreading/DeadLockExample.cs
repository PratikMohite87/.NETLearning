using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    /*
       Scenario when a deadlock can occur
       Let's say we have 2 threads 
            a) Thread 1
            b) Thread 2

       and 2 resources
            a) Resource 1
            b) Resource 2

       Thread 1 has already acquired a lock on Resource 1 and wants to acquire a lock on Resource 2. 
       At the same time Thread 2 has already acquired a lock on Resource 2 and wants to acquire a lock on Resource 1. 
       Two threads never give up their locks, hence a deadlock.

       Take lock at image in folder.
     */
    internal class DeadLockExample
    {
        public static void Main11()
        {
            Console.WriteLine("Main Started");
            Account accountA = new Account(101, 5000);
            Account accountB = new Account(102, 3000);

            AccountManager accountManagerA = new
                AccountManager(accountA, accountB, 1000);
            Thread T1 = new Thread(accountManagerA.Transfer);
            T1.Name = "T1";

            AccountManager accountManagerB = new
                AccountManager(accountB, accountA, 2000);
            Thread T2 = new Thread(accountManagerB.Transfer);
            T2.Name = "T2";

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();
            Console.WriteLine("Main Completed");
        }
    }

    public class Account
    {
        double _balance;
        int _id;

        public Account(int id, double balance)
        {
            this._id = id;
            this._balance = balance;
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }
    }

    public class AccountManager
    {
        Account _fromAccount;
        Account _toAccount;
        double _amountToTransfer;

        public AccountManager(Account fromAccount,
            Account toAccount, double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;
        }

        #region Deadlock happens here study this.
        public void Transfer()
        {
            Console.WriteLine(Thread.CurrentThread.Name
                + " trying to acquire lock on "
                + _fromAccount.ID.ToString());
            lock (_fromAccount)
            {
                Console.WriteLine(Thread.CurrentThread.Name
                    + " acquired lock on "
                    + _fromAccount.ID.ToString());

                Console.WriteLine(Thread.CurrentThread.Name
                    + " suspended for 1 second");

                Thread.Sleep(1000);

                Console.WriteLine(Thread.CurrentThread.Name +
                    " back in action and trying to acquire lock on "
                    + _toAccount.ID.ToString());

                lock (_toAccount)
                {
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                }
            }
        }
        #endregion
    }
}
