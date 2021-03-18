class Kata
{
    public static int[] RowWeights(int[] a)
    {
        //Do Some Magic
      int i;
      int num1 = 0;
      int num2 = 0;

      for (i=0; i<a.Length; i++){
        if ((i % 2==0) || i == 0){
          num1 += a[i];
        } else{
          num2 += a[i];
        }

      }
      int [] newArr = {num1, num2};
      return newArr;
    }
}
