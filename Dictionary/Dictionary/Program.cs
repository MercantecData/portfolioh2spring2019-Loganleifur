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
            //Opgave 1: Dictionary
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

            
            //Opgave 2: Dictionary 

            Dictionary<float, bool> fictionary = new Dictionary<float, bool>();

            fictionary.Add(01, true);
            fictionary.Add(02, false);
            fictionary.Add(03, false);
            fictionary.Add(04, false);
            fictionary.Add(05, true);
            fictionary.Add(06, true);
            fictionary.Add(07, true);
            fictionary.Add(08, false);
            fictionary.Add(09, true);
            fictionary.Add(10, true);
        }
    }
}
