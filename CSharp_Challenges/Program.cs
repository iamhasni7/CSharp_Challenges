using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Challenges
{
    //Challenge 01
    //Create a function that takes an array of numbers and returns the smallest number in the set.
    /*internal class Program
    {
        public static int[] Arr(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine(arr[0]);
            return arr;
        }

        static void Main(string[] args)
        {
            Arr(new int[] { 34,25, 5, 17, 59 });
            Console.ReadLine();
        }
    }*/

    //Challenge 02
    //Create a function that takes an array of numbers and returns the largest number in the set.
    /*internal class Program
    {
        public static int[] Arr(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine(arr[0]);
            return arr;
        }

        static void Main(string[] args)
        {
            Arr(new int[] {4, 8, 9, 1, 3});
            Console.ReadLine();
        }
    }*/

    //Challenge 03
    //Create a function that finds the index of a given item.
    /*internal class Program
    {
        static int[] Arr(int[] arr, int a)
        {
            int index = Array.IndexOf(arr, a);
            Console.WriteLine(index);
            return arr;
        }

        static void Main(string[] args)
        {
            Arr(new int[] { 9, 8, 3 }, 3);
            Console.ReadLine();
        }
    }*/

    //Challenge 04
    //Given three numbers, write a method that adds two first ones and multiplies them by a third one.
    /*internal class Program
    {
        int a, b, c;
        void AddAndMultiply(int a, int b, int c)
        {
            this.a = a;
            this.b = b; 
            this.c = c;

            int d = c * (a + b);
            Console.WriteLine("Result is: {0} ", d);
        }


        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.AddAndMultiply(2, 4, 5);

            Console.ReadLine();
        }
    }*/

    //Challenge 05
    //Given a temperature in Celsius degrees, write a method that converts it to Fahrenheit degrees.
    //Remember that temperature below -271.15°C (absolute zero) does not exist!
    /*internal class Program
    {
        double a;
        void CtoF(double a)
        {
            double b = this.a = a;

            if (b <= -271.15)
            {
                Console.WriteLine("Temperature below absolute zero!");
            }
            else
            {
                
                double result = (b * 9 / 5) + 32;
                Console.WriteLine(result);
            }            
        }
       
        static void Main(string[] args)
        {
           Program obj = new Program();
            obj.CtoF(-271.14);

            Console.ReadLine();
        }
    }*/

    //Challenge 06
    //Given two integers, write a method that returns results of their elementary arithmetic operations:
    //addition, substraction, multiplication, division. Remember that you can't divide any number by 0!
    /*internal class Program
    {
        int a, b;
       void Operations(int a, int b)
       {
            int x = this.a = a;
            int y = this.b = b;

            int add = x + y;
            Console.WriteLine(add);
            int sub = x - y;
            Console.WriteLine(sub);
            int mul = x * y;
            Console.WriteLine(mul);
            try
            {
                int div = x / y;
                Console.WriteLine(div);
            }
            catch
            {
                Console.WriteLine("Division by zero is not posible!");
            }
       }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Operations(3, 0);

            Console.ReadLine();
        }
    }*/

    //Challenge 07
    //Given two different arithmetic operations (addition, substraction, multiplication, division),
    //write a method that checks if they return the same result.
    /*internal class Program
    {
        int a, b;
        void IsResultTheSame(int a, int b)
        {
            int result1 = this.a = a;
            int result2 = this.b = b;

            if (result1 == result2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.IsResultTheSame(2+2, 2*3);

            Console.ReadLine();
        }
    }*/

    //Challenge 08
    //Given two integers, write a method that swaps them.
    /*internal class Program
    {
        int a, b;
        void SwapTwoNumbers(int a, int b)
        {
            int x = this.a = a;
            int y = this.b = b;

            int _x = this.a = b;
            int _y = this.b = a;


            Console.WriteLine("Before swapping: {0}, {1}", x, y);
            Console.WriteLine("After swapping: {0}, {1}", _x, _y);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.SwapTwoNumbers(6, 8);

            Console.ReadLine();
        }
    }*/
}
