using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_Github_test
{
  public class Person
  {
    public virtual bool KodisionEmployee { get; set; }

   public virtual bool IsItAKodisionMember()
    {
      return (this.KodisionEmployee);
    }
  }
}
