
using System;
using System.Collections.Generic;
using System.Linq;
using Game.ConsoleApp;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Threading;


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
            stressBar = stressBar - 30;
            healthBar = healthBar + 50;
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
 ██████╗ ██████╗ ██████╗ ██╗███╗   ██╗ ██████╗     ██╗  ██╗███████╗██████╗  ██████╗ 
██╔════╝██╔═══██╗██╔══██╗██║████╗  ██║██╔════╝     ██║  ██║██╔════╝██╔══██╗██╔═══██╗
██║     ██║   ██║██║  ██║██║██╔██╗ ██║██║  ███╗    ███████║█████╗  ██████╔╝██║   ██║
██║     ██║   ██║██║  ██║██║██║╚██╗██║██║   ██║    ██╔══██║██╔══╝  ██╔══██╗██║   ██║
╚██████╗╚██████╔╝██████╔╝██║██║ ╚████║╚██████╔╝    ██║  ██║███████╗██║  ██║╚██████╔╝
 ╚═════╝ ╚═════╝ ╚═════╝ ╚═╝╚═╝  ╚═══╝ ╚═════╝     ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝ ╚═════╝";

            Console.WriteLine(title);
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
        public void Credits()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Image Picture = Image.FromFile("./credits.png");
            Console.SetBufferSize((Picture.Width * 0x2), (Picture.Height * 0x2));
            Console.WindowWidth = 180;
            Console.WindowHeight = 61;

            FrameDimension Dimension = new FrameDimension(Picture.FrameDimensionsList[0x0]);
            int FrameCount = Picture.GetFrameCount(Dimension);
            int Left = Console.WindowLeft, Top = Console.WindowTop;
            char[] Chars = { '#', '#', '@', '%', '=', '+', '*', ':', '-', '.', ' ' };
            Picture.SelectActiveFrame(Dimension, 0x0);
            for (int i = 0x0; i < Picture.Height; i++)
            {
                for (int x = 0x0; x < Picture.Width; x++)
                {
                    Color Color = ((Bitmap)Picture).GetPixel(x, i);
                    int Gray = (Color.R + Color.G + Color.B) / 0x3;
                    int Index = (Gray * (Chars.Length - 0x1)) / 0xFF;
                    Console.Write(Chars[Index]);
                }
                Console.Write('\n');
                Thread.Sleep(100);
            }
            Console.SetCursorPosition(Left, Top);
            Console.Read();
            Console.WriteLine("Press any key to continue....");

        }



    }
}

