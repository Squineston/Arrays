using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 24; 
            int[] Fib = new int[n + 1];
            Fib[0] = 0;
            Fib[1] = 1;

            Console.WriteLine("Fibonacci number (0) = " + Fib[0]);
            Console.WriteLine("Fibonacci number (1) = " + Fib[1]);

            for (int i = 2; i <= n; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
                Console.WriteLine("Fibonacci number (" + i + ") = " + Fib[i]);
            }
        }
    }
}
