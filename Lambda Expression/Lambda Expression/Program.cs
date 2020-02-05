using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    class Program
    {
        public delegate int opgave1(int a);
        public delegate float opgave2(float a, float b, float c);
        public delegate string opgave3();

        static void Main(string[] args)
        {

            opgave1 opg1 = x => x * 2;

            Console.WriteLine(opg1(12));

            opgave2 opg2 = (a, b, c) => a + b + c;

            Console.WriteLine(opg2(12,12,13));

            opgave3 opg3 = () => "Hello World";

            Console.WriteLine(opg3());


        }
    }
}
