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
        public static int button, hands, flashlight;

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


        public static void level4()
        {
            button = 0;
            Console.WriteLine("You Have Made It To Level Four");
            Console.WriteLine("To get to the End you must pass through the final door onto the roof!! ");
            level4A();
        }

        public static void level4B()
        {
            string direction, keyone, keytwo;

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

        }
        public static void level4D()
        {

        }
        public static void level4E()
        {

        }

        public static void level3()
        {
            int choice;
            Console.WriteLine("Level 3: Upstairs");
            Console.WriteLine("You arrive at the top of the stairs. There is a door to your left with a mysterious substance " +
                "dripping from the handle, a door to your right with a white 'X' painted on it. There is also a ladder leading " +
                "up to a hatch. Is there another floor above?");
            Console.WriteLine();
            Console.WriteLine("1 - Left Door");
            Console.WriteLine("2 - Right Door");
            Console.WriteLine("3 - Ladder");
            Console.Write("Where are you going?: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    leftDoor();
                    break;

                case 2:
                    rightDoor();
                    break;

                case 3:
                    ladder();
                    break;
            }

        }

        public static void leftDoor()
        {
            int decision = 0;
            Console.Clear();
            Console.WriteLine("You approach the door on the left and open it, getting the weird substance all over your hands. It's" +
                "incredibly slippery and somewhat cold. Gross.");
            hands = 1;
            Console.WriteLine();
            Console.WriteLine("The room itself contains a number of paintings covered up by tarps, a dusty piano and a grimy looking" +
                "fish tank that's so cloudy you can't tell if there are any fish inside.");
            Console.WriteLine();
            Console.WriteLine("1 - Look at the paintings");
            Console.WriteLine("2 - Look at the piano");
            Console.WriteLine("3 - Look at the fish tank");
            Console.WriteLine("4 - Back to the main hall");
            Console.WriteLine();
            do
            {
                Console.Write("What will you do?: ");
            } while (decision == 0);

            switch (decision)
            {
                case 1:

                    paintings();
                    break;

                case 2:
                    piano();
                    break;

                case 3:
                    tank();
                    break;

                case 4:
                    level3();
                    break;
            }

        }

        public static void paintings()
        {
            int decision = 0;
            Console.Clear();
            Console.WriteLine("You uncover a few of the paintings. They all appear to be by the same artist. A painting of an" +
    "elderly woman seems to be watching your every move. They're interesting but not useful.");
            Console.WriteLine();
            Console.WriteLine("1 - Look at the piano");
            Console.WriteLine("2 - Look at the fish tank");
            Console.WriteLine("3 - Back to the main hall");
            Console.WriteLine();
            do
            {
                Console.Write("What now?: ");
            } while (decision == 0);


            switch (decision)
            {
                case 1:
                    piano();
                    break;

                case 2:
                    tank();
                    break;

                case 3:
                    level3();
                    break;
            }

        }

        public static void piano()
        {
            Console.Clear();
            int decision = 0;
            Console.WriteLine("You run a hand along the old piano, unsettling the dust. Upon hitting one of the keys the instrument" +
                "makes a groaning sound. Huh? Something is stuck under the lid. A flashlight! Nice.");
            Console.WriteLine();
            Console.WriteLine("1 - Look at the paintings");
            Console.WriteLine("2 - Look at the fish tank");
            Console.WriteLine("3 - Back to the main hall");
            Console.WriteLine();
            do
            {
                Console.Write("What now?: ");
            } while (decision == 0);


            switch (decision)
            {
                case 1:
                    paintings();
                    break;

                case 2:
                    tank();
                    break;

                case 3:
                    level3();
                    break;
            }

        }

        public static void tank()
        {
            Console.Clear();
            int decision = 0;
            Console.WriteLine("You gaze into the fish tank. It doesn't look like anything is moving in there but the grimy water" +
            "makes you feel like something is lurking within. You gotta do what you gotta do. You clean the doorknob gunk off" +
            "of your hands. You swear you feel something brush your hand from inside the tank.");
            hands = 0;
            Console.WriteLine();
            Console.WriteLine("1 - Look at the paintings");
            Console.WriteLine("2 - Look at the piano");
            Console.WriteLine("3 - Back to the main hall");
            Console.WriteLine();
            do
            {
                Console.Write("What now?: ");
            } while (decision == 0);


            switch (decision)
            {
                case 1:
                    paintings();
                    break;

                case 2:
                    piano();
                    break;

                case 3:
                    level3();
                    break;
            }

        }

        public static void rightDoor()
        {
            Console.Clear();
            if (flashlight == 0)
            {
                Console.WriteLine("You approach the door on the right, eyeing the ominous white 'X' and turn the knob. It's pitch black in" +
                "here. You can't see a thing. Better go back and find something to light the way.");
            }

            if (flashlight == 1)
            {
                Console.WriteLine("You approach the door on the right, eyeing the ominous white 'X' and turn the knob. It's pitch black in" +
                "here. You can't see a thing. Good thing you have a flashlight. *Click*. Now You can see an office-like room with filing cabinets," +
                "an old computer and a large oak desk.");
            }
        }

        public static void ladder()
        {
            Console.Clear();

            if (hands == 0)
            {
                Console.WriteLine("You attempt to climb the ladder.");
            }

            if (hands == 1)
            {
                Console.WriteLine("You attempt to climb the ladder but the weird doorknob goop on your hands causes you to lose your grip" +
                    "and you fall back to the ground. Ouch. Maybe you should get this stuff off...");
                Console.WriteLine();
                Console.WriteLine("1 - Left Door");
                Console.WriteLine("2 - Right Door");
                Console.WriteLine();
                Console.Write("What now?: ");
                
            }

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

    
