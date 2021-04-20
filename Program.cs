using System;

namespace CommonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // +, *, /, _, %, >, < >=, <=
            int x = 20;
            int y = 10;

            string result = x > y ? " X is greater than Y" : " X is less than Y";

            Console.WriteLine(result);

            int val = 6;
            // val++;
            val--;
            // val += 2;
            Console.WriteLine(val);





        }
    }
}
