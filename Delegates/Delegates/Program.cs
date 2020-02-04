using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

public delegate void TomDelegate();

    class Byeah
    {

        public static void virk()
        {
            Console.WriteLine("I WORK");
        }
        public static void Main() {

            TomDelegate Tom = new TomDelegate(virk);

            Tom();

            Console.ReadKey();
        }

        

    }
}
