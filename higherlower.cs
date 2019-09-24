using System;
using System.Collections.Generic;

class Game
{
    public int StartingPoint;
    public int LowPoint;
    public int HighPoint;
    public int RangeHigh;
    public int RangeLow;

    public Game()
    {
         StartingPoint = 50;
         LowPoint = 1;
         HighPoint = 100;

    }
    public int SplitUp()
    {
        RangeHigh = HighPoint - StartingPoint;
        RangeLow = StartingPoint - LowPoint;
        LowPoint = StartingPoint;
        StartingPoint  = LowPoint + RangeHigh /2 ;
        Console.WriteLine(StartingPoint);
        return StartingPoint;
    }
    public int SplitDown()
    {
        RangeHigh = HighPoint - StartingPoint;
        RangeLow = StartingPoint - LowPoint;
        HighPoint = StartingPoint;
        Console.WriteLine(StartingPoint);
        StartingPoint = StartingPoint - RangeLow / 2;
        Console.WriteLine(StartingPoint);
        return StartingPoint;
    }
    class Program
    {
        public static void Main()
        {
            
            Console.WriteLine("pick a number");
            Console.WriteLine("is your number Higher than 50?");
            Game game = new Game();
            string answer = Console.ReadLine();
            if(answer == "y")
            {
                Console.WriteLine("is your number higher than " + game.SplitUp());

                string answer2 = Console.ReadLine();
                if (answer2 == "y")
                {
                    Console.WriteLine("is your number higher than " + game.SplitUp());

                    string answer3 = Console.ReadLine();
                    if (answer3 == "y")
                    {
                    Console.WriteLine("is your number higher than " + game.SplitUp());

                    }
                }
            }
            else if(answer == "n")
            {
                Console.WriteLine("is your number higher than " + game.SplitDown());
            }
            else
            {
                Console.WriteLine("Woops");
            }
            
        }
    }

}