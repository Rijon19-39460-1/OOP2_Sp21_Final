using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_Final_1._1
{
    class Transaction
    {
        private Account sender;
        private Account receiver;
        private int amount;
        private String additionalInfo;
        public Account Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        public Account Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public String AdditionalInfo
        {
            get { return additionalInfo; }
            set { additionalInfo = value; }
        }
        public Transaction() { }
        public Transaction(Account sender, Account receiver, int amount, String additionalInfo)
        {
            Sender = sender;
            Receiver = receiver;
            Amount = amount;
            AdditionalInfo = additionalInfo;
        }
        public void showInfo()
        {
            Console.WriteLine(" Sender Name : {0} \n Sender Account ID : {1} ", sender.AccName, sender.AccId);
            Console.WriteLine(" Receiver Name : {0} \n Receiver Account ID : {1} ", receiver.AccName, receiver.AccId);
            Console.WriteLine("Transaction Amount : " + amount);
            Console.WriteLine("Transaction Info : " + additionalInfo);

        }

    }
}
