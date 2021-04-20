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

            int num = 6;
            // val++;
            num--;
            // val += 2;
            Console.WriteLine(num);





        }
    }
}
