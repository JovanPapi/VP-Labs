using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_VP
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "This is a test.";
            char[] separator = { ' ' }; // char array that cointains space
            string[] myWords;
            myWords = myString.Split(separator); // separates myString by space
            foreach (string word in myWords) // type every word in myWords array.
            {
                Console.WriteLine("{0}", word);
            }
            Console.ReadKey();
        }
    }
}
