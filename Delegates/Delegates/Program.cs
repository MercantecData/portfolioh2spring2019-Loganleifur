using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{


    class Panic
    {
        public delegate void TomDelegate();

        public static void virk()
        {
            Console.WriteLine("I WORK");
        }

        public static void Main()
        {

            TomDelegate Tom = virk;

            Tom();

            Console.ReadKey();
        }

    }

//    class second
//    {
//        public delegate float aDel();
//
//        public static void Chain()
//        {
//            Console.WriteLine("Keychain");
//            return;
//        }
//        public static void Main()
//        {
//            aDel Del = Chain;
//
//            aDel();
//
//
//        }
//    } 
}
