using System;
using System.Linq;

public class Kata
{
  public static int DuplicateCount(string str)
  {
    var count = str.ToLower().GroupBy(x => x).Select(y => y).Where(z=>z.Count()>1).Count();
    return count;
  }
}
