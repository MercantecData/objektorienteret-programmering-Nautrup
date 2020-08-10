using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            opgave1();
            opgave2();
            opgave3();
        }

        delegate int intManipulation(int number);
        static void opgave1()
        {
            intManipulation del = (number) => number * 2;
            Console.WriteLine($"{del(5)}");
        }

        delegate float floatManipulation(float num1, float num2, float num3);
        static void opgave2()
        {
            floatManipulation del = (num1, num2, num3) => num1 + num2 + num3;
            Console.WriteLine(del(10.5f, 3.9f, 1.1f));
        }

        delegate string stringManipulation();
        static void opgave3()
        {
            stringManipulation del = () => "Hello World";
            Console.WriteLine(del());
        }
    }
}
