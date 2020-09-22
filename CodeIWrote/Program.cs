using System;

namespace CodeIWrote
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 10;
            int max = 20;
            int maxVersion = 1;
            Console.WriteLine("Enter a number greater than 1 and less than 100: ");
            string x = Console.ReadLine();
            int userNum = Convert.ToInt32(x);
            while (true)
            {
                if (userNum > num1 && userNum < num2)
                {
                    Console.WriteLine("Your number is greater than " + num1 + ", and less than " + num2);
                    break;
                }
                else if (userNum > num2 && userNum < max)
                {
                    Console.WriteLine("Your number is greater than " + num2 + ", and less than " + max);
                    break;
                }
                else
                {
                    max += 10;
                    maxVersion++;
                    continue;
                }
            }
                switch (maxVersion)
                {
                    case 1:
                        Console.WriteLine("max version 1");
                        break;
                    case 2:
                        Console.WriteLine("max version 2");
                        break;
                    case 3:
                        Console.WriteLine("max version 3");
                        break;
                    case 4:
                        Console.WriteLine("max version 4");
                        break;
                    case 5:
                        Console.WriteLine("max version 5");
                        break;
                    case 6:
                        Console.WriteLine("max version 6");
                        break;
                    case 7:
                        Console.WriteLine("max version 7");
                        break;
                    case 8:
                        Console.WriteLine("max version 8");
                        break;
                    case 9:
                        Console.WriteLine("max version 9");
                        break;
                }
        }
    }
}
