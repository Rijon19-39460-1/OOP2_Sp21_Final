using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_Final_1._1
{
    class Program
    {

            static void Main(string[] args)
          {
            Account a1 = new Account("ABC", "145", 66000);
            Account a2 = new Account("BCD", "146", 88000);
            Account a3 = new Account("EFG", "147", 55000);

            a1.Withdraw(550);
            a2.Withdraw(660);
            a1.Transfer(a2, 3000);
            a3.Deposit(4000);
            a1.showAllTranscation();
            a2.showAllTranscation();
            a3.showAllTranscation();
          }
        }
    }

