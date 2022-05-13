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
Repository _repo = new Repository();
public void Run()
{
    while(isRunning)
    {
        PrintMainMenu();
        _repo.name = Console.ReadLine();
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
    Console.Clear();
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
    Console.WriteLine("\n Press any key to continue...");
    Console.ReadKey();
            }
public void AboutTheGame()
{
    Console.WriteLine("When checking your email at work, you click a bad link and a virus takes over your computer. To gain functionality of your computer, the hacker has demanded that you answer a series of coding challenges correctly. Thankfully, you aren't alone in this, as the hacker has accessed your company's debit card information. So you have the option to buy resources to help you along the way, such as Trevor's helpline (used one time to provide a full answer to prompt), Praying mantis lucky spirit guide(provides a helpful hint when used during a challenge), Food (tomatoes, bread, and potatoes to keep up your health bar). \n\nYou also have the option to take breaks during your challenges that will reduce your stress level, but be careful, if you get too stressed, you will die! And if too much time passes, your boss will catch you in your mistake and fire you, and you may even eat a moldy potato and die! \n\nTo win, you must answer 4/4 questions correctly before the end of your work day. You must also stay alive under the pressure and the possibility of moldy potatoes");
    Console.Clear();
    Console.WriteLine("\n Press any key to continue...");
    Console.ReadKey();
}
private void GetUserName()
{
     Console.WriteLine("When checking your email at work, you click a bad link and a virus takes over your computer. To gain functionality of your computer, the hacker has demanded that you answer a series of coding challenges correctly. Thankfully, you aren't alone in this, as the hacker has accessed your company's debit card information. So you have the option to buy resources to help you along the way, such as Trevor's helpline (used one time to provide a full answer to prompt), Praying mantis lucky spirit guide(provides a helpful hint when used during a challenge), Food (tomatoes, bread, and potatoes to keep up your health bar). \n\nWhat is your name?\n");
     _repo.name = Console.ReadLine();
     Console.WriteLine($"Hello, {_repo.name}! Let's get you to over to the store..");
    Console.WriteLine("\n Press any key to continue...");
    Console.ReadKey();
     GameStore();
}
public void GameStore()
{
    Console.Clear();
    Console.WriteLine($"Select an item to purchase\nYour budget is {budget}. \n1. Trevor's helpline: $800 \n2. Praying mantis lucky spirit guide: $200 \n3. Food (tomatoes, bread, and potatoes): $10/pound \n4. View Inventory \n5. Exit");
    input = Console.ReadLine();
     switch (input)
{
     case "1":
     Console.WriteLine("Would you like to purchase one Trevor's Helpline? \n y or n?");
     string yesOrNo = Console.ReadLine();
     if (yesOrNo == "y")
     {
         if (800 <= budget)
         {
         _repo.trevorHelp++;
         budget = budget - 800;
         Console.WriteLine("You have purchased one Trevor's Helpline.");
         GameStore();
         }
           else
         {
         Console.WriteLine("You do not have enough money to buy Trevor's Helpline.");
         GameStore();
         }
     }
     else
     {
         _repo.trevorHelp = 0;
         GameStore();
     }
             break;
     case "2":
     Console.WriteLine("How many Praying Mantis Lucky Spiritguides would you like to purchase?(Limit: 4)");
     _repo.prayingMantis = Convert.ToInt32(Console.ReadLine());
     if ((_repo.prayingMantis * 200) <= budget)
     {
      budget = budget - (_repo.prayingMantis * 200);
      Console.WriteLine($"You have purchased {_repo.prayingMantis} Praying Mantis Lucky Spiritguides!");
      GameStore();}
      else if ((_repo.prayingMantis * 200) >= budget)
      {
          Console.WriteLine("You do not have enough money to buy that many Praying Mantis Lucky Spiritguides.");
          GameStore();
      }
             break;
     case "3":
     Console.WriteLine("How many pounds of food would you like to purchase?");
     _repo.food = Convert.ToInt32(Console.ReadLine());
      if ((_repo.food * 10) <= budget)
     {
      budget = budget - (_repo.food * 10);
      Console.WriteLine($"You have purchased {_repo.food} pounds of food!");
      GameStore();
      }
      else if ((_repo.food * 20) >= budget)
      {
          Console.WriteLine("You do not have enough money to buy that much food.");
          GameStore();
      }
             break;
        case "4":
        Console.WriteLine($"1. Trevor's Helplines: {_repo.trevorHelp} \n2. Praying Mantis Lucky Spirit Guides: {_repo.prayingMantis} \n3. Food: {_repo.food} pounds of food");
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        GameStore();
        break;
        case "5":
        Console.WriteLine($"Are you sure you want to exit, {_repo.name}? y or n?");
        string noOrYes = Console.ReadLine();
        if (noOrYes == "y")
        {
            meetTaylor();
        }
        else
        {
            GameStore();
        }
        break;
     default:
    isRunning = false;
             break;
}
}
public void meetTaylor()
{
    Console.Clear();
    Console.WriteLine("Your computer screen goes black and blinks on and off like a strobe light. A strange text in Comic Sans appears on your screen: \n'I am Taylor the Evil Hacker, and your computer is MINE unless you can answer a series of the most difficult coding riddles in the most difficult programming language, C#!!!!!!! Do you accept this challenge?' \nType y or n");
    string yesOrNoo = Console.ReadLine();
    if (yesOrNoo == "y")
    {
        Console.WriteLine("Taylor the Evil Hacker: So it begins.....muahahahahahaha");
        firstChallenge();
    }
    else
    {
        isRunning = false;
    }
}
public void firstChallenge()
{
    Console.Clear();
    Console.WriteLine("Taylor the Evil Hacker: Given two numbers, add them WITHOUT using an addition operator. \nint add(int a, int b) \n{return       }\n\nFill in the blank with the correct response: \n\n1. View Inventory\n\n2. Take a break");
    string userAnswerOne = Console.ReadLine();
    string answer = "a-(-b);";
    if (userAnswerOne == answer)
    {
        Console.Clear();
        Console.WriteLine("Taylor the Evil Hacker: Yes, I suppose \n\n int add(int a, int b) \n{return a-(-b);} \n\nwas correct....Unfortunately. But I bet you cannot answer this next one!");
    }
    else if (userAnswerOne != answer)
    {
        Console.Clear();
        Console.WriteLine("Taylor the Evil Hacker: HAHAHAHAHAHAHAHAAH YOU FOOL! Now it's sudden DEATH with this next question. One more failure and your computer is MINE.");
    }
    else if (userAnswerOne == "1")
    {
        _repo.ProblemOne();
    }
}
}
    }