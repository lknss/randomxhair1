﻿
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Getuserinput();


        static void Getuserinput()
        {
            bool closeapp = false;
            while (closeapp == false)
            {
                
                Console.WriteLine("\n\nMain Menu\n\n");
                Console.WriteLine("What would you like to do today?\n\n");
                Console.WriteLine("\n\n1 - Generate a new cross hair");
                Console.WriteLine("0 - Close application");


                string command = Console.ReadLine();
                switch (command)
                {
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Exiting program.");
                        closeapp = true;
                        break;
                    case "1":
                        GeneratexHair();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input please choose an option listed above");
                        break;
                }
            }
        }

        static void GeneratexHair()
        {
            Console.Clear();
            Random rand = new Random();
            int crosshairstyle = rand.Next(1, 5);
            int crosshairt = rand.Next(0, 1);
            int crosshaircolor = rand.Next(0, 5);
            int crosshairsize = rand.Next(1, 5);
            int crosshairthick = rand.Next((int)0.5, 2);
            int crosshairgap = rand.Next(-3, (int)2.5);
            int crosshairdot = rand.Next(0, 1);
            int drawoutline = rand.Next(0, 1);
            int outlinethick = rand.Next((int)0.5, 3);

            Console.WriteLine("\n\nYour Random Crosshair:");
            Console.WriteLine($"\n\ncl_crosshairstyle {crosshairstyle}; cl_crosshair_t {crosshairt}; cl_crosshaircolor {crosshaircolor}; " +
                $"cl_crosshairsize {crosshairsize}; cl_crosshairthickness {crosshairthick}; " +
                $"cl_crosshairgap {crosshairgap}; cl_crosshairdot {crosshairdot};" +
                $"cl_crosshair_drawoutline {drawoutline}; cl_crosshair_outlinethickness {outlinethick};\n\n  ");

            Console.WriteLine("Press any key to generate a new crosshair.");
            Console.WriteLine("Press 0 to return to main menu");

            string command = Console.ReadLine();

            switch (command)
            {
                case "0":
                    Console.Clear();
                    return;
                default:
                    GeneratexHair();
                    break;
            }
        }
    }
}