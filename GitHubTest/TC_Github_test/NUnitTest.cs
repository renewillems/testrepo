using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TC_Github_test
{
  [TestFixture]
  public class NUnitTest
  {
    [Test]
    [Category("NUnit")]
    public void MyFirstNUnitTest()
    {
      Assert.True(true);
    }
  }
}
