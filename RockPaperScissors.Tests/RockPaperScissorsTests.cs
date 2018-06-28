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
  }
}
