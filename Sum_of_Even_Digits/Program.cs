// LBP9

// Sum of even Digits 

// Implement a program to calculate sum of even digits present in the given number

// input -------------> a number from the user
// constraint --------> n>0
// output ------------> print sum of even digits


public class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int s = 0;
        int d;

        while(n != 0)
        {
            d = n % 10;
            if (n % 2 == 0)
                s = s + d;
            n = n / 10;
        }
        Console.WriteLine(s);
    }
}
