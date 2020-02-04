using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("Freeman", 17);
            dictionary.Add("bruhSoundEffect", 2);
            dictionary.Add("Powerlevel", 9001);
            dictionary.Add("Trashman", 99);
            dictionary.Add("SS", 3);
            dictionary.Add("test", 1);
            dictionary.Add("TheAnswer", 42);
            dictionary.Add("Order", 66);
            dictionary.Add("Dragonator", 10000);
            dictionary.Add("Megaman", 2);
            dictionary.Add("Gamer", 1337);
            Console.WriteLine(dictionary.Values);
            Console.ReadLine();
        }
    }
}
