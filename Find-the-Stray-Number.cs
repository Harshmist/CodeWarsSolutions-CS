class Solution
{
  public static int Stray(int[] numbers)
  {
    int result = 0;
    foreach (var i in numbers)
    result ^= i;
    return result;
  }
}
