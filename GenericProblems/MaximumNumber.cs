using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
    public class MaximumNumber
    {
        public static void FindingMaximum(int FirstNumber, int SecondNumber, int ThirdNumber)
        {
            if (FirstNumber.CompareTo(SecondNumber) >= 0&& FirstNumber.CompareTo(ThirdNumber) >= 0)
            {
                Console.WriteLine("First Number Is Greater :" + FirstNumber);
            }
            else if (SecondNumber.CompareTo(FirstNumber) >= 0&& SecondNumber.CompareTo(ThirdNumber) >= 0)
                    {
                Console.WriteLine("Second Number Is Greater :" + SecondNumber);
            }
            else if (ThirdNumber.CompareTo(FirstNumber) >= 0&& ThirdNumber.CompareTo(SecondNumber) >= 0)
                    {
                Console.WriteLine("Third Number Is Greater :"+ThirdNumber);
            }
            else
            {
                Console.WriteLine("All Numers Are Equal");
            }
        }
        
    }
}
