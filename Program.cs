﻿using System;

class RandomDiceRoller
{
    static void Main()
    {
        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;
        Console.WriteLine(total);

        if (total >= 14)
        {
            Console.WriteLine("You win!");
        }
        else if (total < 14)
        {
            Console.WriteLine("Sorry, you lose.");
        }

        else if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
           Console.WriteLine("You rolled doubles! +2 bonus to total!");
           total += 2;
        }


        string message = "The quick brown fox jumps over the lazy dog.";
        bool result = message.Contains("dog");
        Console.WriteLine(result);

     if (message.Contains("fox"))
     {
       Console.WriteLine("What does the fox say?");
      }
      }



}

