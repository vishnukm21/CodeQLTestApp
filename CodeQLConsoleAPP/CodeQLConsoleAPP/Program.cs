using System;

namespace CodeQLConsoleAPP
{
    class Program
    {

        public static string value = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void AddTwoNumbers(int a, int b)
        {

            try
            {
                a = a + b;
            }
            catch (Exception ex)
            {
                //throw;
            }
        }

    }
}
