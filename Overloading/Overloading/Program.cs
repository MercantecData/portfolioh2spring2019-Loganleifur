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
            
            inting bonus = quickMaths.Add;
            floating bonus1 = quickMaths.Add;
            stringing bonus2 = quickMaths.Add;

            Console.WriteLine(bonus(12, 12));
            Console.WriteLine(bonus1(12.9f, 12.3f));
            Console.WriteLine(bonus2("19", "50"));
        }
    }

    //Opgave 1: Overload

    public delegate int inting(int a, int b);
    public delegate float floating(float a, float b);
    public delegate string stringing(string a, string b);

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

