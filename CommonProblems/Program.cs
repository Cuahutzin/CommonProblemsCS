using System;
using System.Diagnostics;
using Core.Excercise1.Extensions;
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
            #region Excercise 1 Reverse string and solution comparison

            var maxLoop = 1;

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
            for (int i = 0; i < maxLoop; ++i)
            {
                ex1Test4.Start();
            }
            a.Reverse();
            ex1Test4.Stop();

            Console.WriteLine("EXCERCISE 1 TESTS");

            Console.WriteLine("Extension method ReverseStringBuilder: {0}", ex1Test1.Elapsed.TotalMilliseconds.ToString("G0"));
            Console.WriteLine("Extension method ReverseStringArray: {0}", ex1Test2.Elapsed.TotalMilliseconds.ToString("G0"));
            Console.WriteLine("Extension method ReverseStringDirectArray: {0}", ex1Test3.Elapsed.TotalMilliseconds.ToString("G0"));
            Console.WriteLine("Linq Build-in: {0}", ex1Test4.Elapsed.TotalMilliseconds.ToString("G0"));

            Console.ReadLine();
            #endregion



        }
        

        
    }
}
