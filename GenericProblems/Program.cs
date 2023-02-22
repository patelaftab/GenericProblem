using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics");
            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("=================\nChoose Number :\n=================" +
                    "\nEnter 1:Finding Maximum Integer Numbers \n" +
                    "Enter 2:Finding Maximum Float Number\n" +
                    "Enter 3: Finding Maximum String Value");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        MaximumNumber.FindingMaximum(9, 5, 1);
                        break;
                    
                    default:
                        Console.WriteLine("Choose a Correct Option");
                        break;
                }
            }
        }
    }
}

