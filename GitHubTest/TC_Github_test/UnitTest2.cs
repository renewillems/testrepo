using System;
using System.Collections.Generic;
using Moq;
using Xunit;

namespace TC_Github_test
{
  public class MyXUnitTest
  {
    [Trait("Category", "XUnitTest")]
    [Fact]
    public static void XUnitTest()
    {
      Assert.Equal(6, 6);
    }

    [Trait("Category", "XUnitTest")]
    [Fact]
    public static void XUnitMoqTest()
    {
      var mPerson= new Mock<Person>();
      mPerson.Setup(x => x.KodisionEmployee).Returns(false);
      mPerson.Setup(x => x.IsItAKodisionMember()).Returns(true);

      var checker = new Checker();

      //Although the proptery of the mock object is False, it returns True
      var result = checker.ValidateMember(mPerson.Object);
   
      Assert.True(result, "Oops, it is NOT False, it is true");

    }
  }
}
