using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_Github_test
{
  public class Checker
  {
    public bool ValidateMember(Person person)
    {
      if (person.IsItAKodisionMember() == false) return false;

      return true;
    }
  }
}