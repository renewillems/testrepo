using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TC_Github_test
{
  [TestClass]
  public class UnitTest1
  {
    [TestCategory("Testset_001")]
    [TestMethod]
    public void TestMethod1()
    {
      Assert.AreEqual(1, 1);
    }

    [TestCategory("Testset_002")]
    [TestMethod]
    public void TestMethod2()
    {
      Assert.AreEqual(2, 2);
    }

    [TestCategory("Testset_003")]
    [TestMethod]
    public void TestMethod3()
    {
      Assert.AreEqual(3, 3);
    }

    [TestCategory("Testset_004")]
    [TestMethod]
    public void TestMethod4()
    {
      Assert.AreEqual(4, 4);
    }
  }
}