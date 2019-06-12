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

        public static int money = 0, roomCount = 0;
        public static int button = 0, generator = 0, lights1 = 0, stick = 0, key_lvl1 = 0, gas = 0;
        public static int lever = 0, Key1 = 0, Key2 = 0 ;
        public static int  hands = 0, flashlight = 0, hatchKey = 0, deskKey = 0;

        public static void level1()
        {
            Thread.Sleep(1000);
            Console.Clear();
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
            Thread.Sleep(1000);
            Console.Clear();
            int temp = 0;
            Console.WriteLine("At the top of the stairs there is a door");
            Console.WriteLine(" Open the Door: 1     Turn Around: 2");
            temp = Convert.ToInt32(Console.ReadLine());
            switch (temp)
            {
                case 1:
                    if (key_lvl1 == 1)
                    {
                        Console.WriteLine("You use the key you found and the door is now open and you exit the basement");
                        Thread.Sleep(1500);
                        lvl2();
                    }
                    else
                    {
                        Console.WriteLine("The door wont budge it seems to be locked");
                        level1_1a();
                    }
                    break;
                case 2:
                    level1_1b();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    level1_1a();
                    break;
            }

        }
        public static void level1_1b()
        {
            Thread.Sleep(1000);
            Console.Clear();
            int temp;
            if (lights1 == 0)
            {
                Console.WriteLine("You take a glance around the dark room you see a light switch, what looks like a generator and some boxes                ");
                Console.WriteLine(" Try to turn on the lights: 1   Turn on the generator: 2   Search the boxes: 3    Look around the corner of the room: 4  ");
                Console.WriteLine("                                                 Check the Door: 5                                                       ");
            }
            else if (lights1 == 1)
            {
                Console.WriteLine("             The room is now illuminated you can clearly see the light switch, generator and the boxes now               ");
                Console.WriteLine(" Try to turn on the lights: 1   Turn on the generator: 2   Search the boxes: 3    Look around the corner of the room: 4  ");
                Console.WriteLine("                                                 Check the Door: 5                                                       ");
            }
            temp = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(100);
            switch (temp)
            {
                case 1:
                    if (generator == 0)
                    {
                        Console.WriteLine("There is no power");
                        level1_1b();
                    }
                    else if (lights1 == 1)
                    {
                        Console.WriteLine("The lights are already on");
                        level1_1b();
                    }
                    else if (generator == 1 && lights1 == 0)
                    Console.WriteLine("You turn on the lights");
                    lights1 = 1;
                    level1_1b();
                    break;

                case 2:
                    if (gas == 0)
                    {
                        Console.WriteLine("There is no gas");
                        level1_1b();
                    }
                    else if (gas == 1)
                    {
                        Console.WriteLine("You turn on the generator");
                        gas = 2;
                        generator = 1;
                    }
                    else if (generator == 1)
                    Console.WriteLine("This is already turned on");
                    level1_1b();
                    break;

                case 3:
                    level1_1boxes();
                    break;

                case 4:
                    level1_2();
                    break;
                case 5:
                    level1_1a();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    level1_1b();
                    break;

            }
        }
        public static void level1_1boxes()
        {
            Thread.Sleep(1000);
            Console.Clear();
            if (generator == 0 && gas == 0)
            {
                Console.WriteLine("You check through the boxes and find some fuel to fill the generator");
                Thread.Sleep(500);
                gas = 1;
                level1_1b();
            }
            else if (generator == 1 && lights1 == 1 && stick == 0)
            {
                Console.WriteLine("You find a long stick it might be useful");
                Thread.Sleep(500);
                stick = 1;
                level1_1b();
            }
            else
            {
                Console.WriteLine("You find Nothing");
                Thread.Sleep(500);
                level1_1b();
            }
            
        }

        public static void level1_2()
        {
            Thread.Sleep(1000);
            Console.Clear();
            int temp;
            if (lights1 == 1 && key_lvl1 == 0)
            {
                Console.WriteLine("At the top of the large shelf something seems to be glimmering in the light");
                Console.WriteLine("         Try to reach the item: 1            Look Elsewhere: 2             ");
                temp = Convert.ToInt32(Console.ReadLine());
                switch (temp)
                {
                    case 1:
                        if (stick == 1)
                        {
                            Console.WriteLine("You use the stick you had to grab the item");
                            Console.WriteLine("         You now have a key!              ");
                            Thread.Sleep(300);
                            key_lvl1 = 1;
                            stick = 2;
                            level1_1b();
                        }
                        else
                        {
                            Console.WriteLine("It is too high to reach maybe I could find something to use");
                            Thread.Sleep(300);
                            level1_2();
                        }
                        break;
                    case 2:
                        level1_1b();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        level1_2();
                        break;
                }
            }
            else if (lights1 == 0)
            {
                Console.WriteLine("Its to dark to see anything better get some light first");
                Thread.Sleep(300);
                level1_1b();
            }
            else
            {
                Console.WriteLine("Nothing Else seems to be here");
                Console.WriteLine("Maybe I should try the door again");
                Thread.Sleep(300);
                level1_1b();
            }
        }
        public static void menu()
        {
            Console.WriteLine("     Do you want to play?     ");
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
                Thread.Sleep(700);
                Console.Clear();
                Main();
            }
            else
            {
                level1();
                Console.Clear();
            }
        }

        public static int knife; 

        public static void lvl2()
        {
            string decision, upperDecision;
            Console.Clear();

            if (roomCount == 0)
            {
                Console.WriteLine("Level 2: First Floor");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You've made your way to the kitchen. On the bench you see a knife.\nTo the west is a doorway that leads to the living room.\nTo the east is a strange door that emits a faint glow.");
            }
            else
            {
                if (knife == 1)
                {
                    Console.WriteLine("You're back in the kitchen. To the west is a doorway that leads to the living room.\nTo the east is a strange door that emits a faint glow.");
                    Console.WriteLine("What do you want to do?\nPress A to go to the living room.\nPress D to go to the strange door.");
                    decision = Console.ReadLine();
                    upperDecision = decision.ToUpper();
                    switch (upperDecision)
                    {
                        case "D":
                            roomCount++;
                            strangeDoor();
                            break;
                        case "A":
                            roomCount++;
                            livingRoomDark();
                            break;
                        default:
                            Console.WriteLine("You can't do that");
                            lvl2();
                            break;
                    }
                }
                Console.WriteLine("You're back in the kitchen. To the west is a doorway that leads to the living room.\nTo the east is a strange door that emits a faint glow.\nThe knife is still on the bench.");
                Console.WriteLine("What do you want to do?\nPress A to go to the living room.\nPress D to go to the strange door.\nPress E to pick up the knife.");
                decision = Console.ReadLine();
                upperDecision = decision.ToUpper();
                switch (upperDecision)
                {
                    case "D":
                        roomCount++;
                        strangeDoor();
                        break;
                    case "A":
                        roomCount++;
                        livingRoomDark();
                        break;
                    case "E":
                        Console.WriteLine("You pick the knife up thinking it might become useful later.");
                        Console.ReadLine();
                        knife++;
                        break;
                }
            }
            Console.WriteLine("What do you want to do?\nPress A to go to the living room.\nPress D to go to the strange door.\nPress E to pick up the knife.");
            decision = Console.ReadLine();
            upperDecision = decision.ToUpper();
            switch (upperDecision)
            {
                case "D":
                    roomCount++;
                    strangeDoor();
                    break;
                case "A":
                    roomCount++;
                    livingRoomDark();
                    break;
                case "E":
                    Console.WriteLine("You pick the knife up thinking it might become useful later.");
                    Console.ReadLine();
                    knife++;
                    break;
            }
        }
  
        public static void strangeDoor()
        {
            Console.Clear();

            string decision, upperDecision;
            Console.WriteLine("You walk up to the strange glowing door. Beside the door is a button.");
            Console.WriteLine("What do you want to do?\nPress A to go to the kitchen.\nPress E to press the button");
            decision = Console.ReadLine();
            upperDecision = decision.ToUpper();
            switch (upperDecision)
            {
                case "E":
                    eaButton();
                    break;

                case "A":
                    lvl2();
                    break;






            }


        }

        public static void eaButton()
        {
            string decision;
            Console.Clear();
            do
            {
                Console.WriteLine("You press the button and a deep voice booms from the door.");
                Console.WriteLine("\"Electric Arts has placed this door here to impede your progress. Pay $50 to pass!\"");
                decision = Console.ReadLine();
                decision.ToUpper();
                switch (decision)
                {
                    case "E":
                        if (money >= 50)
                        {
                            Console.WriteLine("The door opens and you make your way up the stairs.");
                            //Upstairs();
                        }
                        else
                        {
                            Console.WriteLine($"You do not have enough money. You need {50 - money} more dollars to open the door.");
                            Console.WriteLine("\nPress A to leave");
                            decision = Console.ReadLine();
                            decision.ToUpper();
                            if (decision == "A")
                            {
                                lvl2();
                            }
                        }
                        break;
                    case "A":
                        lvl2();
                        break;
                }
                Console.Clear();
            } while (decision != "A");
            
            
        }

        public static void livingRoomDark()
        {
            Console.Clear();
            string decision, upperDecision;
            Console.WriteLine("You arrive in the living room. It's too dark to see but you recall a light switch being by the door on your way in.");

            do
            {
                Console.WriteLine("What do you want to do?\nPress D to go to the kitchen.\nPress E to flick the light switch");
                decision = Console.ReadLine();
                upperDecision = decision.ToUpper();
                switch (upperDecision)
                {
                    case "E":
                        if (generator == 1)
                        {
                            livingRoomLight();
                        }
                        else
                        {
                            Console.WriteLine("The light switch doesn't work. You will need to find a different light source.");
                            Console.ReadLine();
                        }
                        break;
                    case "D":
                        lvl2();
                        break;
                    default:
                        Console.WriteLine("It is still too dark in the room to interact with anything.");
                        Console.ReadLine();
                        break;
                }
            } while (upperDecision != "D" || upperDecision != "E");
            
        }

        public static void livingRoomLight()
        {
            string livingRoomDecision;

            Console.WriteLine("You flick the switch and the lights turn on. Inside the living room is a coffee table, a TV, and a couple of couches.\nThere is a door to the north.");
            livingRoomDecision = Console.ReadLine();

        }









        public static void level_5A()
        {
            Console.WriteLine("You made it out Well Done!!");
        }

        public static void level4()
        {
            lever = 0;
            Console.Clear();
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
            if (lever == 1 && direction == "w")
            {
                level_5A();
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


        public static void level4D()
        {
            string direction;

            Console.WriteLine("You Approch the Second Door");
            Console.WriteLine("w Open Wooden Door, s Back To Main Room");
            direction = Console.ReadLine();
            while (Key2 != 1)
            {
                Console.WriteLine("The Door Doesnt Move, It Is Locked");
                Console.WriteLine("You take a step back to the center of the room");
                level4A();
            }
            Console.WriteLine("You push the door open and look into the room");

            Console.WriteLine("As you look into the Room you see a lever");
            Console.WriteLine(" What do you do? ");
            Console.WriteLine("w Pull Lever, s Exit room");
            direction = Console.ReadLine();

            switch (direction)
            {
                case "w":
                    Console.WriteLine("You hear a Bang come from the main room");
                    Console.WriteLine("You Rush into the Main room and see that the main door's locked has Moved");
                    lever = 1;
                    level4A();
                    break;
                case "s":
                    Console.WriteLine("You take a step back into the Main room");
                    level4A();
                    break;
            }



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
                Key1 = 1;
                Console.WriteLine("You take a step back to the center of the room");
                level4A();
            }
            else
            {
                Console.WriteLine("You take a step back to the center of the room");
                level4A();
            }

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



    //    public static void level3()
    //    {
    //        int choice;
    //        Console.Clear();
    //        Console.WriteLine("Level 3: Upstairs");
    //        Console.WriteLine("You arrive at the top of the stairs. There is a door to your left with a mysterious substance " +
    //            "dripping from the handle, a door to your right with a white 'X' painted on it. There is also a ladder leading " +
    //            "up to a hatch with a shiny lock attached. Is there another floor above?");
    //        Console.WriteLine();
    //        Console.WriteLine("1 - Left Door");
    //        Console.WriteLine("2 - Right Door");
    //        Console.WriteLine("3 - Ladder");
    //        Console.Write("Where are you going?: ");
    //        choice = Convert.ToInt32(Console.ReadLine());

    //        switch (choice)
    //        {
    //            case 1:
    //                leftDoor();
    //                break;

    //            case 2:
    //                rightDoor();
    //                break;

    //            case 3:
    //                ladder();
    //                break;
    //        }

    //    }

    //    public static void leftDoor()
    //    {
    //        int decision = 0;
    //        Console.Clear();
    //        Console.WriteLine("You approach the door on the left and open it, getting the weird substance all over your hands. It's" +
    //            "incredibly slippery and somewhat cold. Gross.");
    //        hands = 1;
    //        Console.WriteLine();
    //        Console.WriteLine("The room itself contains a number of paintings covered up by tarps, a dusty piano and a grimy looking" +
    //            "fish tank that's so cloudy you can't tell if there are any fish inside.");
    //        Console.WriteLine();
    //        Console.WriteLine("1 - Look at the paintings");
    //        Console.WriteLine("2 - Look at the piano");
    //        Console.WriteLine("3 - Look at the fish tank");
    //        Console.WriteLine("4 - Back to the main hall");
    //        Console.WriteLine();
    //        do
    //        {
    //            Console.Write("What will you do?: ");
    //            decision = Convert.ToInt32(Console.ReadLine());
    //        } while (decision == 0);

    //        switch (decision)
    //        {
    //            case 1:
    //                paintings();
    //                break;

    //            case 2:
    //                piano();
    //                break;

    //            case 3:
    //                tank();
    //                break;

    //            case 4:
    //                level3();
    //                break;
    //        }

    //    }

    //    public static void paintings()
    //    {
    //        int decision = 0;
    //        Console.Clear();
    //        Console.WriteLine("You uncover a few of the paintings. They all appear to be by the same artist. A painting of an" +
    //"elderly woman seems to be watching your every move. They're interesting but not useful.");
    //        Console.WriteLine();
    //        Console.WriteLine("1 - Look at the piano");
    //        Console.WriteLine("2 - Look at the fish tank");
    //        Console.WriteLine("3 - Back to the main hall");
    //        Console.WriteLine();
    //        do
    //        {
    //            Console.Write("What now?: ");
    //            decision = Convert.ToInt32(Console.ReadLine());
    //        } while (decision == 0);


    //        switch (decision)
    //        {
    //            case 1:
    //                piano();
    //                break;

    //            case 2:
    //                tank();
    //                break;

    //            case 3:
    //                level3();
    //                break;
    //        }

    //    }

    //    public static void piano()
    //    {
    //        Console.Clear();
    //        int decision = 0;
    //        Console.WriteLine("You run a hand along the old piano, unsettling the dust. Upon hitting one of the keys the instrument" +
    //            "makes a groaning sound. Huh? Something is stuck under the lid. A flashlight! Nice.");
    //        flashlight = 1;
    //        Console.WriteLine();
    //        Console.WriteLine("Flashlight acquired!");
    //        Console.WriteLine();
    //        Console.WriteLine("1 - Look at the paintings");
    //        Console.WriteLine("2 - Look at the fish tank");
    //        Console.WriteLine("3 - Back to the main hall");
    //        Console.WriteLine();
    //        do
    //        {
    //            Console.Write("What now?: ");
    //            decision = Convert.ToInt32(Console.ReadLine());
    //        } while (decision == 0);


    //        switch (decision)
    //        {
    //            case 1:
    //                paintings();
    //                break;

    //            case 2:
    //                tank();
    //                break;

    //            case 3:
    //                level3();
    //                break;
    //        }

    //    }

    //    public static void tank()
    //    {
    //        Console.Clear();
    //        int decision = 0;
    //        Console.WriteLine("You gaze into the fish tank. It doesn't look like anything is moving in there but the grimy water" +
    //        "makes you feel like something is lurking within. You gotta do what you gotta do. You clean the doorknob gunk off" +
    //        "of your hands. You swear you feel something brush your hand from inside the tank.");
    //        hands = 0;
    //        Console.WriteLine();
    //        Console.WriteLine("Your hands are now clean.");
    //        Console.WriteLine();
    //        Console.WriteLine("1 - Look at the paintings");
    //        Console.WriteLine("2 - Look at the piano");
    //        Console.WriteLine("3 - Back to the main hall");
    //        Console.WriteLine();
    //        do
    //        {
    //            Console.Write("What now?: ");
    //            decision = Convert.ToInt32(Console.ReadLine());
    //        } while (decision == 0);


    //        switch (decision)
    //        {
    //            case 1:
    //                paintings();
    //                break;

    //            case 2:
    //                piano();
    //                break;

    //            case 3:
    //                level3();
    //                break;
    //        }

    //    }

    //    public static void rightDoor()
    //    {
    //        int decision = 0;
    //        Console.Clear();
    //        if (flashlight == 0)
    //        {
    //            Console.WriteLine("You approach the door on the right, eyeing the ominous white 'X' and turn the knob. It's pitch black in" +
    //            "here. You can't see a thing. Better go back and find something to light the way.");
    //            Console.Write("Press Enter: ");
    //            Console.ReadLine();
    //            level3();
    //        }

    //        if (flashlight == 1)
    //        {
    //            Console.WriteLine("You approach the door on the right, eyeing the ominous white 'X' and turn the knob. It's pitch black in" +
    //            "here. You can't see a thing. Good thing you have a flashlight. *Click*. Now You can see an office-like room with filing cabinets," +
    //            "an old computer and a large oak desk.");
    //            Console.WriteLine();
    //            Console.WriteLine();
    //            Console.WriteLine("1 - Look at the filing cabinets");
    //            Console.WriteLine("2 - Look in the desk");
    //            Console.WriteLine("3 - Look at the computer");
    //            Console.WriteLine("4 - Back to the main hall");
    //            Console.WriteLine();
    //            do
    //            {
    //                Console.Write("What will you do?: ");
    //                decision = Convert.ToInt32(Console.ReadLine());
    //            } while (decision == 0);

    //            switch (decision)
    //            {
    //                case 1:
    //                    cabinets();
    //                    break;

    //                case 2:
    //                    desk();
    //                    break;

    //                case 3:
    //                    computer();
    //                    break;

    //                case 4:
    //                    level3();
    //                    break;
    //            }
    //        }
    //    }

    //    public static void cabinets()
    //    {
    //        Console.Clear();
    //        int decision = 0;
    //        Console.WriteLine("The filing cabinets are tall and dusty (like everything else..) You rifle around in" +
    //            "them finding lots of yellowed papers and.. Oh! A key. It doesn't look like it would fit the hatch" +
    //            "at the top of the ladder. What could it be for?");
    //        Console.WriteLine();
    //        Console.WriteLine("Small key acquired!");
    //        deskKey = 1;
    //        Console.WriteLine();
    //        Console.WriteLine("1 - Look in the desk");
    //        Console.WriteLine("2 - Look at the computer");
    //        Console.WriteLine("3 - Back to the main hall");
    //        Console.WriteLine();
    //        do
    //        {
    //            Console.Write("What now?: ");
    //            decision = Convert.ToInt32(Console.ReadLine());
    //        } while (decision == 0);


    //        switch (decision)
    //        {
    //            case 1:
    //                desk();
    //                break;

    //            case 2:
    //                computer();
    //                break;

    //            case 3:
    //                level3();
    //                break;
    //        }
    //    }

    //    public static void desk()
    //    {
    //        if (deskKey == 0)
    //        {
    //            Console.Clear();
    //            int decision = 0;
    //            Console.WriteLine("The desk is beautifully crafted. Surely there's something good stored inside." +
    //                "You pull at the drawer. Locked. There must be a key in here somewhere...");
    //            Console.WriteLine();
    //            Console.WriteLine("1 - Look at the filing cabinets");
    //            Console.WriteLine("2 - Look at the computer");
    //            Console.WriteLine("3 - Back to the main hall");
    //            Console.WriteLine();


    //            do
    //            {
    //                Console.Write("What now?: ");
    //                decision = Convert.ToInt32(Console.ReadLine());
    //            } while (decision == 0);


    //            switch (decision)
    //            {
    //                case 1:
    //                    cabinets();
    //                    break;

    //                case 2:
    //                    computer();
    //                    break;

    //                case 3:
    //                    level3();
    //                    break;
    //            }
    //        }

    //        if (deskKey == 1)
    //        {
    //            Console.Clear();
    //            int decision = 0;
    //            Console.WriteLine("The desk is beautifully crafted. Surely there's something good in here." +
    //                "You pull at the drawer. Locked. You try the small key you found earlier. Success! The drawer" +
    //                "opens. Inside is nothing but a ornate key. So shiny, it looks brand new.");
    //            Console.WriteLine();
    //            Console.WriteLine("Hatch key acquired!");
    //            hatchKey = 1;
    //            Console.WriteLine();
    //            Console.WriteLine("1 - Look at the filing cabinets");
    //            Console.WriteLine("2 - Look at the computer");
    //            Console.WriteLine("3 - Back to the main hall");
    //            Console.WriteLine();


    //            do
    //            {
    //                Console.Write("What now?: ");
    //                decision = Convert.ToInt32(Console.ReadLine());
    //            } while (decision == 0);


    //            switch (decision)
    //            {
    //                case 1:
    //                    cabinets();
    //                    break;

    //                case 2:
    //                    computer();
    //                    break;

    //                case 3:
    //                    level3();
    //                    break;
    //            }
    //        }
    //    }

    //    public static void computer()
    //    {
    //        Console.Clear();
    //        int decision = 0;
    //        Console.WriteLine("The computer looks out of place amongst everything else, even if it is old. You" +
    //            "turn it on. The only icon on the desktop is Minecraft. Maybe now isn't the time...");
    //        Console.WriteLine();
    //        Console.WriteLine("1 - Look at the filing cabinets");
    //        Console.WriteLine("2 - Look in the desk");
    //        Console.WriteLine("3 - Back to the main hall");
    //        Console.WriteLine();
    //        do
    //        {
    //            Console.Write("What now?: ");
    //            decision = Convert.ToInt32(Console.ReadLine());
    //        } while (decision == 0);


    //        switch (decision)
    //        {
    //            case 1:
    //                cabinets();
    //                break;

    //            case 2:
    //                desk();
    //                break;

    //            case 3:
    //                level3();
    //                break;
    //        }
    //    }

    //    public static void ladder()
    //    {
    //        Console.Clear();

    //        if (hands == 0 && hatchKey == 0)
    //        {
    //            Console.WriteLine("You approach the ladder and begin to climb. When you reach the hatch at the" +
    //                "top you realise you don't have a key to unlock it. Silly... Time to head back down.");
    //            Console.WriteLine();
    //            Console.Write("Press Enter: ");
    //            Console.ReadLine();
    //            level3();
    //        }

    //        if (hands == 0 && hatchKey == 1)
    //        {
    //            Console.WriteLine("You approach the ladder and climb, the key you found in the desk gripped firmly" +
    //                "in your hand. You carefully unlock the hatch and push it open, heading upwards towards your" +
    //                "next challenge.");
    //            Console.WriteLine();
    //            Console.Write("Press Enter: ");
    //            Console.ReadLine();
    //            level4();
    //        }

    //        if (hands == 1)
    //        {
    //            Console.WriteLine("You attempt to climb the ladder but the weird doorknob goop on your hands causes you to lose your grip" +
    //                "and you fall back to the ground. Ouch. Maybe you should get this stuff off...");
    //            Console.WriteLine();
    //            Console.Write("Press Enter: ");
    //            Console.ReadLine();
    //            level3();

    //        }

    //    }








    //    public static void levelfourAComplete()
    //    {
    //        Console.WriteLine("You made it out Well Done!!");
    //    }
    //    public static void MainDoor()
    //    {
    //        string direction, keyone, keytwo;

    //        Console.WriteLine("As you approch the Main Door You realise that there is no lock!! ");
    //        Console.WriteLine("What do you do?");
    //        Console.WriteLine("w Open Door, s Back To Main Room");
    //        direction = Console.ReadLine();
    //        if (button == 1 && direction == "w")
    //        {
    //            levelfourAComplete();
    //        }
    //        else if (direction == "w")
    //        {
    //            Console.WriteLine("The Door Didnt Move");
    //            levelfourA();
    //        }
    //        else
    //        {
    //            levelfourA();
    //        }

    //    }
    //    public static void FirstDoor()
    //    {

    //    }
    //    public static void SecondDoor()
    //    {

    //    }
    //    public static void woodenChest()
    //    {

    //    }
    //    public static void levelfourA()
    //    {
    //        string direction;

    //        Console.WriteLine("As you look into the Main room you see the Door you must exit through, " +
    //            "A large Wooden Chest and 2 other Doors");
    //        Console.WriteLine(" Where Do You Go? ");
    //        Console.WriteLine("w Main Door, a 1st Door, d 2nd Door, s Wooden Chest");
    //        direction = Console.ReadLine();

    //        switch (direction)
    //        {
    //            case "w":
    //                MainDoor();
    //                break;
    //            case "a":
    //                FirstDoor();
    //                break;
    //            case "d":
    //                SecondDoor();
    //                break;
    //            case "s":
    //                woodenChest();
    //                break;
    //        }
    //    }


    //    public static void levelfourAstart()
    //    {
    //        button = 0;
    //        Console.WriteLine("You Have Made It To Level Four");
    //        Console.WriteLine("To get to the End you must pass through the final door onto the roof!! ");
    //        levelfourA();
    //    }

    //    public static void Upstairs()
    //    {
    //        int choice;
    //        Console.WriteLine("Level 3: Upstairs");
    //        Console.WriteLine("You arrive at the top of the stairs. There is a door to your left with a mysterious substance " +
    //            "dripping from the handle, a door straight ahead with a strange sound coming from within and a door to your " +
    //            "right with a white 'X' painted on it. There is also a ladder which appears to lead to the roof.");
    //        Console.WriteLine();
    //        Console.WriteLine("1 - Left Door");
    //        Console.WriteLine("2 - Middle Door");
    //        Console.WriteLine("3 - Right Door");
    //        Console.WriteLine("4 - Ladder");
    //        Console.Write("Where are you going?: ");
    //        choice = Convert.ToInt32(Console.ReadLine());

    //        switch (choice)
    //        {
    //            case 1:
    //                leftDoor();
    //                break;

    //            case 2:
    //                middleDoor();
    //                break;

    //            case 3:
    //                rightDoor();
    //                break;

    //            case 4:
    //                ladder();
    //                break;
    //        }

    //    }

    //    public static void leftDoor()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("You enter the door on the left.");

    //    }

    //    public static void middleDoor()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("You enter the door straight ahead.");

    //    }

    //    public static void rightDoor()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("You enter the door on the right.");

    //    }

    //    public static void ladder()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("You attempt to climb the ladder.");

    //    }
        static void Main()
        {
            menu();
            //lvl2();
            //level1();
            //lvl2();
            //level3();
            //level4();
            //Upstairs();
            //Console.ReadLine();
        }


    }
}

    
