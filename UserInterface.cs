using System;
using System.Collections.Generic;
using System.Linq;
using Game.ConsoleApp;

namespace Game.ConsoleApp
{
    public class UserInterface
    {
        //bool IsRunning - while loop
        private bool isRunning = true;
        public int budget = 0;
        public 
        string input = " ";
    

public void Run()
{
    while(isRunning)
    {
        PrintMainMenu();
        string name = Console.ReadLine();

    }


}

public void PrintMainMenu()
            {
                    Console.WriteLine("GameTitle \n \n Make a choice: \n 1. Play the game. \n 2. Learn about the game. \n 3. End");
                    input = Console.ReadLine();
switch (input)
{ 
     case "1":
     StartTheGame();
             return;
     case "2":
     AboutTheGame();
             return;
     case "3":
     isRunning = false;
             return;
    //  default:
    // isRunning = false;
    //          return;
            }
            }
public void StartTheGame()
{
    Console.WriteLine("You are working for a tech company when our adventure begins. Choose the size of your employment to start the story:\n1. super mega corporation \n2. regional company \n3. small start-up");
    input = Console.ReadLine();

    switch (input)
{
     case "1":
     budget = 3000;
     GetUserName();
             break;
     case "2":
     budget = 2000;
     GetUserName();
             break;
     case "3":
     budget = 1000;
     GetUserName();
             break;
     default:
    isRunning = false;
             break;
            }
            }


public void AboutTheGame()
{
    Console.WriteLine("When checking your email at work, you click a bad link and a virus takes over your computer. To gain functionality of your computer, the hacker has demanded that you answer a series of coding challenges correctly. Thankfully, you aren't alone in this, as the hacker has accessed your company's debit card information. So you have the option to buy resources to help you along the way, such as Trevor's helpline (used one time to provide a full answer to prompt), Praying mantis lucky spirit guide(provides a helpful hint when used during a challenge), Food (tomatoes, bread, and potatoes to keep up your health bar). \n\nYou also have the option to take breaks during your challenges that will reduce your stress level, but be careful, if you get too stressed, you will die! And if too much time passes, your boss will catch you in your mistake and fire you, and you may even eat a moldy potato and die! \n\nTo win, you must answer 4/4 questions correctly before the end of your work day. You must also stay alive under the pressure and the possibility of moldy potatoes");
}

private void GetUserName()
{
     Console.WriteLine("When checking your email at work, you click a bad link and a virus takes over your computer. To gain functionality of your computer, the hacker has demanded that you answer a series of coding challenges correctly. Thankfully, you aren't alone in this, as the hacker has accessed your company's debit card information. So you have the option to buy resources to help you along the way, such as Trevor's helpline (used one time to provide a full answer to prompt), Praying mantis lucky spirit guide(provides a helpful hint when used during a challenge), Food (tomatoes, bread, and potatoes to keep up your health bar). \n\nWhat is your name?\n");
     string name = Console.ReadLine();
     GameStore();
   
}

public void GameStore()
{
    Console.WriteLine($"Select an item to purchase\nYour budget is {budget}. \n1. Trevor's helpline: $800 \n2. Praying mantis lucky spirit guide: $200 \n3.Food (tomatoes, bread, and potatoes): $10/pound");

}
//  private char GetUserInput()
//                 {
//                     return Console.ReadLine();
//                 }


}
}