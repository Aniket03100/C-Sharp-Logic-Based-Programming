// LBP8

// Sum of Digits 

// Implement a program to calculate sum of digits present in the given number

// input -------------> a number from the user
// constraint --------> n>0
// output ------------> print sum of digits



public class Program
{
    public static void Main (string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int s, d;
        s = 0;

        while(n != 0)
        {
            d = n % 10;
            s = s + d;
            n = n / 10;

        }
        Console.WriteLine(s);
    }
}
