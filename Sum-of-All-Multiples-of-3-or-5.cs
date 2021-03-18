namespace Solution
{
  public static class Program
  {
    public static int findSum(int n)
    {
      int[] arr = new int [n];
      int num = 1;
      int i;
      int x;
      int sum = 0;

      for (i=0; i<n; i++){
        arr[i] = num;
        num++;
      }

      for (x=0; x<arr.Length; x++){
        if (arr[x]%3 == 0 || arr[x]%5 == 0){
          sum += arr[x];
        }
      }

      return sum;
    }
  }
}
