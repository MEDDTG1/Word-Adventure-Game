using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
<<<<<<< HEAD
        public static int button;
       


        public static void levelfourAComplete()
        {
            Console.WriteLine("You made it out Well Done!!");
        }
        public static void MainDoor()
        {
            string direction, keyone,keytwo;

            Console.WriteLine("As you approch the Main Door You realise that there is no lock!! ");
            Console.WriteLine("What do you do?");
            Console.WriteLine("w Open Door, s Back To Main Room");
            direction = Console.ReadLine();
            if (button == 1 && direction == "w" )
            {
                levelfourAComplete();
            }
            else if(direction == "w")
            {
                Console.WriteLine("The Door Didnt Move");
                levelfourA();
            }
            else
            {
                levelfourA();
            }

        }
        public static void FirstDoor()
        {

        }
        public static void SecondDoor()
        {

        }
        public static void woodenChest()
        {

        }
        public static void levelfourA()
        {
            string direction;

            Console.WriteLine("As you look into the Main room you see the Door you must exit through, " +
                "A large Wooden Chest and 2 other Doors");
            Console.WriteLine(" Where Do You Go? ");
            Console.WriteLine("w Main Door, a 1st Door, d 2nd Door, s Wooden Chest");
            direction = Console.ReadLine();

            switch (direction)
            {
                case "w":
                    MainDoor();
                    break;
                case "a":
                    FirstDoor();
                    break;
                case "d":
                    SecondDoor();
                    break;
                case "s":
                    woodenChest();
                    break;
            }
        }
        

        public static void levelfourAstart()
        {
            button = 0;
            Console.WriteLine("You Have Made It To Level Four");
            Console.WriteLine("To get to the End you must pass through the final door onto the roof!! ");
            levelfourA();
        }

        static void Main()
        {
            levelfourAstart();
            Console.ReadLine();
=======
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
>>>>>>> ec922098fc22c5a423727c917328b93d8f9003cf
        }
    }
}
