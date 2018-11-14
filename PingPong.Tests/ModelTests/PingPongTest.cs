using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongApp;

namespace PingPongApp.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void NumberFifteenReturnPingPong_True()
    {
        PingPong testPingPong = new PingPong();
    //   Assert.AreEqual(true, testPingPong.PingPongMethod(15));
    }
  }
}