using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(quickMaths.Add("12","12"));
            Console.ReadKey();
        }
    }

    //Opgave 1: Overload

    class quickMaths
    {
    
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static float Minus(float a, float b)
        {
            return a - b;
        }
        
        public static float Divide(float a, float b)
        {
            return a / b;
        }

        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        //Opgave 2: Overload

        public static string Add(string a, string b)
        {
            int please;
            int work;

            Int32.TryParse(a, out please);
            Int32.TryParse(b, out work);

            return (please + work).ToString();
            
        }
    }
}

