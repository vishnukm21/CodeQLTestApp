using System;

namespace CodeQLConsoleAPP
{
    class Program
    {

        public static string UserID = "vishnu";

        public static string Password = "Hyderabad";

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
                string s = a;
            }
            catch (Exception ex)
            {
                //throw;
            }
        }

    }
}
