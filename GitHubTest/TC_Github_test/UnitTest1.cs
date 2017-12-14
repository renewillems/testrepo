using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TC_Github_test
{
  [TestClass]
  public class UnitTest1
  {
    //1
    [TestCategory("Category [MSTest]")]
    [TestMethod()]
    public void TestMethod1a()
    {
      Assert.AreEqual(1, 1);
    }

    [TestCategory("Category [MSTest]")]
    [TestMethod()]
    public void TestMethod1b()
    {
      Assert.AreEqual(1, 1);
    }

    //2

    [TestCategory("Testset_002")]
    [TestMethod()]
    public void TestMethod2a()
    {
      Assert.AreEqual(2, 2);
    }

    [TestCategory("Testset_002")]
    [TestMethod()]
    public void TestMethod2b()
    {
      Assert.AreEqual(2, 2);
    }

    //3

    [TestCategory("Testset_003")]
    [TestMethod()]
    public void TestMethod3a()
    {
      Assert.AreEqual(3, 3);
    }

    [TestCategory("Testset_003")]
    [TestMethod()]
    public void TestMethod3b()
    {
      Assert.AreEqual(3, 3);
    }

    //4

    [TestCategory("Testset_004")]
    [TestMethod()]
    public void TestMethod4a()
    {
      Assert.AreEqual(4, 4);
    }

    [TestCategory("Testset_004")]
    [TestMethod()]
    public void TestMethod4b()
    {
      Assert.AreEqual(4, 4);
    }
  }
}