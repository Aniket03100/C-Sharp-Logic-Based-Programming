// LBP7

// Extract Digits from the number

// Implement a program to extract digits from the given number

// input -------------> a number from the user
// constraint --------> n>0
// output ------------> print digits in line sep by space


public class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int d;

        while (n != 0)
        {
            d = n % 10;
            Console.Write(d + " ");
            n = n / 10;
        }
    }
}
