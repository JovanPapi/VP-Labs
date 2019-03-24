using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_VP
{
    class Program
    {
        private enum PasswordStrenght { easy = 1, normal = 2, hard = 3 }

        static void Main(string[] args)
        {

            String easyPassword = generateRandomPassword(PasswordStrenght.easy);
            String normalPassword = generateRandomPassword(PasswordStrenght.normal);
            String hardPassword = generateRandomPassword(PasswordStrenght.hard);

            if (easyPassword != "" && normalPassword != "" && hardPassword != "")
            {
                Console.WriteLine("Easy, normal & hard password were generated successfully!");
                Console.WriteLine(easyPassword + "\n" + normalPassword + "\n" + hardPassword + "\n");
            }

            Console.WriteLine("Now in one line type some guesses for the passwords: ");
            char[] separate = { ' ' };
            string line = Console.ReadLine();
            string[] guesses = line.Split(separate);

            if (guesses.Contains(easyPassword))
            {
                Console.WriteLine("\nCongratulations! You have guessed the easy password.\n");
            }
            else
                Console.WriteLine("\nU didnt guessed the easy password. . .\n");

            if (guesses.Contains(normalPassword))
            {
                Console.WriteLine("\nCongratulations! You have guessed the normal password.\n");
            }

            else
                Console.WriteLine("\nU didnt guessed the normal password. . .\n");

            if (guesses.Contains(hardPassword))
            {
                Console.WriteLine("\nCongratulations! You have guessed the hard password.\n");
            }

            else
                Console.WriteLine("\nU didnt guessed the hard password. . .\n");


            Console.ReadKey();

        }

        private static string generateRandomPassword(PasswordStrenght passwordStrenght)
        {
            String password = "";
            int choice = (int)passwordStrenght;
            switch (choice)
            {
                case 1: password = generateEasyPassword(); break;
                case 2: password = generateNormalPassword(); break;
                case 3: password = generateHardPassword(); break;
            }
            return password;
        }

        private static string generateEasyPassword()
        {
            String buildPassword = "";
            Random random = new Random();
            int randomSize = random.Next(1, 6);
            for (int i = 1; i <= randomSize; i++)
            {
                buildPassword += Convert.ToChar(random.Next(97, 122));
            }
            return buildPassword.ToLower();
        }

        private static string generateNormalPassword()
        {
            String buildPassword = "";
            Random random = new Random();
            int randomSize = random.Next(6, 10);
            for (int i = 1; i <= randomSize; i++)
            {
                buildPassword += Convert.ToChar(normalSkip(random));
            }
            return buildPassword.ToUpper();
        }

        private static string generateHardPassword()
        {
            Random random = new Random();
            String buildPassword = "";
            int randomSize = random.Next(10, 20);
            for (int i = 0; i < randomSize; i++)
            {
                buildPassword += Convert.ToChar(hardSkip(random));
            }
            return buildPassword;
        }

        private static int hardSkip(Random random)
        {
            int check = 0;
            while (true)
            {
                check = random.Next(33, 122);
                if ((check >= 33 && check <= 47) || (check >= 97 && check <= 122)
                    || (check >= 65 && check <= 90))
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            return check;
        }

        private static int normalSkip(Random random)
        {
            int check = 0;
            while (true)
            {
                check = random.Next(48, 90);
                if (check >= 58 && check <= 64)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            return check;
        }
    }
}
