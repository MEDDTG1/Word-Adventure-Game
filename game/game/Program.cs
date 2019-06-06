using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
        public static int button, Key1, Key2;

        public static void level1()
        {
            int temp = 0;
            Console.WriteLine("You wake up on the cold hard floor of a dusty pitch black room \nnot sure where you are or how you got here.");
            Thread.Sleep(200);
            Console.WriteLine("For now your main objective should be to escape this mysterious house \nit seems there is a staircase leading upto a door\n");
            Thread.Sleep(200);
            Console.WriteLine(" Check the Door: 1       Look Elsewhere: 2");
            temp = Convert.ToInt32(Console.ReadLine());
            if (temp == 1)
            {
                level1_1a();
            }
            else
            {
                level1_1b();
            }
        }
        public static void level1_1a()
        {
            int temp = 0;
            Console.WriteLine("You check the door to see that it has a sign sayging 'Pay $14.99 to unlock' What do you do");
            Console.WriteLine(" Pay the 15 dollars: 1     Turn Around: 2");
            temp = Convert.ToInt32(Console.ReadLine());
            if (temp == 1)
            {
                EA_Ending();
            }
            else
            {
                level1_1b();
            }

        }
        public static void level1_1b()
        {
            Console.WriteLine("You fell down the stairs and died");
        }

        public static void EA_Ending()
        {
            Console.WriteLine("You open the door to a nice view of the bois in their car ready to hitup the KFC and scrrt down to the matukituki");
        }
        public static void menu()
        {
            Console.WriteLine("     Do you want to play     ");
            Console.WriteLine("");
            Console.WriteLine("    Play: 1         Exit: 0  ");
            int play;
            play = Convert.ToInt32(Console.ReadLine());
            if (play == 0)
            {
                System.Environment.Exit(0);
            }
            else if (play > 1)
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
                Main();
            }
            else
            {
                level1();
            }
        }


        public static void lvl2()
        {
            string decision;
            int count = 0;

            if (count <= 0)
            {
                Console.WriteLine("Level 2: First Floor");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You've made your way to the kitchen. On the bench you see a knife.\nTo the west is a doorway that leads to the living room.\nTo the east is a strange door that emits a faint glow.");
            }
            else
            {
                Console.WriteLine("You're back in the kitchen. To the west is a doorway that leads to the living room.\nTo the east is a strange door that emits a faint glow.");
            }

            decision = Console.ReadLine();

            switch (decision)
            {
                case "east":
                    strangeDoor();
                    count++;
                    break;
                case "west":
                    livingRoom();
                    count++;
                    break;
                case "knife":
                    break;


            }
        }

        public static void strangeDoor()
        {
            string decision;
            Console.WriteLine("You walk up to the strange glowing door. Beside the door is a button.");
            decision = Console.ReadLine();
            switch (decision)
            {
                case "button":
                    eaButton();
                    break;




            }


        }

        public static void eaButton()
        {
            Console.WriteLine("You press the button and a deep voice booms from the door.");
            Console.WriteLine("\"EA has placed this door here to impede your progress. Pay $50 to pass!\"");
            Console.ReadLine();
            //if ()
            //{

            //}
            //else
            //{
            //    Console.WriteLine("");
            //}
        }

        public static void livingRoom()
        {

        }












        public static void level_5A()
        {
            Console.WriteLine("You made it out Well Done!!");
        }

        public static void level4()
        {
            button = 0;
            Console.WriteLine("You Have Made It To Level Four");
            Console.WriteLine("To get to the End you must pass through the final door onto the roof!! ");
            level4A();
        }

        public static void level4A()
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
                    level4B();
                    break;
                case "a":
                    level4C();
                    break;
                case "d":
                    level4D();
                    break;
                case "s":
                    level4E();
                    break;
            }
        }


        public static void level4B()
        {
            string direction;

            Console.WriteLine("As you approch the Main Door You realise that there is no lock!! ");
            Console.WriteLine("What do you do?");
            Console.WriteLine("w Open Door, s Back To Main Room");
            direction = Console.ReadLine();
            if (button == 1 && direction == "w")
            {
                level4A();
            }
            else if (direction == "w")
            {
                Console.WriteLine("The Door Didnt Move");
                Console.WriteLine("You take a step back to the center of the room");
                level4A();
            }
            else
            {
                level4A();
            }

        }

        public static void level4C()
        {
            string direction;
          
            Console.WriteLine("You Approch the First Door");
            Console.WriteLine("w Open Wooden Door, s Back To Main Room");
            direction = Console.ReadLine();
            while (Key1 != 1)
            {
                Console.WriteLine("The Door Doesnt Move, It Is Locked");
                Console.WriteLine("You take a step back to the center of the room");
                level4A();
            }
            Console.WriteLine("You put the Wooden Key in to the Lock and BANG it opens and you enter");

            Console.WriteLine("As you look into the Room you see one book shelf holding five books");
            level4book();

        }

        public static void level4book()
        {
            string direction;

            Console.WriteLine("1 Grab Book 1, 2 Grab Book 2, 3 Grab Book 3, 4 Grab Book 4, 5 Grab Book 5, s Back To Main Room");
            direction = Console.ReadLine();
            switch (direction)
            {
                case "1":
                    Console.WriteLine("You grab the first book");
                    Console.WriteLine("The pages are empty");
                    Console.WriteLine("You place the book back");
                    level4book();
                    break;
                case "2":
                    Console.WriteLine("You grab the second book");
                    Console.WriteLine("The book is stuck ");
                    Console.WriteLine("You pull harder");
                    Console.WriteLine("BANG");
                    Console.WriteLine("The book slides forward and then back into place");
                    Console.WriteLine("You hear another bang from the main room");
                    Console.WriteLine("You rush back into the Main room to see that the Second Door is Now open");
                    Key2 = 1;
                    level4A();
                    break;
                case "3":
                    Console.WriteLine("You grab the second book");
                    Console.WriteLine("The book is stuck ");
                    Console.WriteLine("You pull harder");
                    Console.WriteLine("BANG");
                    Console.WriteLine("The book slides forward and then back into place");
                    Console.WriteLine("You hear another bang from the main room");
                    Console.WriteLine("You rush back into the Main room to see that the Main doors Lock is now half open");
                    level4A();
                    break;
                case "4":
                    Console.WriteLine("You grab the fourth book");
                    Console.WriteLine("The pages are empty");
                    Console.WriteLine("You place the book back");
                    level4book();
                    break;
                case "5":
                    Console.WriteLine("You grab the fith book");
                    Console.WriteLine("The pages are empty");
                    Console.WriteLine("You place the book back");
                    level4book();
                    break;
                case "s":
                    Console.WriteLine("You take a step back into the Main room");
                    level4A();
                    break;

            }
        }
        public static void level4D()
        {


        }
        public static void level4E()
        {
            string direction;

            Console.WriteLine("You Approch the Wooden Chest");
            Console.WriteLine("w Open Wooden Chest, s Back To Main Room");
            direction = Console.ReadLine();
            if (direction == "w")
            {
                Console.WriteLine("As you open the Wooden Chest you find a Wooden Key!! ");
                Key1 =  1;
                Console.WriteLine("You take a step back to the center of the room");
                level4A();
            }
            else
            {
                Console.WriteLine("You take a step back to the center of the room");
                level4A();
            }
        }

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
                    leftDoor();
                    break;

                case 2:
                    middleDoor();
                    break;

                case 3:
                    rightDoor();
                    break;

                case 4:
                    ladder();
                    break;
            }

        }

        public static void leftDoor()
        {
            Console.Clear();
            Console.WriteLine("You enter the door on the left.");

        }

        public static void middleDoor()
        {
            Console.Clear();
            Console.WriteLine("You enter the door straight ahead.");

        }

        public static void rightDoor()
        {
            Console.Clear();
            Console.WriteLine("You enter the door on the right.");

        }

        public static void ladder()
        {
            Console.Clear();
            Console.WriteLine("You attempt to climb the ladder.");

        }

        static void Main()
        {
            //menu();
            //lvl2();
            //level1();
            //level2();
            //level3();
            level4();
            //Upstairs();
            Console.ReadLine();






        }
    }
}

    
