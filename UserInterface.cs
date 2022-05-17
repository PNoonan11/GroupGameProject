using System;
using System.Collections.Generic;
using System.Linq;
using Game.ConsoleApp;
namespace Game.ConsoleApp
{
    public class UserInterface
    {
        private bool isRunning = true;
        public int budget = 0;

        public string input;


        Repository _repo = new Repository();

        public void Run()
        {
            while (isRunning)
            {
                PrintMainMenu();
                _repo.name = Console.ReadLine();
            }
        }
        public void PrintMainMenu()
        {
            //_repo.Credits(); //For testing
            _repo.StandardText();
            _repo.TitleScreen();
            Console.WriteLine("\nCoding Hero  \n \n Make a choice: \n 1. Play the game. \n 2. Learn about the game. \n 3. Exit Game");
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
            }
        }
        public void StartTheGame()
        {
            _repo.StandardText();
            Console.Clear();
            Console.WriteLine("You are working for a tech company when our adventure begins. Choose the size of your employer to start the story:\n\n1. super mega corporation \n2. regional company \n3. small start-up");
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
                    Console.Clear();
                    Console.WriteLine("Invalid input - Try again...");
                    Console.WriteLine("\nPress any key to continue....");
                    Console.ReadKey();
                    StartTheGame();
                    break;
            }
            Console.WriteLine("\n Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public void AboutTheGame()
        {
            _repo.StandardText();
            Console.Clear();
            Console.WriteLine("When checking your email at work, you click a bad link and a virus takes over your computer. To gain functionality of your computer, the hacker has demanded that you answer a series of coding challenges correctly. Thankfully, you aren't alone in this, as the hacker has accessed your company's debit card information. So you have the option to buy resources to help you along the way, such as Trevor's helpline (used one time to provide a full answer to prompt), Praying mantis lucky spirit guide(provides a helpful hint when used during a challenge), Food (tomatoes, bread, and potatoes to keep up your health bar). \n\nYou also have the option to take breaks during your challenges that will reduce your stress level, but be careful, if you get too stressed, you will die! And if too much time passes, your boss will catch you in your mistake and fire you!! \n\nTo win, you must answer 3/4 questions correctly before the end of your work day. You must also stay alive under the pressure of passing the hacker's challenges.");
            Console.WriteLine("\n Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            PrintMainMenu();
        }
        private void GetUserName()
        {
            Console.Clear();
            Console.WriteLine("When checking your email at work, you click a bad link and a virus takes over your computer. To gain functionality of your computer, the hacker has demanded that you answer a series of coding challenges correctly. Thankfully, you aren't alone in this, as the hacker has accessed your company's debit card information. So you have the option to buy resources to help you along the way, such as Trevor's helpline (used one time to provide a full answer to prompt), Praying mantis lucky spirit guide(provides a helpful hint when used during a challenge), Food (tomatoes, bread, and moldy potatoes to keep up your health bar). \n\nWhat is your name?\n");
            _repo.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hello, {_repo.name}! Let's get you to over to the store..");
            Console.WriteLine("\n Press any key to continue...");
            Console.ReadKey();
            GameStore();
        }
        public void GameStore()
        {
            Console.Clear();
            Console.WriteLine($"Select items to purchase\n\nYour budget is {budget}. \n\n1. Trevor's helpline - Use for the answer from the c# guru himself: $800 \n2. Praying mantis lucky spirit guide - Use for a whimsical hint about the answer: $200  \n3. Food (tomatoes, bread, and moldy potatoes - Use to increase your health): $10/pound \n4. View Inventory \n5. Exit Store and Begin Game");
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
                        GameStore();
                    }
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
                    Console.Clear();
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
                    Console.Clear();
                    Console.WriteLine("Invalid input - Try again...");
                    Console.WriteLine("\nPress any key to continue....");
                    Console.ReadKey();
                    GameStore();
                    break;
            }
        }
        public void meetTaylor()
        {
            Console.Clear();
            _repo.TaylorText();
            Console.WriteLine("Your computer screen goes black and blinks on and off like a strobe light. A strange text in Comic Sans appears on your screen: \n'I am Taylor the Evil Hacker, and it is my mission to STEAL all of the technology in the world to revert us back to the GOOD OLD DAYS!!! Your computer is MINE unless you can answer a series of the most difficult coding riddles!!!!!!! Do you accept this challenge?' \nType y or n");
            string yesOrNoo = Console.ReadLine();
            if (yesOrNoo == "y")
            {
                Console.WriteLine("Taylor the Evil Hacker: So it begins.....muahahahahahaha");

                FirstChallenge();
            }
            else if (yesOrNoo == "n")
            {
                PrintMainMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input - Try again...");
                Console.WriteLine("\nPress any key to continue....");
                Console.ReadKey();
                meetTaylor();
            }
        }
        public void FirstChallenge()
        {
            _repo.StandardText();
            _repo.answer = "a-(-b);";
            Console.Clear();
            Console.WriteLine("Taylor the Evil Hacker: Given two numbers, add them WITHOUT using an addition operator. \nint add(int a, int b) \n'{return       }'\n\nFill in the blank with the correct response: \n\n1. View Inventory\n\n2. Take a break");
            Console.WriteLine($"\nHealth: {_repo.healthBar}\nStress: {_repo.stressBar}");
            string userAnswerOne = Console.ReadLine();
            if (userAnswerOne == _repo.answer)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine("Taylor the Evil Hacker: Yes, I suppose \n\n int add(int a, int b) \n{return a-(-b);} \n\nwas correct....Unfortunately. But I bet you cannot answer this next one!");
                _repo.StandardText();
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                SecondChallenge();
            }
            else if (userAnswerOne == "1")
            {
                ProblemOne();
            }
            else if (userAnswerOne == "2")
            {
                TakeABreak();
            }
            else if (userAnswerOne != _repo.answer)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine("Taylor the Evil Hacker: HAHAHAAHAHHAAH YOU FOOL! Your JOB...your COMPUTER...your LIFE...the ERA OF THE MACHINE is OVER! \nYou have lost\n\nPress any key to continue...");
                Console.ReadKey();
                PrintMainMenu();
            }
        }
        public void ProblemOne()
        {
            _repo.StandardText();
            Console.WriteLine($"1. Trevor's Helplines: {_repo.trevorHelp} \n2. Praying Mantis Lucky Spirit Guides: {_repo.prayingMantis} \n3. Food: {_repo.food} pounds of food \n4. Use Item \n5. Return to riddle.");
            string useItem = Console.ReadLine();
            if (useItem == "4")
            {
                Console.WriteLine("Which item would you like to use? Type 1, 2, or 3... or 4 to exit");
                string useWhichItem = Console.ReadLine();
                switch (useWhichItem)
                {
                    case "1":
                        if (_repo.trevorHelp == 1)
                        {
                            Console.WriteLine($"The answer to our second riddle is {_repo.answer}");
                            _repo.trevorHelp--;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            FirstChallenge();
                        }
                        else if (_repo.trevorHelp == 0)
                        {
                            Console.WriteLine("Oops, Trevor cannot help you this time.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            FirstChallenge();
                        }
                        break;

                    case "2":
                        {
                            if (_repo.prayingMantis >= 1)
                            {
                                Console.WriteLine("The Praying Mantis Lucky Spirit Guide whispers to follow the OPPOSITE path to reach your life goals");
                                _repo.prayingMantis--;
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                FirstChallenge();
                            }
                            else if (_repo.prayingMantis <= 1)
                            {
                                Console.WriteLine("The Praying Mantis Lucky Spirit Guide whispers I am far to weak to assist you in your journey without $200....");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                FirstChallenge();
                            }
                            break;
                        }
                    case "3":
                        {
                            if (_repo.food >= 1)
                            {
                                Console.WriteLine("How much food would you like to eat?");
                                int foodEaten = Convert.ToInt32(Console.ReadLine());
                                _repo.food = _repo.food - foodEaten;
                                _repo.healthBar = _repo.healthBar + (foodEaten * 10);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                FirstChallenge();
                            }
                            else if (_repo.food <= 1)
                            {
                                Console.WriteLine("You do not have any food left.");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                FirstChallenge();
                            }
                            break;
                        }

                    case "4":
                        {
                            _repo.TaylorText();
                            Console.WriteLine($"{_repo.name}, Taylor the Evil Hacker is waiting for you....Time to solve that riddle.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            FirstChallenge();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input - Try again...");
                            Console.WriteLine("\nPress any key to continue....");
                            Console.ReadKey();
                            ProblemOne();
                            break;
                        }
                }
            }
            else if (useItem == "5")
            {
                Console.WriteLine($"{_repo.name}, Taylor the Evil Hacker is waiting for you....Time to solve that riddle.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                FirstChallenge();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input - Try again...");
                Console.WriteLine("\nPress any key to continue....");
                Console.ReadKey();
                ProblemOne();
            }
        }
        public void TakeABreak()
        {
            _repo.StandardText();
            Console.Clear();
            Console.WriteLine("Are you sure you want to take a break? \nType y or n");
            string yessOrNoo = Console.ReadLine();
            if (yessOrNoo == "y")
            {
                Console.Clear();
                Console.WriteLine("You have taken a break for one hour \n Press any key to continue.");
                Console.ReadKey();
                _repo.stressBar = _repo.stressBar - 30;
                _repo.timePassed++;
                FirstChallenge();
            }
            else
            {
                Console.Clear();
                FirstChallenge();
            }
        }

        public void SecondChallenge()
        {

            _repo.stressBar = _repo.stressBar + 30;
            _repo.healthBar = _repo.healthBar - 50;
            if (_repo.healthBar <= 0)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine($"{_repo.name} has died of starvation. \nYou have lost.\nPress any key to continue...");
                Console.ReadKey();
                PrintMainMenu();
            }
            else if (_repo.stressBar >= 100)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine($"{_repo.name} has died of overstress. \nYou have lost.\nPress any key to continue...");
                Console.ReadKey();
                PrintMainMenu();
            }
            else if (_repo.timePassed >= 3)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine($"{_repo.name}, too much time has passed, and your boss has fired you for getting hacked by a supervillain. \nYou have lost.\nPress any key to continue...");
                Console.ReadKey();
                PrintMainMenu();
            }
            _repo.answer = "modulus";
            Console.Clear();
            _repo.TaylorText();
            Console.WriteLine("Taylor the Evil Hacker: Are you ready for your next challenge???");
            _repo.StandardText();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            _repo.TaylorText();
            Console.WriteLine("Taylor the Evil Hacker: WAIT I DON'T CARE! You're DOOMED to failure this time. I know the FizzBuzz case is one you cannot solve. \n\n What is the operator called that you would use to solve a FIZZBUZZ case?");
            _repo.StandardText();
            Console.WriteLine($"\n\n1. View Inventory\n\n2. Take a break\n\nHealth: {_repo.healthBar}\nStress: {_repo.stressBar}");
            Console.WriteLine("\nType your answer or enter a menu number:\n");
            string userAnswerOne = Console.ReadLine();
            if (userAnswerOne == _repo.answer)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine("Taylor the Evil Hacker: DRATS you have fooled me this time...Next time I will get you and your little dog, too!!");
                _repo.StandardText();
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                ThirdChallenge();
            }
            else if (userAnswerOne == "1")
            {
                _repo.AddHealthAndStress();
                ProblemTwo();
            }
            else if (userAnswerOne == "2")
            {
                TakeASecondBreak();
            }
            else if (userAnswerOne != _repo.answer)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine("Taylor the Evil Hacker: HAHAHAAHAHHAAH YOU FOOL! Your JOB...your COMPUTER...your LIFE...the ERA OF THE MACHINE is OVER! \nYou have lost\n\nPress any key to continue...");
                Console.ReadKey();
                PrintMainMenu();
            }


        }

        public void ProblemTwo()
        {
            _repo.StandardText();
            Console.WriteLine($"1. Trevor's Helplines: {_repo.trevorHelp} \n2. Praying Mantis Lucky Spirit Guides: {_repo.prayingMantis} \n3. Food: {_repo.food} pounds of food \n4. Use Item \n5. Return to riddle.");
            string useItem = Console.ReadLine();
            if (useItem == "4")
            {
                Console.WriteLine("Which item would you like to use? Type 1, 2, or 3... or 4 to exit");
                string useWhichItem = Console.ReadLine();
                switch (useWhichItem)
                {
                    case "1":
                        if (_repo.trevorHelp == 1)
                        {
                            Console.WriteLine($"The answer to our first riddle is {_repo.answer}");
                            _repo.trevorHelp--;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            _repo.AddHealthAndStress();
                            SecondChallenge();
                        }
                        else if (_repo.trevorHelp == 0)
                        {
                            Console.WriteLine("Oops, Trevor cannot help you this time.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            _repo.AddHealthAndStress();
                            SecondChallenge();
                        }
                        break;

                    case "2":
                        {
                            if (_repo.prayingMantis >= 1)
                            {
                                Console.WriteLine("The Praying Mantis Lucky Spirit Guide whispers to think of life in terms of percentages.");
                                _repo.prayingMantis--;
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                _repo.AddHealthAndStress();
                                SecondChallenge();
                            }
                            else if (_repo.prayingMantis <= 1)
                            {
                                Console.WriteLine("The Praying Mantis Lucky Spirit Guide whispers I am far too weak to assist you in your journey without $200....");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                _repo.AddHealthAndStress();
                                SecondChallenge();

                            }
                            break;
                        }
                    case "3":
                        {
                            if (_repo.food >= 1)
                            {
                                Console.WriteLine("How much food would you like to eat?");
                                int foodEaten = Convert.ToInt32(Console.ReadLine());
                                _repo.food = _repo.food - foodEaten;
                                _repo.healthBar = _repo.healthBar + (foodEaten * 10);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                _repo.AddHealthAndStress();
                                SecondChallenge();
                            }
                            else if (_repo.food <= 1)
                            {
                                Console.WriteLine("You do not have any food left.");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                _repo.AddHealthAndStress();
                                SecondChallenge();
                            }
                            break;
                        }

                    case "4":
                        {
                            Console.WriteLine($"{_repo.name}, Taylor the Evil Hacker is waiting for you....Time to solve that riddle.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            _repo.AddHealthAndStress();
                            SecondChallenge();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input - Try again...");
                            Console.WriteLine("\nPress any key to continue....");
                            Console.ReadKey();
                            ProblemTwo();
                            break;
                        }
                }
            }
            else if (useItem == "5")
            {
                Console.WriteLine($"{_repo.name}, Taylor the Evil Hacker is waiting for you....Time to solve that riddle.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _repo.AddHealthAndStress();
                SecondChallenge();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input - Try again...");
                Console.WriteLine("\nPress any key to continue....");
                Console.ReadKey();
                ProblemTwo();
            }



        }


        public void TakeASecondBreak()
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to take a break? \nType y or n");
            string yessOrNoo = Console.ReadLine();
            if (yessOrNoo == "y")
            {
                Console.Clear();
                Console.WriteLine("You have taken a break for one hour \n Press any key to continue.");
                Console.ReadKey();
                _repo.stressBar = _repo.stressBar - 30;
                _repo.timePassed++;
                _repo.AddHealthAndStress();
                SecondChallenge();
            }
            else
            {
                Console.Clear();
                _repo.AddHealthAndStress();
                SecondChallenge();
            }
        }

        public void ThirdChallenge()
        {
            _repo.stressBar = _repo.stressBar + 30;
            _repo.healthBar = _repo.healthBar - 50;
            if (_repo.healthBar <= 0)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine($"{_repo.name} has died of starvation. \nYou have lost.\nPress any key to continue...");
                Console.ReadKey();
                PrintMainMenu();
            }
            else if (_repo.stressBar >= 100)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine($"{_repo.name} has died of overstress. \nYou have lost.\nPress any key to continue...");
                Console.ReadKey();
                PrintMainMenu();
            }
            else if (_repo.timePassed >= 3)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine($"{_repo.name}, too much time has passed, and your boss has fired you for getting hacked by a supervillain. \nYou have lost.\nPress any key to continue...");
                Console.ReadKey();
                PrintMainMenu();
            }
            _repo.answer = "30";
            Console.Clear();
            _repo.TaylorText();
            Console.WriteLine("Taylor the Evil Hacker: This is the LAST challenge you will receive, as I know it is one that will DOOM you to failure and a life with NO TECHNOLOGY!! Muahahahahhaha");
            _repo.StandardText();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            _repo.TaylorText();
            Console.WriteLine("Taylor the Evil Hacker: \nint[] myNum = {10, 20, 30, 40}; \nmyNum[0] = 7; \nWhat number would myNum[3] return? \n\n1. View Inventory\n\n2. Take a break");
            _repo.StandardText();
            Console.WriteLine($"\nHealth: {_repo.healthBar}\nStress: {_repo.stressBar}");
            Console.WriteLine("\nType your answer or enter a menu number:\n");
            string userAnswerOne = Console.ReadLine();
            if (userAnswerOne == _repo.answer)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine("Taylor the Evil Hacker: It.....it's impossible. This question, this beautiful, evil question should have been your downfall...BUT I WILL NOT GIVE UP JUST YET. Are you ready to meet your fate, young coder?");
                _repo.StandardText();
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                FourthChallenge();
            }
            else if (userAnswerOne == "1")
            {
                ProblemThree();
            }
            else if (userAnswerOne == "2")
            {
                TakeAThirdBreak();
            }
            else if (userAnswerOne != _repo.answer)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine("Taylor the Evil Hacker: HAHAHAAHAHHAAH YOU FOOL! Your JOB...your COMPUTER...your LIFE...the ERA OF THE MACHINE is OVER! \nYou have lost\nPress any key to continue...");
                Console.ReadKey();
                PrintMainMenu();
            }


        }

        public void ProblemThree()
        {
            _repo.StandardText();
            Console.WriteLine($"1. Trevor's Helplines: {_repo.trevorHelp} \n2. Praying Mantis Lucky Spirit Guides: {_repo.prayingMantis} \n3. Food: {_repo.food} pounds of food \n4. Use Item \n5. Return to riddle.");
            string useItem = Console.ReadLine();
            if (useItem == "4")
            {
                Console.WriteLine("Which item would you like to use? Type 1, 2, or 3... or 4 to exit");
                string useWhichItem = Console.ReadLine();
                switch (useWhichItem)
                {
                    case "1":
                        if (_repo.trevorHelp == 1)
                        {
                            Console.WriteLine($"The answer to our third riddle is {_repo.answer}");
                            _repo.trevorHelp--;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            _repo.AddHealthAndStress();
                            ThirdChallenge();
                        }
                        else if (_repo.trevorHelp == 0)
                        {
                            Console.WriteLine("Oops, Trevor cannot help you this time.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            _repo.AddHealthAndStress();
                            ThirdChallenge();
                        }
                        break;

                    case "2":
                        {
                            if (_repo.prayingMantis >= 1)
                            {
                                Console.WriteLine("The Praying Mantis Lucky Spirit Guide whispers that sometimes we must add something at the start of our life's journey and count forward from there.");
                                _repo.prayingMantis--;
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                _repo.AddHealthAndStress();
                                ThirdChallenge();
                            }
                            else if (_repo.prayingMantis <= 1)
                            {
                                Console.WriteLine("The Praying Mantis Lucky Spirit Guide whispers I am far too weak to assist you in your journey without $200....");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                _repo.AddHealthAndStress();
                                ThirdChallenge();

                            }
                            break;
                        }
                    case "3":
                        {
                            if (_repo.food >= 1)
                            {
                                Console.WriteLine("How much food would you like to eat?");
                                int foodEaten = Convert.ToInt32(Console.ReadLine());
                                _repo.food = _repo.food - foodEaten;
                                _repo.healthBar = _repo.healthBar + foodEaten;
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                _repo.AddHealthAndStress();
                                ThirdChallenge();
                            }
                            else if (_repo.food <= 1)
                            {
                                Console.WriteLine("You do not have any food left.");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                _repo.AddHealthAndStress();
                                ThirdChallenge();
                            }
                            break;
                        }

                    case "4":
                        {
                            Console.WriteLine($"{_repo.name}, Taylor the Evil Hacker is waiting for you....Time to solve that riddle.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            _repo.AddHealthAndStress();
                            ThirdChallenge();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input - Try again...");
                            Console.WriteLine("\nPress any key to continue....");
                            Console.ReadKey();
                            ProblemThree();
                            break;
                        }
                }
            }
            else if (useItem == "5")
            {
                Console.WriteLine($"{_repo.name}, Taylor the Evil Hacker is waiting for you....Time to solve that riddle.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _repo.AddHealthAndStress();
                ThirdChallenge();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input - Try again...");
                Console.WriteLine("\nPress any key to continue....");
                Console.ReadKey();
                ProblemThree();
            }



        }


        public void TakeAThirdBreak()
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to take a break? \nType y or n");
            string yessOrNoo = Console.ReadLine();
            if (yessOrNoo == "y")
            {
                Console.Clear();
                Console.WriteLine("You have taken a break for one hour \n Press any key to continue.");
                Console.ReadKey();
                _repo.AddHealthAndStress();
                _repo.stressBar = _repo.stressBar - 30;
                _repo.timePassed++;
                ThirdChallenge();
            }
            else
            {
                Console.Clear();
                _repo.AddHealthAndStress();
                ThirdChallenge();
            }
        }

        public void FourthChallenge()
        {
            _repo.stressBar = _repo.stressBar + 30;
            _repo.healthBar = _repo.healthBar - 50;
            if (_repo.healthBar <= 0)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine($"{_repo.name} has died of starvation. \nYou have lost.\nPress any key to continue...");
                Console.ReadKey();
                PrintMainMenu();
            }
            else if (_repo.stressBar >= 100)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine($"{_repo.name} has died of overstress. \nYou have lost.\nPress any key to continue...");
                Console.ReadKey();
                PrintMainMenu();
            }
            else if (_repo.timePassed >= 3)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine($"{_repo.name}, too much time has passed, and your boss has fired you for getting hacked by a supervillain. \nYou have lost.\nPress any key to continue...");
                Console.ReadKey();
                PrintMainMenu();
            }
            _repo.answer = "false";
            Console.Clear();
            _repo.TaylorText();
            Console.WriteLine("Taylor the Evil Hacker: THIS is your FINAL CHALLENGE...\nWait, I know I said that last time. But this - THIS is your LAST CHANCE to save the technology of the world. Continue on if you dare...");
            _repo.StandardText();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            _repo.TaylorText();
            Console.WriteLine("Taylor the Evil Hacker: What value will the following code return?\ndouble d1 = 1.000001d; \ndouble d2 = 0.000001d; \nConsole.WriteLine((d1-d2)==1.0);\n\n1. View Inventory\n\n2. Take a break");
            _repo.StandardText();
            Console.WriteLine($"\nHealth: {_repo.healthBar}\nStress: {_repo.stressBar}");
            Console.WriteLine("\nType your answer or enter a menu number:\n");
            string userAnswerOne = Console.ReadLine();
            if (userAnswerOne == _repo.answer)
            {
                Console.Clear();
                Console.WriteLine($"Taylor the Evil Hacker: .....\nTaylor the Evil Hacker:.........\nHe's gone?! {_repo.name}, you have defeated the supervillain Taylor the Evil Hacker, saved your computer and your job, and come out with your life!!");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                WinnersScreen();
            }
            else if (userAnswerOne == "1")
            {
                ProblemFour();
            }
            else if (userAnswerOne == "2")
            {
                TakeAFourthBreak();
            }
            else if (userAnswerOne != _repo.answer)
            {
                Console.Clear();
                _repo.TaylorText();
                Console.WriteLine("Taylor the Evil Hacker: HAHAHAAHAHHAAH YOU FOOL! Your JOB...your COMPUTER...your LIFE...the ERA OF THE MACHINE is OVER! \nYou have lost\nPress any key to continue...");
                Console.ReadKey();
                PrintMainMenu();
            }


        }

        public void ProblemFour()
        {
            _repo.StandardText();
            Console.WriteLine($"1. Trevor's Helplines: {_repo.trevorHelp} \n2. Praying Mantis Lucky Spirit Guides: {_repo.prayingMantis} \n3. Food: {_repo.food} pounds of food \n4. Use Item \n5. Return to riddle.");
            string useItem = Console.ReadLine();
            if (useItem == "4")
            {
                Console.WriteLine("Which item would you like to use? Type 1, 2, or 3... or 4 to exit");
                string useWhichItem = Console.ReadLine();
                switch (useWhichItem)
                {
                    case "1":
                        if (_repo.trevorHelp == 1)
                        {
                            Console.WriteLine($"The answer to our third riddle is {_repo.answer}");
                            _repo.trevorHelp--;
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            _repo.AddHealthAndStress();
                            FourthChallenge();
                        }
                        else if (_repo.trevorHelp == 0)
                        {
                            Console.WriteLine("Oops, Trevor cannot help you this time.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            _repo.AddHealthAndStress();
                            FourthChallenge();
                        }
                        break;

                    case "2":
                        {
                            if (_repo.prayingMantis >= 1)
                            {
                                Console.WriteLine("The Praying Mantis Lucky Spirit Guide whispers that often our values are approximations. Little in life is exact.");
                                _repo.prayingMantis--;
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                _repo.AddHealthAndStress();
                                FourthChallenge();
                            }
                            else if (_repo.prayingMantis <= 1)
                            {
                                Console.WriteLine("The Praying Mantis Lucky Spirit Guide whispers I am far too weak to assist you in your journey without $200....");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                _repo.AddHealthAndStress();
                                FourthChallenge();

                            }
                            break;
                        }
                    case "3":
                        {
                            if (_repo.food >= 1)
                            {
                                Console.WriteLine("How much food would you like to eat?");
                                int foodEaten = Convert.ToInt32(Console.ReadLine());
                                _repo.food = _repo.food - foodEaten;
                                _repo.healthBar = _repo.healthBar + foodEaten;
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                _repo.AddHealthAndStress();
                                FourthChallenge();
                            }
                            else if (_repo.food <= 1)
                            {
                                Console.WriteLine("You do not have any food left.");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                _repo.AddHealthAndStress();
                                FourthChallenge();
                            }
                            break;
                        }

                    case "4":
                        {
                            Console.WriteLine($"{_repo.name}, Taylor the Evil Hacker is waiting for you....Time to solve that riddle.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            _repo.AddHealthAndStress();
                            FourthChallenge();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input - Try again...");
                            Console.WriteLine("\nPress any key to continue....");
                            Console.ReadKey();
                            ProblemFour();
                            break;
                        }
                }
            }
            else if (useItem == "5")
            {
                Console.WriteLine($"{_repo.name}, Taylor the Evil Hacker is waiting for you....Time to solve that riddle.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _repo.AddHealthAndStress();
                FourthChallenge();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input - Try again...");
                Console.WriteLine("\nPress any key to continue....");
                Console.ReadKey();
                ProblemFour();
            }



        }


        public void TakeAFourthBreak()
        {
            _repo.StandardText();
            Console.Clear();
            Console.WriteLine("Are you sure you want to take a break? \nType y or n");
            string yessOrNoo = Console.ReadLine();
            if (yessOrNoo == "y")
            {
                Console.Clear();
                Console.WriteLine("You have taken a break for one hour \n Press any key to continue.");
                Console.ReadKey();
                _repo.stressBar = _repo.stressBar - 30;
                _repo.timePassed++;
                _repo.AddHealthAndStress();
                FourthChallenge();
            }
            else
            {
                _repo.AddHealthAndStress();
                Console.Clear();
                FourthChallenge();
            }
        }

        public void WinnersScreen()
        {
            Console.Clear();
            Console.WriteLine("Wow....An absolute hero among coders.  You did it...against all odds. Your job and company is safe!\n\n");
            _repo.Credits();

            Console.ReadKey();
            PrintMainMenu();
            {

            }

        }

    }
}