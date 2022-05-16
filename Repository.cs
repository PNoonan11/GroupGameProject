using System;
using System.Collections.Generic;
using System.Linq;
using Game.ConsoleApp;

namespace Game.ConsoleApp
{
    public class Repository
    {
        //UserInterface _ui = new UserInterface();
        //CRUD

        // Create
        public int trevorHelp;
        public int prayingMantis;
        public int food;
        public int healthBar = 100;
        public int stressBar = 20;
        public string name;
        public string answer;
        public int timePassed = 0;

        public void AddHealthAndStress()
        {
            stressBar = stressBar + 30;
            healthBar = healthBar - 50;
        }
        public void TaylorText()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void StandardText()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void TitleScreen()
        {
            Console.Title = "ASCII Art";
            string title = @"
  ██████  █████   ███    ██ ████████    ██████ ██ ██████ ██     ███████ 
██       ██   ██ ████  ████ ██            ██   ██   ██   ██     ██      
██   ███ ███████ ██ ████ ██ █████         ██   ██   ██   ██     █████   
██    ██ ██   ██ ██  ██  ██ ██            ██   ██   ██   ██     ██      
 ██████  ██   ██ ██      ██ ███████       ██   ██   ██   █████  ███████
                                                                     ";

            Console.WriteLine(title);
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

    }
}

