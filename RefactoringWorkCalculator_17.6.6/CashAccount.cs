using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringWorkCalculator_17._6._6
{
    public class CashAccount : ICalculatorInter
    {
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }


        void GetTypeAccount()
        {
            this.Type = "Зарплатный";
            this.Interest = 5;
        }


    }
}
