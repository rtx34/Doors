using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door
{
    class Program
    {
        static void Main(string[] args)
        {
        //ATRIBUTOS
            int PAS;
            Console.WriteLine("The door");
            PAS = int.Parse(Console.ReadLine());
            bool DoorOpen = false;
            bool DoorClosed = false;
            bool DoorLocked = false;
            bool DoorUnlocked = false;

            if (PAS == 1)
            {
                DoorOpen = true;
                Console.WriteLine("Door is open");
                if (DoorLocked = true)
                {
                    Console.WriteLine("error");
                }
            }
            if (PAS == 2)
            {
                DoorClosed = true;
                Console.WriteLine("Door is closed");
            }
            if (PAS == 3)
            {
                DoorLocked = true;
                Console.WriteLine("Door is locked");
            }
            if (PAS == 4)
            {
                DoorUnlocked = true;
                Console.WriteLine("Door is unlocked");
            }
        }
    }
}
