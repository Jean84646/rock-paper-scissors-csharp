using System;
using System.Collections.Generic;

namespace Game
{
  public class RockPaperScissor
  {
    private string pick;
    public RockPaperScissor(string playerPick)
    {
      pick = playerPick;
    }
    public string GetPick()
    {
      return pick;
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Rock, Paper, or Scissor? (R/P/S)");
      string userPick = Console.ReadLine();
      RockPaperScissor playerOne = new RockPaperScissor(userPick);
    }
  }
}
