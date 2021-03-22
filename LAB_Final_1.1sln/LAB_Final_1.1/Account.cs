using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_Final_1._1
{
    class Account
    {

        private String accName;
        private String accId;
        private int accBalance;
        private Transaction[] listOfTransaction = new Transaction[100];
        public int totalNumberOfTransaction;

        public String AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        public String AccId
        {
            get { return accId; }
            set { accId = value; }
        }
        public int Balance
        {
            get { return accBalance; }
            set { accBalance = value; }
        }
        public int TotalNumberOfTransaction
        {
            get { return totalNumberOfTransaction; }
            set { totalNumberOfTransaction = value; }
        }

        public Account() { }
        public Account(string accName, string accId, int accBalance)
        {
            AccName = accName;
            AccId = accId;
            Balance = accBalance;
        }
        public void Deposit(int amount)
        {
            this.accBalance += amount;
            Console.WriteLine("" + amount + " Amount deposited");
            Console.WriteLine("Balance after depositing amount:" + this.accBalance);
            Transaction t = new Transaction(this, this, amount, "Amount deposited");
            this.addTransaction(t);


        }
        public void ShowInfo()
        {
            Console.WriteLine("Acc Name: " + AccName);
            Console.WriteLine("Acc No: " + accId);
            Console.WriteLine("Balance: " + Balance);

        }
        public void Withdraw(int amount)
        {
            if (amount < accBalance)
            {
                this.accBalance -= amount;
                Console.WriteLine("" + amount + " Amount withdrawn");
                Console.WriteLine("Balance after withdrawing amount:" + this.accBalance);
                Transaction t1 = new Transaction(this, this, amount, "Amount withdrawn");
                this.addTransaction(t1);

            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }

        }
        public void Transfer(Account acc, int amount)
        {
            accBalance = accBalance - amount;
            acc.accBalance = acc.accBalance + amount;
            Console.WriteLine("" + amount + " Amount transfered");
            Console.WriteLine("Balance after transfer amount:" + this.accBalance);
            Transaction t2 = new Transaction(this, acc, amount, "Amount transfered");
            this.addTransaction(t2);
            acc.addTransaction(t2);
        }
        public void addTransaction(Transaction transaction)
        {
            listOfTransaction[totalNumberOfTransaction++] = transaction;

        }
        public void showAllTranscation()
        {
            for (int i = 0; i < totalNumberOfTransaction; i++)
            {
                listOfTransaction[i].showInfo();
            }
        }
    }
}
