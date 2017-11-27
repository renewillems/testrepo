using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TC_Github_test
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Assert.AreEqual(6, 6);
    }

    [TestMethod]
    public void TestMethod2()
    {
      Assert.AreEqual(8, 8);
    }

    [TestMethod]
    public void TestMethod3()
    {
      Assert.AreEqual(9, 9);
    }
  }
}
