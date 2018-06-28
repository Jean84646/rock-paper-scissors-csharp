using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace Game.Tests
{
  [TestClass]
  public class RockPaperScissorTest
  {
    [TestMethod]
    public void GetPick_ReturnUserPick()
    {
      int userInput = 1;
      RockPaperScissor playerOne = new RockPaperScissor(userInput);

      int expectedResult = playerOne.GetPick();

      Assert.AreEqual(userInput, expectedResult);
    }
    [TestMethod]
    public void ConvertPick_ReturnPickString()
    {
      int userInput = 1;
      string pickString = "Rock";

      string expectedResult = RockPaperScissor.ConvertPick(userInput);

      Assert.AreEqual(pickString, expectedResult);
    }
    [TestMethod]
    public void GamePlay_RockVsScissor_RockWin()
    {
      int userInput = 1;
      RockPaperScissor playerOne = new RockPaperScissor(userInput);
      int computer = 3;
      string result = "Rock Win";

      string expectedResult = playerOne.GamePlay(computer);

      Assert.AreEqual(result, expectedResult);
    }
    [TestMethod]
    public void GamePlay_PaperVsRock_PaperWin()
    {
      int userInput = 2;
      RockPaperScissor playerOne = new RockPaperScissor(userInput);
      int computer = 1;
      string result = "Paper Win";

      string expectedResult = playerOne.GamePlay(computer);

      Assert.AreEqual(result, expectedResult);
    }
    [TestMethod]
    public void GamePlay_ScissorVsScissor_Draw()
    {
      int userInput = 3;
      RockPaperScissor playerOne = new RockPaperScissor(userInput);
      int computer = 3;
      string result = "Draw";

      string expectedResult = playerOne.GamePlay(computer);

      Assert.AreEqual(result, expectedResult);
    }
  }
}
