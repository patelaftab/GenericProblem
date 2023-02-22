using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
    public class GenericClass<T> where T : IComparable
    {
        public T FindMaximumGeneric(T firstNumber, T secondNumber, T thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(secondNumber) > 0)
            {
                return firstNumber;
            }
            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(secondNumber) > 0)
            {
                return secondNumber;
            }
            else
                return thirdNumber;
        }
    }
}
