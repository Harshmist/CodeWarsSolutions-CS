using System;

public static class Kata
{
  public static int MakeNegative(int number)
  {
    if (number > 0){return number - (number * 2);}
    else {return number;}

  }
}
