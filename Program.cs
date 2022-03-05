using System;
namespace Lab_2_RPG
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //define initial vars and random generator
            System.Random randomNum = new System.Random();
            char rollKeep = 'r';
            string label = "";
            string[] attributeLabel = new string[6] { "STRENGTH", "DEXTERITY", "CONSTITUTION", "INTELLIGENCE", "WISDOM", "CHARISMA" };
            int[] attributes = new int[6];
            //allow for any key other than 'k'....how can we make it specific to 'k'?
            while (rollKeep != 'k')
            {
                //for(initial;condition;loop)
                //four dice lowest removed, remaining three summed repeated six times
                for (int attributes_dice = 0; attributes_dice < attributes.Length; attributes_dice++)
                {
                    int[] dice = new int[4];
                    for (int die = 0; die < dice.Length; die++)
                    {
                        dice[die] = randomNum.Next(0, 6) + 1;
                    }
                    System.Array.Sort(dice);
                    attributes[attributes_dice] = dice[1] + dice[2] + dice[3];
                }
                System.Console.WriteLine("\n\n******************************************");
                System.Console.WriteLine("These are your randomly generated scores: ");
                System.Console.WriteLine(" STRENGTH: " + "{0, 2}", attributes[0]);
                System.Console.WriteLine(" DEXTERITY: " + "{0, 2}", attributes[1]);
                System.Console.WriteLine(" CONSTITUTION: " + "{0, 2}", attributes[2]);
                System.Console.WriteLine(" INTELLIGENCE: " + "{0, 2}", attributes[3]);
                System.Console.WriteLine(" WISDOM: " + "{0, 2}", attributes[4]);
                System.Console.WriteLine(" CHARISMA: " + "{0, 2}", attributes[5]);
                System.Console.WriteLine("\n\n******************************************");
                System.Console.Write("Would you like to (k)eep these stats or (r)eroll? ");
                rollKeep = (System.Console.ReadLine()).ToCharArray()[0];
                System.Console.WriteLine();
            }
            //Race
            char race = '0';
            System.Console.WriteLine("\n\n******************************************");
            System.Console.WriteLine(" 1 - Dragonborn");
            System.Console.WriteLine(" 2 - Dwarf");
            System.Console.WriteLine(" 3 - Elf");
            System.Console.WriteLine(" 4 - Gnome");
            System.Console.WriteLine(" 5 - Half-Elf");
            System.Console.WriteLine(" 6 - Half-Orc");
            System.Console.WriteLine(" 7 - Halfling");
            System.Console.WriteLine(" 8 - Human");
            System.Console.WriteLine(" 9 - Tiefling");
            System.Console.WriteLine("\n\n******************************************");

            System.Console.Write("Choose a Race (1 - 9): ");
            while (race < '1' || race > '9')
            {
                race = (System.Console.ReadLine()).ToCharArray()[0];
            }
            System.Console.WriteLine();
            

            //subrace
            char subRace = '0';
            char statPickOne = '0';
            char statPickSecond = '0';
            if (race == '2')
            {
                System.Console.WriteLine(" 1 - Hill Dwarf");
                System.Console.WriteLine(" 2 - Mountain Dwarf");
                System.Console.WriteLine();
                System.Console.Write("Choose a Subrace (1 or 2) ");
                while (subRace < '1' || subRace > '2')
                {
                    subRace = (System.Console.ReadLine()).ToCharArray()[0];
                }
                System.Console.WriteLine();

            }
            if (race == '3')
            {
                System.Console.WriteLine(" 1 - Dark Elf");
                System.Console.WriteLine(" 2 - High Elf");
                System.Console.WriteLine(" 3 - Wood Elf");
                System.Console.WriteLine();
                System.Console.Write("Choose a Subrace (1 - 3) ");
                while (subRace < '1' || subRace > '3')
                {
                    subRace = (System.Console.ReadLine()).ToCharArray()[0];
                }
                System.Console.WriteLine();

            }
            if (race == '4')
            {
                System.Console.WriteLine(" 1 - Forest Gnome");
                System.Console.WriteLine(" 2 - Rock Gnome");
                System.Console.WriteLine();
                System.Console.Write("Choose a Subrace (1 or 2) ");
                while (subRace < '1' || subRace > '2')
                {
                    subRace = (System.Console.ReadLine()).ToCharArray()[0];
                }
                System.Console.WriteLine();
            }
            if (race == '5')
            {
                System.Console.WriteLine(" 1 - STRENGTH");
                System.Console.WriteLine(" 2 - DEXTERITY");
                System.Console.WriteLine(" 3 - CONSTITUTION");
                System.Console.WriteLine(" 4 - INTELLIGENCE");
                System.Console.WriteLine(" 5 - WISDOM");
                System.Console.WriteLine();
                System.Console.Write("Choose the FIRST of TWO attributes to increase: ");
                while (statPickOne < '1' || statPickOne > '5')
                {
                    statPickOne = (System.Console.ReadLine()).ToCharArray()[0];
                }
                if (statPickOne == '1')
                {
                    System.Console.WriteLine(" 1 - STRENGTH");
                }
                else if (statPickOne == '2')
                {
                    System.Console.WriteLine(" 2 - DEXTERITY");
                }
                else if (statPickOne == '3')
                {
                    System.Console.WriteLine("3 - CONSTITUTION");
                }
                else if (statPickOne == '4')
                {
                    System.Console.WriteLine(" 4 - INTELLIGENCE");
                }
                else
                {
                    System.Console.WriteLine(" 5 - WISDOM");
                }
                System.Console.WriteLine();
                System.Console.Write("Choose the SECOND of TWO attritbutes to increase: ");
                while (statPickSecond < '1' || statPickSecond > '5')
                {
                    statPickSecond = (System.Console.ReadLine()).ToCharArray()[0];
                }
                if (statPickSecond == '1')
                {
                    System.Console.WriteLine(" 1 - STRENGTH");
                }
                else if (statPickSecond == '2')
                {
                    System.Console.WriteLine(" 2 - DEXTERITY");
                }
                else if (statPickSecond == '3')
                {
                    System.Console.WriteLine("3 - CONSTITUTION");
                }
                else if (statPickSecond == '4')
                {
                    System.Console.WriteLine(" 4 - INTELLIGENCE");
                }
                else
                {
                    System.Console.WriteLine(" 5 - WISDOM");
                }
                System.Console.WriteLine();

            }
            if (race == '7')
            {
                System.Console.WriteLine(" 1 - Lightfoot");
                System.Console.WriteLine(" 2 - Stout");
                System.Console.Write("Choose a Subrace (1 or 2)");
                while (subRace < '1' || subRace > '2')
                {
                    subRace = (System.Console.ReadLine()).ToCharArray()[0];
                }
                System.Console.WriteLine();
            }
            

            //Set modifiers {Str,dex,con,int,wis,char}
            int[] raceMods = new int[6] { 0, 0, 0, 0, 0, 0 };

            if (race == '1')
            {
                label = "Dragonborn";
                //str+2,char+1
                raceMods = new int[6] { 2, 0, 0, 0, 0, 1 };
            }
            else if (race == '2')
            {
                //constitution
                raceMods = new int[6] { 0, 0, 2, 0, 0, 0 };
                if (subRace == '1')
                {
                    label = "Hill Dwarf";
                    //wisdom
                    raceMods[4] += 1;

                }
                else
                {
                    label = "Mountain Dwarf";
                    //strength
                    raceMods[0] += 2;
                }
            }
            else if (race == '3')
            {
                //dexterity
                raceMods = new int[6] { 0, 2, 0, 0, 0, 0 };
                if (subRace == '1')
                {
                    label = "Dark Elf";
                    //charisma
                    raceMods[5] += 1;
                }
                else if (race == '2')
                {
                    label = "High Elf";
                    //intelligence
                    raceMods[3] += 1;
                }
                else
                {
                    label = "Wood Elf";
                    //wisdom
                    raceMods[4] += 1;
                }
            }
            else if (race == '4')
            {
                //intelligence
                raceMods = new int[6] { 0, 0, 0, 2, 0, 0 };
                if (subRace == '1')
                {
                    label = "Forest Gnome";
                    //dexterity
                    raceMods[1] += 1;
                }
                else
                {
                    label = "Rock Gnome";
                    //constitution
                    raceMods[2] += 1;
                }


            }
            else if (race == '5')
            {
                label = "Half-Elf";
                //charisma and two picks
                raceMods = new int[6] { 0, 0, 0, 0, 0, 2 };
                raceMods[statPickOne - '1'] += 1;
                raceMods[statPickSecond - '1'] += 1;

            }
            else if (race == '6')
            {
                label = "Half-Orc";
                //str+2,con+1
                raceMods = new int[6] { 2, 0, 1, 0, 0, 0 };
            }
            else if (race == '7')
            {
                //dex
                raceMods = new int[6] { 0, 2, 0, 0, 0, 0 };
                if (subRace == '1')
                {
                    label = "Lightfoot";
                    //char
                    raceMods[5] += 1;
                }
                else
                {
                    label = "Stout";
                    //const
                    raceMods[2] += 1;
                }
            }
            else if (race == '8')
            {
                label = "Human";
                //all
                raceMods = new int[6] { 1, 1, 1, 1, 1, 1 };
            }
            else
            {
                label = "Tiefling";
                //int+1char+2
                raceMods = new int[6] { 0, 0, 0, 1, 0, 2 };

            }

            //display results
            System.Console.WriteLine("\n\n******************************************");
            System.Console.WriteLine($"{label}\n");
            
            for (int row = 0; row < attributes.Length; row++)
            {
                System.Console.WriteLine($"{attributeLabel[row]}: {(attributes[row] + raceMods[row]), 2} = {attributes[row],2} + {raceMods[row],2}");
            }
            System.Console.WriteLine("\n\n******************************************");

        }
    }
}
