using System;

namespace CSharpPracticeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            System.Console.WriteLine(p1.FibonacciRec(1, 1, 1));
            System.Console.WriteLine(p1.FibonacciRec(1, 2, 3));
            System.Console.WriteLine(p1.FibonacciRec(1, 3, 4));
            System.Console.WriteLine(p1.FibonacciRec(1, 1, 10));
        
        }

            /// <summary>
            /// Returns the nth Fibonacci number
            /// </summary>
            /// <param name="num1"></param>
            /// <param name="num2"></param>
            /// <param name="numFibs"></param>
            /// <returns></returns>
            
            public int FibonacciRec(int num1, int num2, int numFibs) {
                if (numFibs > 0) {
                    numFibs--;
                    num2 = num1 + num2;
                    return FibonacciRec(num2, num2 + num1, numFibs);
                }   
                return num2 + num1;
            
            }
    }
}
