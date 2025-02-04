﻿namespace Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey UserInput = ConsoleKey.None;
            VendOptions Vend = new VendOptions();
            do
            {
                Console.WriteLine("Please press a number to make a selection: \n" +
                    "(" + Vend.Number(1) + ") " + Vend.Option(1) + " \n" +
                    "(" + Vend.Number(2) + ") " + Vend.Option(2) + " \n" +
                    "(" + Vend.Number(3) + ") " + Vend.Option(3) + " \n" +
                    "(" + Vend.Number(4) + ") " + Vend.Option(4) + " \n" +
                    "(" + Vend.Number(5) + ") " + Vend.Option(5) + " \n" +
                    "(" + Vend.Number(6) + ") " + Vend.Option(6) + " \n" +
                    "(" + Vend.Number(7) + ") " + Vend.Option(7) + " \n" +
                    "(" + Vend.Number(0) + ") " + Vend.Option(0) + " \n");
                UserInput = Console.ReadKey().Key;
                //valid response
                if (CheckValidInput(UserInput, Vend))
                {
                    Console.Clear();
                    if (UserInput == ConsoleKey.D0)
                    {
                        Console.WriteLine("Please come again!");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Here is your " + Vend.Option(int.Parse(((char)UserInput).ToString())) + "\n");
                    }
                }
                //invalid response
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input\n");
                }
            } while (true);
        }
        //validates that a input is within the range of options
        static bool CheckValidInput(ConsoleKey input, VendOptions quantity)
        {
            int number;
            if (int.TryParse(((char)input).ToString(), out number))
            {
                if (number <= quantity.Count() - 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
