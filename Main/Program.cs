using Core.Exercise01.Extensions;
using Core.Exercise02;
using Core.Exercise03;
using System;
using System.Diagnostics;
using System.Linq;

namespace CommonProblems
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Exercise 1 Reverse string and solution comparison

            var maxLoop = 10000;

            var a = "anitalavalatina";
            //Extension method ReverseStringBuilder
            var ex1Test1 = new Stopwatch();
            ex1Test1.Start();
            for (int i = 0; i < maxLoop; ++i) {
                a.ReverseStringBuilder();
            }
            ex1Test1.Stop();

            //Extension method ReverseStringArray
            var ex1Test2 = new Stopwatch();

            ex1Test2.Start();
            for (int i = 0; i < maxLoop; ++i)
            {
                a.ReverseStringArray();
            }
            ex1Test2.Stop();

            //Extension method ReverseStringDirectArray
            var ex1Test3 = new Stopwatch();

            ex1Test3.Start();
            for (int i = 0; i < maxLoop; ++i)
            {
                a.ReverseStringDirectArray();
            }
            ex1Test3.Stop();

            //Built-in linq
            var ex1Test4 = new Stopwatch();
            ex1Test4.Start();
            for (int i = 0; i < maxLoop; ++i)
            {
                a.Reverse().ToString();
            }
            ex1Test4.Stop();

            Console.WriteLine("EXCERCISE 1 Reverse string method comparison  TESTS {0} executions", maxLoop);
            Console.WriteLine("String:{0}, Reverse:{1}", a, a.Reverse().ToString());

            Console.WriteLine("Extension method ReverseStringBuilder: {0}", ex1Test1.Elapsed.TotalMilliseconds.ToString("G0"));
            Console.WriteLine("Extension method ReverseStringArray: {0}", ex1Test2.Elapsed.TotalMilliseconds.ToString("G0"));
            Console.WriteLine("Extension method ReverseStringDirectArray: {0}", ex1Test3.Elapsed.TotalMilliseconds.ToString("G0"));
            Console.WriteLine("Linq Build-in: {0}", ex1Test4.Elapsed.TotalMilliseconds.ToString("G0"));
            Console.WriteLine();
            #endregion

            #region Exercise 2 Fibonacci
            Console.WriteLine("EXCERCISE 2 Fibonacci functionality");
            Fibonacci fibo = new Fibonacci();
            long fTest1 = 4;
            long fTest2 = 9;
            Console.WriteLine("f({0}) = {1}",fTest1, fibo.GetFibonacci(fTest1));
            Console.WriteLine("f({0}) = {1}", fTest2, fibo.GetFibonacci(fTest2));
            #endregion

            #region Exercise 3 Multiplication table
            //The common way
            Console.WriteLine("EXCERCISE 3 table multiplication");
            Console.WriteLine("--------The common way -------------");
            var TableNumber = 12;
            var MaxTimes = 12;
            var ex3Test1 = new Stopwatch();
            ex3Test1.Start();
            for (int times = 1; times <= MaxTimes; ++times)
            {
                Console.WriteLine("{0} X {1} = {2}", TableNumber, times, TableNumber * times);
            }
            ex3Test1.Stop();
            Console.WriteLine();

            Console.WriteLine("-----------Kind of Dynamic way using interfaces and separation of concerns---------");
            var ex3Test2 = new Stopwatch();
            ex3Test2.Start();
            var generator = new MultiplicationTableGenerator();
            var rawTable = generator.GetTable(TableNumber, MaxTimes);
            var printer = new ConsoleStream();
            printer.Print(rawTable);
            ex3Test2.Stop();

            Console.WriteLine("Ex1: {0}", ex3Test1.Elapsed.TotalMilliseconds.ToString("G0"));
            Console.WriteLine("Ex2: {0}", ex3Test2.Elapsed.TotalMilliseconds.ToString("G0"));

            Console.ReadLine();
            #endregion

            #region Exercise 4 Sums up integers from a text file
            
            //var array = 


            #endregion
        }



    }
}

