using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_SecB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0; // THIS IS JUST A VARIABLE IM USING TO PUT BREAKPOINTS AT
            method1();
            method2();
            Console.WriteLine(method3()[0]);

            if(method4())
            {

            }

            method5(7);

            method6(4, 5);

            Console.WriteLine(getSum(4,5));

            //Console.WriteLine("The user input is {0}",getNumFromUser());

            //Console.WriteLine(getSum(getNumFromUser(), getNumFromUser()));

            Console.WriteLine(forLoop(0,10));
            Console.WriteLine(forLoop(20, 66));

            Console.ReadKey();
        }

        static void method1()
        {
            int a = 0;
            Console.WriteLine("Hello from method 1");
            //method2();
        }

        static void method2()
        {
            Console.WriteLine("Hello from method 2");
            //method2();
        }

        /// <summary>
        /// This is method 3
        /// </summary>
        /// <returns> a simple string </returns>
        static string method3()
        {
            return "Apple";
        }

        static bool method4() 
        {
            return false;
        }

        static void method5(int x)
        {
            Console.WriteLine("The valeu given to me is {0}", x);
        }

        static void method6(int a, int b)
        {
            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, a + b);
        }

        static int getSum(int a, int b)
        {
            return a + b;
        }

        static int getNumFromUser()
        {
            int num = 0;
            string uInput = "";
            bool isNum = false;

            //Console.Clear();

            Console.Write("Please input a number : ");
            uInput = Console.ReadLine();

            isNum = int.TryParse(uInput, out num);

            if(!isNum)
            {
                Console.WriteLine("{0} is not a number... Press any key to continue...", uInput);
                Console.ReadKey();
                num = getNumFromUser();
            }

            return num;
        }

        static string forLoop(int curVal, int finalVal)
        {
            if(curVal < finalVal)
            {
                Console.WriteLine("Current value is {0}, Final Value is {1}", curVal, finalVal);
                forLoop(curVal + 1, finalVal);
            }

            return "Done";
        }

        static void Print(string message)
        {
            Console.Write(message);
        }

        static void PrintLine(string message) 
        {
            Print(message);
            Print("\n");
        }
    }
}
