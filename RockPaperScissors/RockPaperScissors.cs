using System;
using System.Collections.Generic;

namespace Game
{
  public class RockPaperScissor
  {
    private int pick;
    public RockPaperScissor(int playerPick)
    {
      pick = playerPick;
    }
    public int GetPick()
    {
      return pick;
    }

    public string GamePlay(int otherPick)
    {
      int sum = pick + otherPick;
      if(sum == 2)
      {
        return "Draw";
      }
      else if(sum == 3)
      {
        return "Paper Win";
      }
      else if(sum == 4)
      {
        if(pick == 1)
        {
          return "Rock Win";
        }
        else
        {
          return "Draw";
        }
      }
      else if(sum == 5)
      {
        return "Scissor Win";
      }
      else if(sum == 6)
      {
        return "Draw";
      }
      else
      {
        return "Please learn how to read instruction";
      }
      // The superciliousfragililistic amazing Jean's method
      // if (pick == 'R')
      // {
      //   if (otherPick == 'R')
      //   {
      //     return "Draw";
      //   } else if (otherPick == 'P')
      //   {
      //     return "Paper wins";
      //   } else
      //   {
      //     return "Rock wins";
      //   }
      // } else if (pick == 'P')
      // {
      //   if (otherPick == 'R')
      //   {
      //     return "Paper wins";
      //   } else if (otherPick == 'P')
      //   {
      //     return "Draw";
      //   } else
      //   {
      //     return "Scissor wins";
      //   }
      // }  else
      // {
      //   if (otherPick == 'R')
      //   {
      //     return "Rock wins";
      //   } else if (otherPick == 'P')
      //   {
      //     return "Scissor wins";
      //   } else
      //   {
      //     return "Draw";
      //   }
      // }
    }
    public static string ConvertPick(int pick)
    {
      if(pick == 1)
      {
        return "Rock";
      }
      else if(pick == 2)
      {
        return "Paper";
      }
      else if(pick == 3)
      {
        return "Scissor";
      }
      else
      {
        return "Number out of range";
      }
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Rock, Paper, or Scissor?");
      Console.WriteLine("1. Rock");
      Console.WriteLine("2. Paper");
      Console.WriteLine("3. Scissor");
      int userPick = int.Parse(Console.ReadLine());
      RockPaperScissor playerOne = new RockPaperScissor(userPick);
      Random rnd = new Random();
      int rand = rnd.Next(1,4);
      string result = playerOne.GamePlay(rand);
      Console.WriteLine(RockPaperScissor.ConvertPick(playerOne.GetPick())
                        + " vs. " + RockPaperScissor.ConvertPick(rand)
                        + "\r\n" + result);
      Console.WriteLine("Would you like to play again? (Y/N)");
      string replay = Console.ReadLine();
      if(replay == "Y" || replay == "y")
      {
        Main();
      }
    }
  }
}
