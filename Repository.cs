using System;
using System.Collections.Generic;
using System.Linq;
using Game.ConsoleApp;

namespace Game.ConsoleApp
{
    public class Repository
    {
UserInterface _ui = new UserInterface();
        //CRUD

        // Create
        public int trevorHelp;
        public int prayingMantis;
        public int food;    
        public int healthBar = 100;    

        public string name;

        // Read
    public void ProblemOne()
    {
    Console.WriteLine($"1. Trevor's Helplines: {trevorHelp} \n2. Praying Mantis Lucky Spirit Guides: {prayingMantis} \n3. Food: {food} pounds of food \n4. Use Item \n5. Return to riddle.");
        string useItem = Console.ReadLine();
        if (useItem = "4")
        {
            Console.WriteLine("Which item would you like to use? Type 1, 2, or 3... or 4 to exit");
            string useWhichItem = Console.ReadLine();
            if (useWhichItem = "1" && trevorHelp == 1)
            {
                Console.WriteLine($"The answer to our first riddle is {_ui.answer}");
                trevorHelp --;
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _ui.firstChallenge();
            }
            else if (useWhichItem = "1" && trevorHelp == 0)
            {
                Console.WriteLine("Oops, Trevor cannot help you this time.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _ui.firstChallenge();
            }
            else if (useWhichItem = "1" && prayingMantis >= 1)
            {
                Console.WriteLine("The Praying Mantis Lucky Spirit Guide whispers to follow the OPPOSITE path to reach your life goals");
                prayingMantis --;
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _ui.firstChallenge();
            }
            else if (useWhichItem = "2" && prayingMantis <= 1 )
            {
                Console.WriteLine("The Praying Mantis Lucky Spirit Guide whispers I am far to weak to assist you in your journey without $200....");                
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _ui.firstChallenge();
            }
            else if (useWhichItem = "3" && food >= 1)
            {
              Console.WriteLine("How much food would you like to eat?");
              int foodEaten = Convert.ToInt32(Console.ReadLine());
              food = food - foodEaten;
              healthBar = healthBar + foodEaten;
               Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _ui.firstChallenge();
            }
            else if (useWhichItem = "3" && food <= 1)
            {
              Console.WriteLine("You do not have any food left.");
              Console.WriteLine("Press any key to continue...");
              Console.ReadKey();
              _ui.firstChallenge();
            }
            else if (useWhichItem = "4")
            {
                Console.WriteLine($"{name}, Taylor the Evil Hacker is waiting for you....Time to solve that riddle.");
               Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _ui.firstChallenge();
            }
            }
        }
    }


        // Update
        // Delete
    }
