using System;
using System.Collections.Generic;
using System.Linq;
namespace Game.ConsoleApp
{
    public class UserInterface
    {
        //bool IsRunning - while loop
        private bool isRunning = true;
    

public void Run()
{
    while(isRunning)
    {
        PrintMainMenu();
        char input = GetUserInput();
        

    }




}

public void PrintMainMenu()
            {
                    Console.WriteLine("Hello World.");
switch (input){
     case 1:
         Console.WriteLine("its a ONE.");
             break;
     case 2:
         Console.WriteLine("its a TWO.");
             break;
     case 3:
         Console.WriteLine("its a THREE.");
             break;
     default:
         Console.WriteLine("I dunno?"); 
             break;
            }
            }
 private string GetUserInput()
                {
                    return Console.ReadLine();
                }


}}