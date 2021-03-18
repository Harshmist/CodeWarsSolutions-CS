public class Kata
{
  public static double SumArray(double[] array)
  { double sum = 0;

   if (array.Length == 0 || array == null){
     sum =  0;
   } else{
   foreach (double val in array){
     sum +=val;
     }
   }
    return sum;
  }
}
