using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
        public static int money = 0, count = 0;
        public static void lvl2()
        {
            string decision;

            if (count == 0)
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
                    count++;
                    strangeDoor();
                    break;
                case "west":
                    count++;
                    livingRoomDark();
                    break;
                case "knife":
                    break;


            }
        }

        

        public static void strangeDoor()
        {
            Console.Clear();
            string decision;
            Console.WriteLine("You walk up to the strange glowing door. Beside the door is a button.");
            decision = Console.ReadLine();
            switch (decision)
            {
                case "button":
                    eaButton();
                    break;
                case "west":
                    lvl2();
                    break;
            }


        }

        public static void eaButton()
        {
            Console.Clear();
            Console.WriteLine("You press the button and a deep voice booms from the door.");
            Console.WriteLine("\"EA has placed this door here to impede your progress. Pay $50 to pass!\"");
            Console.ReadLine();
            if (money >= 50)
            {
                Console.WriteLine("The door opens and you make your way up the stairs.");
                //Upstairs();
            }
            else
            {
                Console.WriteLine($"You do not have enough money. You need ${50 - money} to open the door.");
            }
        }

        public static void livingRoomDark()
        {
            Console.Clear();
            string light;
            int generator = 1;
            Console.WriteLine("You arrive in the living room. It's too dark to see but you recall a light switch being by the door on your way in.");
            light = Console.ReadLine();
            if (light.Contains("on") == true && light.Contains("witch") == true)
            {
                if (generator == 1)
                {
                    livingRoomLight();
                }
                else
                {
                    Console.WriteLine("The light switch doesn't work. You will need to find a different light source.");
                    Console.ReadLine();
                }
            }
            else
            {
                if (light.Contains("ast") == true || light.Contains("back") == true)
                {
                    lvl2();
                }
                Console.WriteLine("It is still too dark in the room to interact with anything.");
                Console.ReadLine();
            }
            
            

        }

        public static void livingRoomLight()
        {
            string livingRoomDecision;

            Console.WriteLine("You flick the switch and the lights turn on. Inside the living room is a coffee table, a TV, and a couple of couches.\nThere is a door to the north.");
            livingRoomDecision = Console.ReadLine();

        }


























        static void Main()
        {
            lvl2();
        }

        //        public static int button;






        //        public static void levelfourAComplete()
        //        {
        //            Console.WriteLine("You made it out Well Done!!");
        //        }
        //        public static void MainDoor()
        //        {
        //            string direction, keyone,keytwo;

        //            Console.WriteLine("As you approch the Main Door You realise that there is no lock!! ");
        //            Console.WriteLine("What do you do?");
        //            Console.WriteLine("w Open Door, s Back To Main Room");
        //            direction = Console.ReadLine();
        //            if (button == 1 && direction == "w" )
        //            {
        //                levelfourAComplete();
        //            }
        //            else if(direction == "w")
        //            {
        //                Console.WriteLine("The Door Didnt Move");
        //                levelfourA();
        //            }
        //            else
        //            {
        //                levelfourA();
        //            }

        //        }
        //        public static void FirstDoor()
        //        {

        //        }
        //        public static void SecondDoor()
        //        {

        //        }
        //        public static void woodenChest()
        //        {

        //        }
        //        public static void levelfourA()
        //        {
        //            string direction;

        //            Console.WriteLine("As you look into the Main room you see the Door you must exit through, " +
        //                "A large Wooden Chest and 2 other Doors");
        //            Console.WriteLine(" Where Do You Go? ");
        //            Console.WriteLine("w Main Door, a 1st Door, d 2nd Door, s Wooden Chest");
        //            direction = Console.ReadLine();

        //            switch (direction)
        //            {
        //                case "w":
        //                    MainDoor();
        //                    break;
        //                case "a":
        //                    FirstDoor();
        //                    break;
        //                case "d":
        //                    SecondDoor();
        //                    break;
        //                case "s":
        //                    woodenChest();
        //                    break;
        //            }
        //        }


        //        public static void levelfourAstart()
        //        {
        //            button = 0;
        //            Console.WriteLine("You Have Made It To Level Four");
        //            Console.WriteLine("To get to the End you must pass through the final door onto the roof!! ");
        //            levelfourA();
        //        }

        //        static void Main()
        //        {
        //            levelfourAstart();
        //            Console.ReadLine();
        //        }

        //        public static void Upstairs()
        //        {
        //            int choice;
        //            Console.WriteLine("Level 3: Upstairs");
        //            Console.WriteLine("You arrive at the top of the stairs. There is a door to your left with a mysterious substance " +
        //                "dripping from the handle, a door straight ahead with a strange sound coming from within and a door to your " +
        //                "right with a white 'X' painted on it. There is also a ladder which appears to lead to the roof.");
        //            Console.WriteLine();
        //            Console.WriteLine("1 - Left Door");
        //            Console.WriteLine("2 - Middle Door");
        //            Console.WriteLine("3 - Right Door");
        //            Console.WriteLine("4 - Ladder");
        //            Console.Write("Where are you going?: ");
        //            choice = Convert.ToInt32(Console.ReadLine());

        //            switch (choice)
        //            {
        //                case 1:
        //                    leftDoor();
        //                    break;

        //                case 2:
        //                    middleDoor();
        //                    break;

        //                case 3:
        //                    rightDoor();
        //                    break;

        //                case 4:
        //                    ladder();
        //                    break;
        //            }

        //        }

        //        public static void leftDoor()
        //        {
        //            Console.Clear();
        //            Console.WriteLine("You enter the door on the left.");

        //        }

        //        public static void middleDoor()
        //        {
        //            Console.Clear();
        //            Console.WriteLine("You enter the door straight ahead.");

        //        }

        //        public static void rightDoor()
        //        {
        //            Console.Clear();
        //            Console.WriteLine("You enter the door on the right.");

        //        }

        //        public static void ladder()
        //        {
        //            Console.Clear();
        //            Console.WriteLine("You attempt to climb the ladder.");

        //        }

        //        static void Main(string[] args)
        //        {
        //            Upstairs();

        //        }
    }
}
