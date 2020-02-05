using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{


    class Panic
    {
        public delegate void Opgave1();
        public delegate float Opgave2();
        public delegate void Opgave3(int a, string b, int c);
        

        

        public static void Main()
        {

            Opgave1 Tom = () => Console.WriteLine("Work time");

            Tom();

            Opgave2 vibe = () => 14.2f;
            
            Console.WriteLine(vibe());

            Opgave3 three = (a, b, c) => Console.WriteLine("oh yeah big brain time");

            three(14,"ooh",12);

            Console.ReadKey();
        }
 
    }

}
