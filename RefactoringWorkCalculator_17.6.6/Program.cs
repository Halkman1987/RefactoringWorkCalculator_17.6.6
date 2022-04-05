using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringWorkCalculator_17._6._6
{
    class Program
    {
        static void Main()
        {
            ICalculatorInter c = new CashAccount();
            c.Balance = 40000;
            c.Type = "Зарплатный";
            Calculator.NewCalculateInterest(c);


            ICalculatorInter accc = new SimpeAccount();
            accc.Balance = 90000;
            accc.Type = "Обычный";
            Calculator.NewCalculateInterest(accc);



        }
    }
}
