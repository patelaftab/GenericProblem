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
        public static void FindingFloatMaximum(float FirstNumber, float SecondNumber, float ThirdNumber)
        {
            if (FirstNumber.CompareTo(SecondNumber) >= 0 && FirstNumber.CompareTo(ThirdNumber) >= 0)
            {
                Console.WriteLine("First Number Is Greater :" + FirstNumber);
            }
            else if (SecondNumber.CompareTo(FirstNumber) >= 0 && SecondNumber.CompareTo(ThirdNumber) >= 0)
            {
                Console.WriteLine("Second Number Is Greater :" + SecondNumber);
            }
            else if (ThirdNumber.CompareTo(FirstNumber) >= 0 && ThirdNumber.CompareTo(SecondNumber) >= 0)
            {
                Console.WriteLine("Third Number Is Greater :" + ThirdNumber);
            }
            else
            {
                Console.WriteLine("All Numers Are Equal");
            }
        }

        public static void FindingStringMaximum(string FirstValue, string SecondValue, String ThirdValue)
        {
            if (FirstValue.CompareTo(SecondValue) >= 0 && FirstValue.CompareTo(ThirdValue) >= 0)
            {
                Console.WriteLine("First Number Is Greater :" + FirstValue);
            }
            else if (SecondValue.CompareTo(FirstValue) >= 0 && SecondValue.CompareTo(ThirdValue) >= 0)
            {
                Console.WriteLine("Second Number Is Greater :" + SecondValue);
            }
            else if (ThirdValue.CompareTo(FirstValue) >= 0 && ThirdValue.CompareTo(SecondValue) >= 0)
            {
                Console.WriteLine("Third Number Is Greater :" + ThirdValue);
            }
            else
            {
                Console.WriteLine("All Strings Are Equal");
            }
        }


    }
}
