using System;

namespace intercambia_5_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int n2 = 6;
            intercambio(ref n, ref n2);

            Console.WriteLine(n + "," + n2);
        }
        public static void intercambio(ref int num1, ref int num2)
        {
            int can1;

            can1 = num1;
            num1 = num2;
            num2 = can1;


           // Console.WriteLine(num1+","+num2);

        }
    }
}
