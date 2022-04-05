using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringWorkCalculator_17._6._6
{
    public class SimpeAccount : ICalculatorInter
    {
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }


        void GetTypeAccount()
        {
            this.Type = "Обычный";
            this.Interest = 3;
        }


    }
}
