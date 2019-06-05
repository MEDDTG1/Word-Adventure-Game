using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
        public static void Upstairs()
        {
            int choice;
            Console.WriteLine("Level 3: Upstairs");
            Console.WriteLine("You arrive at the top of the stairs. There is a door to your left with a mysterious substance " +
                "dripping from the handle, a door straight ahead with a strange sound coming from within and a door to your " +
                "right with a white 'X' painted on it. There is also a ladder which appears to lead to the roof.");
            Console.WriteLine();
            Console.WriteLine("1 - Left Door");
            Console.WriteLine("2 - Middle Door");
            Console.WriteLine("3 - Right Door");
            Console.WriteLine("4 - Ladder");
            Console.Write("Where are you going?: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;
            }

        }

        public static void leftDoor()
        {

        }

        public static void middleDoor()
        {

        }

        public static void rightDoor()
        {

        }

        public static void ladder()
        {

        }

        static void Main(string[] args)
        {
            Upstairs();
        }
    }
}
