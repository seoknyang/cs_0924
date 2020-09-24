using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Hello World!");
            Console.WriteLine("첫 번째 정수 입력 :");
            abc:

            num1 = int.Parse(Console.ReadLine());
            Console.Write("두 번째 정수 입력 :");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
            Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));
            Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
            Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));
            goto abc;

        }
    }
}
