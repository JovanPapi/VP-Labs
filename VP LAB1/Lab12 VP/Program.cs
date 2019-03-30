using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_VP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers u want to insert: ");
            int howManyNumbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Choose 1 to enter the numbers from keyboard\n" +
                              "2. Choose 2 for randomly generated numbers\n");

            Console.WriteLine("Choose you choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            int maxNumber, minNumber, sumOfAllNumbers;

            doTheMath(out maxNumber, out minNumber, out sumOfAllNumbers, choice, howManyNumbers);

            Console.WriteLine("The maximum number is {0}", maxNumber);
            Console.WriteLine("The minimumm number is {0}", minNumber);
            Console.WriteLine("The average value number is {0}", sumOfAllNumbers / (double)howManyNumbers);

            Console.ReadKey();
        }
        public static void doTheMath(out int maxNumber, out int minNumber, out int sumOfAllNumbers, int choice, int howManyNumbers)
        {
            maxNumber = 0;
            minNumber = 0;
            sumOfAllNumbers = 0;

            switch (choice)
            {
                case 1:

                    Console.WriteLine("Enter the numbers: ");

                    int check1 = Convert.ToInt32(Console.ReadLine());

                    maxNumber = check1;
                    minNumber = check1;
                    sumOfAllNumbers = check1;

                    for (int i = 1; i < howManyNumbers; i++)
                    {
                        check1 = Convert.ToInt32(Console.ReadLine());

                        if (maxNumber < check1)
                        {
                            maxNumber = check1;
                        }
                        if (minNumber > check1)
                        {
                            minNumber = check1;
                        }
                        sumOfAllNumbers += check1;

                    }
                    break;
                case 2:

                    Random random = new Random();

                    int check = random.Next(1, 1000);
                    maxNumber = check;
                    minNumber = check;
                    sumOfAllNumbers = check;

                    for (int i = 1; i < howManyNumbers; i++)
                    {

                        check = random.Next(1, 1000);
                        //Console.WriteLine(check);
                        if (maxNumber < check)
                        {
                            maxNumber = check;
                        }
                        if (minNumber > check)
                        {
                            minNumber = check;
                        }
                        sumOfAllNumbers += check;

                    }
                    break;
            }
        }
    }
}
