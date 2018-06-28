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
      string userInput = "rock";
      RockPaperScissor playerOne = new RockPaperScissor(userInput);

      string expectedResult = playerOne.GetPick();

      Assert.AreEqual(userInput, expectedResult);
    }
  }
}
