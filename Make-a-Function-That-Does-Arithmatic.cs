using System;

public class Kata
{
  public static double Arithmetic(double a, double b, string op)
  {
    if (op == "add"){
      return a+b;
    } else if (op == "subtract"){
      return a - b;
    }else if (op == "multiply"){
      return a*b;
    } else {
      return a/b;
    }
    throw new NotImplementedException();
  }
}
