using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringWorkCalculator_17._6._6
{
    public static class Calculator
    {
        public static void NewCalculateInterest(ICalculatorInter account)
        {
            if (account.Type == "Обычный")
            {
                // расчет процентной ставки обычного аккаунта по правилам банка
                account.Interest = account.Balance * 0.4;


                if (account.Balance < 1000)
                    account.Interest -= account.Balance * 0.2;


                if (account.Balance < 50000)
                    account.Interest -= account.Balance * 0.4;

            }
            else if (account.Type == "Зарплатный")
            {
                // расчет процентной ставк зарплатного аккаунта по правилам банка
                account.Interest = account.Balance * 0.5;

            }
            Console.WriteLine($"Ваш Тип :{account.Type}\nВаша ставка : {account.Interest}");
        }



    }
}
