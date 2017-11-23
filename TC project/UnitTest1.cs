using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TC_project
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Assert.AreEqual(1,1);
    }

    [TestMethod]
    public void TestMethod2()
    {
      Assert.AreEqual(2, 2);
    }

    [ClassInitialize]
    public static void TestClassInitialize(TestContext context)
    {
      var sad = context.Properties["webAppUrl"].ToString();
      if (sad != "asdfasd") Console.WriteLine("abc");
    }

    [TestMethod]
    public void TestMethod3()
    {
      Assert.AreEqual(3, 3);
      Console.WriteLine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase.ToString());

    }

  }
}
