using System;
public class Predicter
{
    public static int PredictAge(int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8){

      int sum = 0;
      int[] arr = new int [] {age1 * age1, age2 * age2, age3 * age3, age4*age4, age5*age5, age6*age6, age7*age7, age8*age8};

      foreach (int val in arr){
        sum += val;
      }

      return Convert.ToInt32(Math.Floor((Math.Sqrt(sum) / 2)));
    }
}
