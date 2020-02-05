using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvning
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Computer
    {
        public string label;
        public CPU cpu;
        public GPU gpu;
        public RAM ram;

        public bool isTurnedOn(bool a)
        {
            return a;
        }

        public bool isTurnedOff(bool a)
        {
            return a;
        }

        public bool isAsleep(bool a)
        {
            return a;
        }

    }

    class GPU
    {
        public string label;
        public string socket;
        public bool vrCompatible;
    }

    class CPU
    {
        public string label;
        public int Core;
        public string Socket;
    }

    class RAM
    {
        public string label;
        public int ram;
        public string socket;
    }

    class Console
    {
        public string SkærmSocket;
        public string lanSocket;
        public Controller controller;

        public void joinPeasants()
        {
            System.Console.WriteLine("You are now a Lesser Peasant");
        }

        public void brydeSammen()
        {
            System.Console.WriteLine("Error: 1337. Shouldve bought a PC");
        }

    }

    class bærbar
    {
        public Skærm indbyggetSkærm;
        public touchPad touchpad;
        public Charger charger;
        public string lanSocket;

        public bool klapSammen(bool a)
        {
            return a; 
        }
    }

    class mobiltelefon
    {
        public Skærm indbyggetSkærm;
        public Charger charger;
        public Cover cover;

        public void EquipCover()
        {
            System.Console.WriteLine("+15 Defense. +10 Weight");
        }

        public bool isSimcardInside(bool a)
        {
            return a;
        }
    }

    class Bil
    {
        public int hjul;
        public string motor;
        public int sædder;

        public bool isDriving(bool a)
        {
            return a;
        }
    }

    class stationær
    {
        public Kabinet kabinet;
        public string skærmSocket;
        public string lanSocket;

        public void joinMasterRace()
        {
            System.Console.WriteLine("Now playing: Final Fantasy 7 Victory Fanfare! WELCOME TO THE RANKS, KING");
        }

        public void Customize()
        {
            System.Console.WriteLine("Pimp your PC");
        }

    }

    class Controller
    {
        public string label;

        public bool isOff(bool a)
        {
            return a;
        }

        public bool isOn(bool a)
        {
            return a;
        }

        public void flæk()
        {
            System.Console.WriteLine("It did 15 damage");
        }
    }
        

    class touchPad
    {
        public string label;
        public int size;
        public double sensitivity;

        public bool isOn(bool a)
        {
            return a;
        }
    }

    class Cover
    {
        public string material;
        public string label;
        public int color;

        public void protecc()
        {
            System.Console.WriteLine("he protecc");
        }
    }

    class Skærm
    {
        public string label;
        public string size;
        public bool hasTouch;

        public void Dismantle()
        {
            System.Console.WriteLine("Have fun glueing that back together");
        }
    }

    class Kabinet
    {
        public string label;
        public string size;

        public bool isOpen(bool a)
        {
            return a;
        }
    }

    class Charger
    {
        public string label;
        public int color;
        public double Volt;

        public bool isPlugged(bool a)
        {
            return a;   
        }
    }
}
