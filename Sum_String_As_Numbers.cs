 using System;

namespace Sum_string_as_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Function("0099","11"));
        }
        //Console.WriteLine();
        static string Function(string a, string b)
        {
            string final = null;
            int plus = 0;
            int sum = 0;
            while (a.Length > b.Length)
                b = "0" + b;
            while (a.Length < b.Length)
                a = "0" + a;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                sum = plus + Convert.ToInt32(a[i]) + Convert.ToInt32(b[i]) - 96;
                plus = 0;
                if (sum > 9)
                {
                    sum -= 10;
                    plus = 1;
                }
                final = Convert.ToString(sum) + final;
            }
            if (plus == 1)
                final = "1" + final;
            while (final[0] == '0')
                final = final.Substring(1);
            return final;
        }
    }
}
