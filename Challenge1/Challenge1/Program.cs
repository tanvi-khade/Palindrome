using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 999; i >= 100; i--)
            {
                for (int j = 999; j >= 100; j--)
                {
                    if (IsPalindrome(i * j))
                    {
                        Console.WriteLine(i * j);
                        Console.ReadKey();
                        break;
                    }
                }
            }

        }

        public static bool IsPalindrome(int number)
        {

            var numArry = number.ToString().ToCharArray();
            Array.Reverse(numArry, 0, numArry.Length);
            string str = new string(numArry);
            var reversedNumber = Convert.ToInt32(str);

            if (number == reversedNumber)
            {
                return true;
            }

            return false;
        }
    }
}
